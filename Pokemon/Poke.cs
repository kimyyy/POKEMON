using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;

namespace Pokemon
{
	public class Poke
	{
		#region フィールド

		#region 各ステータス

		private string[] ParamsString = { "name", "type1", "type2", "chara1", "chara2", "dchara", "id" };

		public string[] ConstStringParams = new string[7];

		public string Name { get { return ConstStringParams[0]; } set { ConstStringParams[0] = value; } }
		public string type1 { get { return ConstStringParams[1]; } set { ConstStringParams[1] = value; } }
		public string type2 { get { return ConstStringParams[2]; } set { ConstStringParams[2] = value; } }
		public string Chara1 { get { return ConstStringParams[3]; } set { ConstStringParams[3] = value; } }
		public string Chara2 { get { return ConstStringParams[4]; } set { ConstStringParams[4] = value; } }
		public string DChara { get { return ConstStringParams[5]; } set { ConstStringParams[5] = value; } }
		public string ID { get { return ConstStringParams[6]; } set { ConstStringParams[6] = value; } }

		public int[] Syuzoku = new int[6];

		public int SyuzokuH { get { return Syuzoku[0]; } set { Syuzoku[0] = value; } }
		public int SyuzokuA { get { return Syuzoku[1]; } set { Syuzoku[1] = value; } }
		public int SyuzokuB { get { return Syuzoku[2]; } set { Syuzoku[2] = value; } }
		public int SyuzokuC { get { return Syuzoku[3]; } set { Syuzoku[3] = value; } }
		public int SyuzokuD { get { return Syuzoku[4]; } set { Syuzoku[4] = value; } }
		public int SyuzokuS { get { return Syuzoku[5]; } set { Syuzoku[5] = value; } }
		public int Sum;

		public int[] Indi = new int[6];

		public int IndiH { get { return Indi[0]; } set { Indi[0] = value; } }
		public int IndiA { get { return Indi[1]; } set { Indi[1] = value; } }
		public int IndiB { get { return Indi[2]; } set { Indi[2] = value; } }
		public int IndiC { get { return Indi[3]; } set { Indi[3] = value; } }
		public int IndiD { get { return Indi[4]; } set { Indi[4] = value; } }
		public int IndiS { get { return Indi[5]; } set { Indi[5] = value; } }

		public int[] Effort = new int[6];

		public int EffortH { get { return Effort[0]; } set { Effort[0] = value; } }
		public int EffortA { get { return Effort[1]; } set { Effort[1] = value; } }
		public int EffortB { get { return Effort[2]; } set { Effort[2] = value; } }
		public int EffortC { get { return Effort[3]; } set { Effort[3] = value; } }
		public int EffortD { get { return Effort[4]; } set { Effort[4] = value; } }
		public int EffortS { get { return Effort[5]; } set { Effort[5] = value; } }

		public int[] Status = new int[6];

		public int StatusH { get { return Status[0]; } set { Status[0] = value; } }
		public int StatusA { get { return Status[1]; } set { Status[1] = value; } }
		public int StatusB { get { return Status[2]; } set { Status[2] = value; } }
		public int StatusC { get { return Status[3]; } set { Status[3] = value; } }
		public int StatusD { get { return Status[4]; } set { Status[4] = value; } }
		public int StatusS { get { return Status[5]; } set { Status[5] = value; } }

		public int[] Rank = new int[5];

		public int RankA
		{
			get { return Rank[0]; }
			set
			{
				if (value < -6)
				{
					Rank[0] = -6;
				}
				else if (value > 6)
				{
					Rank[0] = 6;
				}
				else
				{
					Rank[0] = value;
				}
			}
		}

		public int RankB
		{
			get { return Rank[1]; }
			set
			{
				if (value < -6)
				{
					Rank[1] = -6;
				}
				else if (value > 6)
				{
					Rank[1] = 6;
				}
				else
				{
					Rank[1] = value;
				}
			}
		}

		public int RankC
		{
			get { return Rank[2]; }
			set
			{
				if (value < -6)
				{
					Rank[2] = -6;
				}
				else if (value > 6)
				{
					Rank[2] = 6;
				}
				else
				{
					Rank[2] = value;
				}
			}
		}

		public int RankD
		{
			get { return Rank[3]; }
			set
			{
				if (value < -6)
				{
					Rank[3] = -6;
				}
				else if (value > 6)
				{
					Rank[3] = 6;
				}
				else
				{
					Rank[3] = value;
				}
			}
		}

		public int RankS
		{
			get { return Rank[4]; }
			set
			{
				if (value < -6)
				{
					Rank[4] = -6;
				}
				else if (value > 6)
				{
					Rank[4] = 6;
				}
				else
				{
					Rank[4] = value;
				}
			}
		}

		public bool IsAttack;
		public Util.Type Type1;
		public Util.Type Type2;
		private int hpRemain;
		public int HPRemain
		{
			get
			{
				return hpRemain;
			}

			set
			{
				if(value > StatusH)
				{
					hpRemain = StatusH;
				}
				else if(value < 0)
				{
					hpRemain = 0;
				}
				else
				{
					hpRemain = value;
				}
			}
		}
		public Util.Affection Affection;
		public Bitmap bmp;
		public Util.Nature Nature; // デフォルトではさみしがり
		public int Level;
		public string SelectedChara;
		public bool IsMyParty;

		#endregion

		#endregion

		#region コンストラクター

		public Poke(string name)
		{
			var cBuilder = new SQLiteConnectionStringBuilder { DataSource = "poketool.db" };

			using (var cn = new SQLiteConnection(cBuilder.ToString()))
			{
				cn.Open();
				using (var cmd = new SQLiteCommand(cn))
				{
					cmd.CommandText = String.Format("select * from charPokeInfo where name = '{0}'", name);
					var reader = cmd.ExecuteReader();
					reader.Read();

					for (int i = 0; i < ConstStringParams.Length; i++)
					{
						try
						{
							ConstStringParams[i] = reader[ParamsString[i]].ToString();
						}
						catch (InvalidOperationException)
						{
							throw new Exception("データベースから情報を読み取れませんでした :" + Name);
						}
					}
					SyuzokuH = int.Parse(reader["hp"].ToString());
					SyuzokuA = int.Parse(reader["a"].ToString());
					SyuzokuB = int.Parse(reader["b"].ToString());
					SyuzokuC = int.Parse(reader["c"].ToString());
					SyuzokuD = int.Parse(reader["d"].ToString());
					SyuzokuS = int.Parse(reader["s"].ToString());
					Sum = int.Parse(reader["sum"].ToString());
				}
			}

			// タイプを変換
			Type1 = (Util.Type)Util.DictType[type1];
			if (type2 != "")
			{
				Type2 = (Util.Type)Util.DictType[type2];
			}

			ResourceManager RM = Properties.Resources.ResourceManager;
			bmp = (Bitmap)RM.GetObject("_" + ID);

			// とりあえずとくせいは1にする
			SelectedChara = Chara1;
		}

		#endregion
	}
}
