using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
	public partial class StatusForm : Form
	{
		public Poke Poke;

		private int[] FormIndi = new int[6];

		private int[] FormEffort = new int[6];

		private int[] FormStatus;

		private TextBox[] textBoxesIndi;

		private TextBox[] textBoxesEffort;

		private Label[] labelStatus;

		private int Level;

		private Util.Nature Nature;

		/// <summary>
		/// コンストラクターです。
		/// </summary>
		/// <param name="poke"></param>
		public StatusForm(Poke poke)
		{
			InitializeComponent();
			Poke = poke;
			Level = poke.Level;
		}

		private void StatusForm_Load(object sender, EventArgs e)
		{
			// textbox を配列に格納する。
			textBoxesIndi = new TextBox[6] { textBoxIndiHP, textBoxIndiA, textBoxIndiB, textBoxIndiC, textBoxIndiD, textBoxIndiS };
			textBoxesEffort = new TextBox[6] { textBoxEffortHP, textBoxEffortA, textBoxEffortB, textBoxEffortC, textBoxEffortD, textBoxEffortS };
			labelStatus = new Label[6] { labelStatusH, labelStatusA, labelStatusB, labelStatusC, labelStatusD, labelStatusS };

			// ポケモンをフォームに反映する。
			PictureBoxPoke.Poke = Poke;

			// ポケモンの情報をフォームに反映
			// 個体値、努力値、ステータス
			for (var i = 0; i < 6; i++)
			{
				textBoxesIndi[i].Text = Poke.Indi[i].ToString();
				textBoxesEffort[i].Text = Poke.Effort[i].ToString();
				labelStatus[i].Text = Poke.Status[i].ToString();
			}

			// とくせい
			for (int i = 3; i < 6; i++)
			{
				if (Poke.ConstStringParams[i] != "")
				{
					comboBoxChara.Items.Add(Poke.ConstStringParams[i].ToString());
				}
			}

			// せいかく
			Nature = Poke.Nature;
			comboBoxChara.Text = Nature.ToString();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			UpdateStatus();

			// フォームの情報をポケモンに反映
			Poke.Indi = FormIndi;
			Poke.Effort = FormEffort;
			Poke.Status = FormStatus;
			Poke.Nature = Nature;

			// フォームを閉じる
			DialogResult = DialogResult.OK;
		}

		/// <summary>
		/// ステータスを計算し、フォーム内に記憶させます。
		/// </summary>
		private void UpdateStatus()
		{
			// 個体値、努力値が適切なものかチェック
			if (!CanParseTextBox()) return;

			// ステータスを計算
			FormStatus = Util.CalculateStatus(Poke.Syuzoku, FormIndi, FormEffort, Level, Nature);
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
			UpdateStatus();

			// ステータスラベルを更新
			for (var i = 0; i < 6; i++)
			{
				labelStatus[i].Text = FormStatus[i].ToString();
			}
		}

		// テキストボックスの情報を変換し、成功すればフォームに保存します。
		private bool CanParseTextBox()
		{
			int[] tempIndi = new int[6];
			int[] tempEffort = new int[6];
			for (var i = 0; i < 6; i++)
			{
				int parsedInt;
				if (!int.TryParse(textBoxesIndi[i].Text, out parsedInt)) return false;
				if (parsedInt < 0 || 31 < parsedInt) return false;
				tempIndi[i] = parsedInt;
			}
			for (var i = 0; i < 6; i++)
			{
				int parsedInt;
				if (!int.TryParse(textBoxesEffort[i].Text, out parsedInt)) return false;
				if (parsedInt < 0 || 255 < parsedInt) return false;
				tempEffort[i] = parsedInt;
			}

			// せいかくを取得
			foreach(Util.Nature nature in Enum.GetValues(typeof(Util.Nature)))
			{
				if(comboBoxChara.Text == nature.ToString())
				{
					Nature = nature;
					break;
				}
			}
			FormIndi = tempIndi;
			FormEffort = tempEffort;
			return true;
		}
	}
}
