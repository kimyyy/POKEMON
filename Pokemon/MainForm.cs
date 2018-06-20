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

		private string[] arrayType = new string[]
		{"ノーマル", "ほのお", "みず" , "でんき", "くさ","こおり", "かくとう", "どく", "じめん",
			"ひこう", "エスパー", "むし", "いわ", "ゴースト", "ドラゴン", "あく", "はがね", "フェアリー"};

		private double[,] arrayTypeMatch = new double[18,18]
		{
			{1,1,1,1,1,1,1,1,1,1,1,1,0.5,0,1,1,0.5,1 },//ノーマル
			{1,0.5,0.5,1,2,2,1,1,1,1,1,2,0.5,1,0.5,1,2,1 },//ほのお
			{1,2,0.5,1,0.5,1,1,1,2,1,1,1,2,1,0.5,1,1,1 },//みず
			{1,1,2,0.5,0.5,1,1,1,0,2,1,1,1,1,0.5,1,1,1 },//でんき
			{ 1,0.5,2,1,0.5,1,1,0.5,2,0.5,1,0.5,2,1,0.5,1,0.5,1 },//くさ
			{1,0.5,0.5,1,2,0.5,1,1,2,2,1,1,1,1,2,1,0.5,1 },//こおり
			{2,1,1,1,1,2,1,0.5,1,0.5,0.5,0.5,2,0,1,2,2,0.5 },//かくとう
			{1,1,1,1,2,1,1,0.5,0.5,1,1,1,0.5,0.5,1,1,0,2 },//どく
			{1,2,1,2,0.5,1,1,2,1,0,1,0.5,2,1,1,1,2,1 },//じめん
			{1,1,1,0.5,2,1,2,1,1,1,1,2,0.5,1,1,1,0.5,1 },//ひこう
			{1,1,1,1,1,1,2,2,1,1,0.5,1,1,1,1,0,0.5,1 },//エスパー
			{1,0.5,1,1,2,1,0.5,0.5,1,0.5,2,1,1,0.5,1,2,0.5,0.5 },//むし
			{1,2,1,1,1,2,0.5,1,0.5,2,1,2,1,1,1,1,0.5,1 },//いわ
			{0,1,1,1,1,1,1,1,1,1,2,1,1,2,1,0.5,1,1 },//ゴースト
			{1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,0.5,0 },//ドラゴン
			{1,1,1,1,1,1,0.5,1,1,1,2,1,1,2,1,0.5,1,0.5 },//あく
			{1,0.5,0.5,0.5,1,2,1,1,1,1,1,1,2,1,1,1,0.5,2 },//はがね
			{1,0.5,1,1,1,1,2,0.5,1,1,1,1,1,1,2,2,0.5,1 }//フェアリー
		};

		public MainForm()
		{
			InitializeComponent();
		}

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
		}

		/// <summary>
		/// 純粋ダメージ量を計算します。
		/// </summary>
		/// <returns></returns>
		private int[] CalculateDamage(Pokemon attackPoke,Pokemon defensePoke, Waza skill)
		{
			int temp = attackPoke.level * 2 / 5 + 2;
			if(skill.category == "物理")
			{
				temp = temp * skill.damage * attackPoke.a / defensePoke.b;
			}
			else
			{
				temp = temp * skill.damage * attackPoke.c / defensePoke.c;
			}
			
			temp = temp / 50 + 2;
			var r = new Random();
			int templow = (int)(temp * 0.85);
			int temphigh = temp;
			templow = (int) (templow * CalculateTypeMatching(attackPoke,defensePoke, skill));
			temphigh = (int)(temphigh * CalculateTypeMatching(attackPoke,defensePoke, skill));
			var ret = new int[] { templow, temphigh };
			return ret;
		}

		/// <summary>
		/// タイプ相性を計算します。
		/// </summary>
		/// <param name="defensePokemon"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		private double CalculateTypeMatching(Pokemon attackPokemon,Pokemon defensePokemon, Waza skill)
		{
			int skilltype = Array.IndexOf(arrayType, skill.type);
			int type1 = Array.IndexOf(arrayType, defensePokemon.type1);
			double sametype = 1;
			if (attackPokemon.type1 == skill.type || attackPokemon.type2 == skill.type) sametype = 1.5;
			if (defensePokemon.type2 == string.Empty)
			{
				return arrayTypeMatch[skilltype, type1] * sametype;
			}
			int type2 = Array.IndexOf(arrayType, defensePokemon.type2);
			return arrayTypeMatch[skilltype, type1] * arrayTypeMatch[skilltype, type2] * sametype;
		}

		private void buttonAttack_Click(object sender, EventArgs e)
		{
			var attackPoke = new Pokemon(textBoxAttackPoke.Text)
			{
				level = int.Parse(BoxLevel.Text)
			};
			var defencePoke = new Pokemon(textBoxDefencePoke.Text)
			{
				level = int.Parse(BoxLevel.Text)
			};
			var skill = new Waza(comboBoxSkill.Text);
			int[] damage = CalculateDamage(attackPoke, defencePoke, skill);
			textBoxResult.AppendText("======================\n");
			textBoxResult.AppendText("攻撃を開始します。\n");
			textBoxResult.AppendText(string.Format("ダメージは{0}～{1}です\n",damage[0], damage[1]));
			textBoxResult.AppendText("攻撃をおわります\r\n======================\n");
			textBoxResult.Refresh();
		}
	}
}
