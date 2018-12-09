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

		/// <summary>
		/// 名前です。
		/// </summary>
		public string Name;

		/// <summary>
		/// タイプ(1つ目)です。
		/// </summary>
		public string Type1;

		/// <summary>
		/// タイプ(2つ目)です。
		/// </summary>
		public string Type2;

		/// <summary>
		/// 特性(1つ目)です。
		/// </summary>
		public string Chara1;

		/// <summary>
		/// 特性(2つ目)です。
		/// </summary>
		public string Chara2;

		/// <summary>
		/// 夢特性です。
		/// </summary>
		public string DChara;

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

					Name = reader["name"].ToString();
					Type1 = reader["type1"].ToString();
					Type2 = reader["type2"].ToString();
					Chara1 = reader["chara1"].ToString();
					Chara2 = reader["chara2"].ToString();
					DChara = reader["dchara"].ToString();
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
