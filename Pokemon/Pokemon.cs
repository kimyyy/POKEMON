using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
	class Poke
	{
		#region フィールド

		#region 各ステータス

		private string[] ParamsString = {"name", "type1", "type2", "chara1", "chara2", "dchara" };

		private string[] ConstStringParams = new string[6];

		public string Name   { get { return ConstStringParams[0]; } set { ConstStringParams[0] = value; } }
		public string Type1  { get { return ConstStringParams[1]; } set { ConstStringParams[1] = value; } }
		public string Type2  { get { return ConstStringParams[2]; } set { ConstStringParams[2] = value; } }
		public string Chara1 { get { return ConstStringParams[3]; } set { ConstStringParams[3] = value; } }
		public string Chara2 { get { return ConstStringParams[4]; } set { ConstStringParams[4] = value; } }
		public string DChara { get { return ConstStringParams[5]; } set { ConstStringParams[5] = value; } }

		public int SyuzokuH { get { return Syuzoku[0]; } set { Syuzoku[0] = value; } }
		public int SyuzokuA { get { return Syuzoku[1]; } set { Syuzoku[1] = value; } }
		public int SyuzokuB { get { return Syuzoku[2]; } set { Syuzoku[2] = value; } }
		public int SyuzokuC { get { return Syuzoku[3]; } set { Syuzoku[3] = value; } }
		public int SyuzokuD { get { return Syuzoku[4]; } set { Syuzoku[4] = value; } }
		public int SyuzokuS { get { return Syuzoku[5]; } set { Syuzoku[5] = value; } }
		public int sum;

		public int[] Syuzoku = new int[6];

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
					cmd.CommandText = string.Format("select * from pokeinfo where name = '{0}'",name);
					var reader = cmd.ExecuteReader();
					reader.Read();

					for (int i = 0; i < 6; i++)
					{
						try
						{
							ConstStringParams[i] = reader[ParamsString[i]].ToString();
						}
						catch (InvalidOperationException)
						{
							throw new Exception("データベースから情報を読み取れませんでした");
						}
					}
					SyuzokuH = int.Parse(reader["hp"].ToString());
					SyuzokuA = int.Parse(reader["a"].ToString());
					SyuzokuB = int.Parse(reader["b"].ToString());
					SyuzokuC = int.Parse(reader["c"].ToString());
					SyuzokuD = int.Parse(reader["d"].ToString());
					SyuzokuS = int.Parse(reader["s"].ToString());
					sum = int.Parse(reader["sum"].ToString());
				}
			}
		}

		#endregion
	}
}
