using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Pokemon
{
	partial class MainForm : Form
	{
		private int Level;

		private Poke AttackPoke;

		private Poke DefencePoke;

		private Poke[] MyParty = new Poke[6] {new Poke("ギルガルド盾"), new Poke("カメックス"), new Poke("フシギバナ"),
			new Poke("ピカチュウ"), new Poke("ピチュー"), new Poke("タマタマ")};
		private Poke[] EnemyParty = new Poke[6]{new Poke("リザードン"), new Poke("カメックス"), new Poke("フシギバナ"),
			new Poke("ピカチュウ"), new Poke("ピチュー"), new Poke("タマタマ")};

		public MainForm()
		{
			InitializeComponent();
		}

		#region Load時

		private void MainForm_Load(object sender, EventArgs e)
		{
			Level = (int)NumLevel.Value;

			// レベルを登録
			foreach (Poke poke in MyParty)
			{
				poke.Level = Level;
				// とりあえずステータスを計算しておく
				poke.Status = Util.CalculateStatus(poke.Syuzoku, poke.Indi, poke.Effort, poke.Level, poke.Nature);
				poke.HPRemain = poke.StatusH;
				poke.IsMyParty = true;
			}
			foreach (Poke poke in EnemyParty)
			{
				poke.Level = Level;
				// とりあえずステータスを計算しておく
				poke.Status = Util.CalculateStatus(poke.Syuzoku, poke.Indi, poke.Effort, poke.Level, poke.Nature);
				poke.HPRemain = poke.StatusH;
				poke.IsMyParty = false;
			}

			// パーティをパネルに格納する。
			PanelMyParty.Party = MyParty;
			PanelEnemyParty.Party = EnemyParty;
		}

		#endregion

		#region イベントハンドラー

		/// <summary>
		/// 攻撃ボタンを押したとき
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonAttack_Click(object sender, EventArgs e)
		{
			if (!CanParse()) return;
			Move move;

			// ポケモン、わざの準備
			try
			{
				move = new Move(comboBoxSkill.Text);
			}
			catch (Exception ex)
			{
				Util.ShowMessage(ex.Message);
				return;
			}

			WriteResult("=============================================\r\n");
			WriteResult("\r\n");
			WriteResult("{0} のこうげき！ {1}\r\n", AttackPoke.Name, move.Name);

			// タイプ相性を計算
			var typeMatch = Util.CalculateTypeMatching(AttackPoke, DefencePoke, move);
			if(typeMatch >= 2.0)
			{
				WriteResult("こうかは ばつぐんだ！\r\n");
			}
			if(typeMatch <= 0.5)
			{
				WriteResult("こうかは いまひとつだ...\r\n");
			}

			// アイテムの考慮
			if (comboBoxItem.SelectedItem != null)
			{
				Util.ApplyItem(comboBoxItem.SelectedItem.ToString(), move, AttackPoke, typeMatch);
			}

			// ダメージ計算 0が低いほうで1が高いほう
			int[] damage = Util.CalculateDamage(AttackPoke, DefencePoke, move, Level);

			// 分析
			var percentLow = ((double)damage[0] / DefencePoke.HPRemain) * 100.0;
			var percentHigh = ((double)damage[1] / DefencePoke.HPRemain) * 100.0;

			percentLow = Math.Round(percentLow, MidpointRounding.AwayFromZero);
			percentHigh = Math.Round(percentHigh, MidpointRounding.AwayFromZero);

			// 結果を表示
			WriteResult("ダメージは {0}～{1} ( {2} % ～ {3} % )\r\n", damage[0], damage[1], percentLow, percentHigh);
			if(percentLow >= 34)
			{
				var kaku = 3;
				if (percentLow >= 50) kaku = 2;
				if (percentLow >= 100) kaku = 1;
				WriteResult("確 {0} です\r\n", kaku);
			}
			WriteResult("\r\n");
			//WriteResult("攻撃をおわります================================\r\n\r\n");

			// デモ用
			var remain = DefencePoke.HPRemain - damage[1];
			if(remain >= 0)
			{
				DefencePoke.HPRemain = remain;
			}
			else
			{
				DefencePoke.HPRemain = 0;
				WriteResult("{0} はたおれた！\r\n", DefencePoke.Name);
			}
			UpdateProgressBars(false);

			WriteResult("\r\n");
		}

		private void AttackPoke_Changed()
		{
			comboBoxSkill.Items.Clear();
			string name = AttackPoke.Name;
			if (name == "ギルガルド盾" || name == "ギルガルド剣")
			{
				name = "ギルガルド";
			}
			// わざのデータを取得。
			var cBuilder = new SQLiteConnectionStringBuilder { DataSource = "poketool.db" };
			using (var cn = new SQLiteConnection(cBuilder.ToString()))
			{
				cn.Open();
				using (var cmd = new SQLiteCommand(cn))
				{
					cmd.CommandText = String.Format("select * from pokewaza where name = '{0}' ", name);
					var reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						comboBoxSkill.Items.Add(reader["waza"].ToString());
					}
				}
			}
		}

		private void PokePicAttackPoke_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Poke)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void panelPoke_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Poke)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void panelPoke_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Poke)))
			{
				var destPanel = (Panel)sender;
				var Poke = (Poke)e.Data.GetData(typeof(Poke));
				var destPic = (PictureBoxPoke)destPanel.GetChildAtPoint(new Point(0, 0));
				if (destPic.IsMyPoke != Poke.IsMyParty)
				{
					Util.ShowMessage("異なる側のパーティーです。");
					return;
				}
				if (Poke.IsMyParty)
				{
					AttackPoke = destPic.Poke = Poke;
					AttackPoke.IsAttack = true; // TODO 本当はここにあるべきではない。
					AttackPoke_Changed();
					UpdateProgressBars(true);
				}
				else
				{
					DefencePoke = destPic.Poke = Poke;
					DefencePoke.IsAttack = false;
					UpdateProgressBars(false);
				}
			}
		}

		private void comboBoxSkill_TextChanged(object sender, EventArgs e)
		{

		}


		private void buttonResetHP_Click(object sender, EventArgs e)
		{
			AttackPoke.HPRemain = AttackPoke.StatusH;
			DefencePoke.HPRemain = DefencePoke.StatusH;
			UpdateProgressBars(true);
			UpdateProgressBars(false);
		}

		#endregion

		#region フォーム用メソッド

		/// <summary>
		/// プログレスバーを更新
		/// </summary>
		private void UpdateProgressBars(bool IsAttackPoke)
		{
			if (IsAttackPoke)
			{
				progressBarMyPoke.Maximum = AttackPoke.StatusH;
				progressBarMyPoke.Value = AttackPoke.HPRemain;
			}
			else
			{
				progressBarEnemyPoke.Maximum = DefencePoke.StatusH;
				progressBarEnemyPoke.Value = DefencePoke.HPRemain;
			}
		}

		private void ParseTextBox(Control hParent)
		{
			foreach (Control cControl in hParent.Controls)
			{
				if (cControl.HasChildren)
				{
					ParseTextBox(cControl);
				}

				if (cControl is TextBoxBase)
				{
					WriteResult(cControl.Tag.ToString());
				}
			}
		}

		/// <summary>
		/// 数値が正しく入力されているかチェックします。未実装
		/// </summary>
		/// <returns></returns>
		private bool CanParse()
		{
			return true;
		}

		/// <summary>
		/// 結果を表示させます。
		/// </summary>
		/// <param name="format"></param>
		/// <param name="args"></param>
		private void WriteResult(string format, params Object[] args)
		{
			textBoxResult.AppendText(String.Format(format, args));
			textBoxResult.Refresh();
		}

		#endregion
	}
}