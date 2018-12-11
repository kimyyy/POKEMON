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

namespace Pokemon
{
	public partial class MainForm : Form
	{
		private int Level;

		private Poke AttackPoke;

		private Poke DefencePoke;

		private Poke[] MyParty = new Poke[6] {new Poke("リザードン"), new Poke("カメックス"), new Poke("フシギバナ"),
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
			// わざのデータを取得。
			var cBuilder = new SQLiteConnectionStringBuilder { DataSource = "poketool.db" };
			using (var cn = new SQLiteConnection(cBuilder.ToString()))
			{
				cn.Open();
				using (var cmd = new SQLiteCommand(cn))
				{
					cmd.CommandText = "select * from waza";
					var reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						comboBoxSkill.Items.Add(reader["name"].ToString());
					}
				}
			}

			InitSettings();
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
			Poke attackPoke;
			Poke defencePoke;
			Waza Skill;

			// ポケモン、わざの準備
			try
			{
				attackPoke = new Poke(textBoxAttackPoke.Text);
				defencePoke = new Poke(textBoxDefencePoke.Text);
				Skill = new Waza(comboBoxSkill.Text);
			}
			catch (Exception ex)
			{
				WriteResult(ex.Message + "\r\n");
				return;
			}
			UpdateStatus(attackPoke);
			UpdateStatus(defencePoke);

			var typeMatch = Util.CalculateTypeMatching(attackPoke, defencePoke, Skill);
			Util.ApplyItem(comboBoxItem.ToString(), Skill, AttackPoke, typeMatch);

			// ダメージ計算
			int[] damage = Util.CalculateDamage(attackPoke, defencePoke, Skill, Level);

			// 結果を表示
			WriteResult("======================\r\n攻撃を開始します\r\n" +
				"ダメージは{0}～{1}です\r\n" +
				"攻撃をおわります\r\n======================\n", damage[0], damage[1]);
		}

		private void textBoxPoke_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(string)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void textBoxPoke_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(string)))
			{
				TextBox target = (TextBox)sender;
				string itemText = (string)e.Data.GetData(typeof(string));

				target.Text = itemText;
			}
		}

		private void ListboxParty_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				// ドラッグの準備
				ListBox lb = (ListBox)sender;
				int itemIndex = lb.IndexFromPoint(e.X, e.Y);
				if (itemIndex < 0) return;

				// アイテムの内容を取得
				string itemText = (string)lb.Items[itemIndex];

				// start drag and drop
				DragDropEffects dde = lb.DoDragDrop(itemText, DragDropEffects.Copy);
			}
		}

		private void buttonStatus_click(object sender, EventArgs e)
		{
			AttackPoke = new Poke(textBoxAttackPoke.Text);
			UpdateStatus(AttackPoke);
		}

		#endregion

		#region フォーム用メソッド

		private void InitSettings()
		{
			Level = (int)NumLevel.Value;

			// パーティをリストボックスに格納する。
			foreach (Poke poke in MyParty)
			{
				listBoxMyParty.Items.Add(poke.Name);
			}
			foreach (Poke poke in MyParty)
			{
				listBoxEnemyParty.Items.Add(poke.Name);
			}
		}

		private void UpdateStatus(Poke poke)
		{
			// ポケモン、性格を決める。
			var personality = Util.DecidePersonality(comboBoxPersonality.Text);
			int[] arrayEffort = new int[6];
			int[] arrayIndi = new int[6];
			ParseTextBox(panelEffort, arrayEffort);
			ParseTextBox(panelIndi, arrayIndi);
			poke.Effort = arrayEffort;
			poke.Indi = arrayIndi;

			// ステータス計算
			poke.CalculateStatus(personality, Level);

			// ラベルを更新
			labelStatusH.Text = poke.StatusH.ToString();
			labelStatusA.Text = poke.StatusA.ToString();
			labelStatusB.Text = poke.StatusB.ToString();
			labelStatusC.Text = poke.StatusC.ToString();
			labelStatusD.Text = poke.StatusD.ToString();
			labelStatusS.Text = poke.StatusS.ToString();
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

		#endregion
	}
}