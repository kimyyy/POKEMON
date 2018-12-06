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
		private SQLiteConnectionStringBuilder cBuilder;

		public MainForm()
		{
			InitializeComponent();
		}

		#region Load時

		private void MainForm_Load(object sender, EventArgs e)
		{
			// わざのデータを取得。
			cBuilder = new SQLiteConnectionStringBuilder { DataSource = "poketool.db" };

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

			ClearTextBox(groupBoxAttackPoke);
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
			var attackPoke = new Poke(textBoxAttackPoke.Text)
			{
				Level = (int)NumLevel.Value
			};
			var defencePoke = new Poke(textBoxDefencePoke.Text)
			{
				Level = (int)NumLevel.Value
			};
			var skill = new Waza(comboBoxSkill.Text);
			int[] damage = Util.CalculateDamage(attackPoke, defencePoke, skill);
			WriteResult("======================\r\n攻撃を開始します\r\n" +
				"ダメージは{0}～{1}です\r\n" +
				"攻撃をおわります\r\n======================\n", damage[0], damage[1]);
			textBoxResult.Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{

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

		#endregion

		#region フォーム用メソッド

		/// --------------------------------------------------------------------------------
		/// <summary>
		///     指定したコントロール内に含まれる TextBox の Text をクリアします。</summary>
		/// <param name="hParent">
		///     検索対象となる親コントロール。</param>
		/// --------------------------------------------------------------------------------
		private bool ClearTextBox(Control hParent)
		{
			// hParent 内のすべてのコントロールを列挙する
			foreach (Control cControl in hParent.Controls)
			{
				// 列挙したコントロールにコントロールが含まれている場合は再帰呼び出しする
				if (cControl.HasChildren == true)
				{
					ClearTextBox(cControl);
				}

				// コントロールの型が TextBoxBase からの派生型の場合は Text をクリアする
				if (cControl is TextBoxBase)
				{
					int ret;
					if (!(int.TryParse(cControl.Text, out ret)))
					{
						return false;
					}
				}
			}
			return true;
		}

		private bool CanParse()
		{
			return true;
		}

		private void WriteResult(string format, params Object[] args)
		{
			textBoxResult.AppendText(String.Format(format, args));
		}

		#endregion
	}
}
