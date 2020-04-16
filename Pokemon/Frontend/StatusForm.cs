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
			// ポケモンをフォームに反映する。
			PictureBoxPoke.Poke = Poke;

			Text = Poke.Name + " のステータス設定";

			// textbox を配列に格納する。
			textBoxesIndi = new TextBox[6] { textBoxIndiHP, textBoxIndiA, textBoxIndiB, textBoxIndiC, textBoxIndiD, textBoxIndiS };
			textBoxesEffort = new TextBox[6] { textBoxEffortHP, textBoxEffortA, textBoxEffortB, textBoxEffortC, textBoxEffortD, textBoxEffortS };
			labelStatus = new Label[6] { labelStatusH, labelStatusA, labelStatusB, labelStatusC, labelStatusD, labelStatusS };

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
			comboBoxNature.Text = Nature.ToString();

			// とくせい
			if(Poke.SelectedChara !=null)comboBoxChara.Text = Poke.SelectedChara;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			UpdateStatus();

			// フォームの情報をポケモンに反映
			Poke.Indi = FormIndi;
			Poke.Effort = FormEffort;
			Poke.Status = FormStatus;
			Poke.Nature = Nature;
			Poke.SelectedChara = comboBoxChara.Text;

			// フォームを閉じる
			DialogResult = DialogResult.OK;
		}

		/// <summary>
		/// ステータスを計算し、フォーム内に保存します
		/// </summary>
		private void UpdateStatus()
		{
			// 個体値、努力値が適切なものかチェック
			if (!CanParseTextBox()) return;

			// ステータスを計算
			FormStatus = Util.CalcBasicStatus(Poke.Syuzoku, FormIndi, FormEffort, Level, Nature);
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

		/// <summary>
		/// テキストボックスの情報を変換し、成功すればフォームに保存。失敗すればダイアログをだす。
		/// </summary>
		/// <returns>変換に成功したかどうか</returns>
		private bool CanParseTextBox()
		{
			int[] tempIndi = new int[6];
			int[] tempEffort = new int[6];
			for (var i = 0; i < 6; i++)
			{
				int parsedInt;
				if (!int.TryParse(textBoxesIndi[i].Text, out parsedInt))
				{
					Util.ShowMessage("変換に失敗しました。: 個体値の欄をみてください。");
					return false;
				}
				if (parsedInt < 0 || 31 < parsedInt)
				{
					Util.ShowMessage("個体値が範囲を超えています。");
					return false;
				}
				tempIndi[i] = parsedInt;
			}
			for (var i = 0; i < 6; i++)
			{
				int parsedInt;
				if (!int.TryParse(textBoxesEffort[i].Text, out parsedInt))
				{
					Util.ShowMessage("努力値の変換に失敗しました。");
					return false;
				}
				if (parsedInt < 0 || 255 < parsedInt)
				{
					Util.ShowMessage("度蝕知が範囲を超えています。");
					return false;
				}
				tempEffort[i] = parsedInt;
			}

			// せいかくを取得
			foreach (Util.Nature nature in Enum.GetValues(typeof(Util.Nature)))
			{
				if (comboBoxNature.Text == nature.ToString())
				{
					Nature = nature;
					break;
				}
			}
			FormIndi = tempIndi;
			FormEffort = tempEffort;
			return true;
		}

		private void label20_Click(object sender, EventArgs e)
		{

		}
	}
}
