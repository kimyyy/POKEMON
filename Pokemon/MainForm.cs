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
			Move Skill;

			// ポケモン、わざの準備
			try
			{
				Skill = new Move(comboBoxSkill.Text);
			}
			catch (Exception ex)
			{
				Util.ShowMessage(ex.Message);
				return;
			}

			var typeMatch = Util.CalculateTypeMatching(AttackPoke, DefencePoke, Skill);
			Util.ApplyItem(comboBoxItem.ToString(), Skill, AttackPoke, typeMatch);

			// ダメージ計算 0が低いほうで1が高いほう
			int[] damage = Util.CalculateDamage(AttackPoke, DefencePoke, Skill, Level);

			// 分析
			var percentHigh = ((double)damage[0] / DefencePoke.HPRemain)*100.0;
			var percentLow = ((double)damage[1] / DefencePoke.HPRemain)*100.0;

			percentHigh = Math.Round(percentHigh, MidpointRounding.AwayFromZero);
			percentLow = Math.Round(percentLow, MidpointRounding.AwayFromZero);

			// 結果を表示
			WriteResult("======================\r\n攻撃を開始します\r\n");
			WriteResult("ダメージは{0}～{1}です( {2}% ～ {3} % )\r\n", damage[0], damage[1], percentLow, percentHigh);
			WriteResult("攻撃をおわります\r\n======================\n");
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


		/// --------------------------------------------------------------------------------
		/// <summary>
		///     指定したコントロール内に含まれる TextBox の Text をクリアします。</summary>
		/// <param name="hParent">
		///     検索対象となる親コントロール。</param>
		/// --------------------------------------------------------------------------------
		private bool ParseTextBox(Control hParent, int[] array)
		{
			// hParent 内のすべてのコントロールを列挙する
			foreach (Control cControl in hParent.Controls)
			{
				// 列挙したコントロールにコントロールが含まれている場合は再帰呼び出しする
				if (cControl.HasChildren == true)
				{
					ParseTextBox(cControl, array);
				}

				// コントロールの型が TextBoxBase からの派生型の場合は Text をクリアする
				if (cControl is TextBoxBase)
				{
					if (!(int.TryParse(cControl.Text, out int num)))
					{
						array = new int[6];
						return false;
					}
					switch (cControl.Tag.ToString())
					{
						case "H":
							array[0] = num;
							break;
						case "A":
							array[1] = num;
							break;
						case "B":
							array[2] = num;
							break;
						case "C":
							array[3] = num;
							break;
						case "D":
							array[4] = num;
							break;
						case "S":
							array[5] = num;
							break;

					}
				}
			}
			return true;
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

		private void WriteResult(string format, params Object[] args)
		{
			textBoxResult.AppendText(String.Format(format, args));
			textBoxResult.Refresh();
		}

		private void AttackPoke_Changed()
		{
			comboBoxSkill.Items.Clear();

			// わざのデータを取得。
			var cBuilder = new SQLiteConnectionStringBuilder { DataSource = "poketool.db" };
			using (var cn = new SQLiteConnection(cBuilder.ToString()))
			{
				cn.Open();
				using (var cmd = new SQLiteCommand(cn))
				{
					cmd.CommandText = String.Format("select * from pokewaza where name = '{0}' ", AttackPoke.Name);
					var reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						comboBoxSkill.Items.Add(reader["waza"].ToString());
					}
				}
			}
		}

		#endregion
	}
}