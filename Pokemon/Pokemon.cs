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

		public int H { get { return Status[0]; } set { Status[0] = value; } }
		public int A { get { return Status[1]; } set { Status[1] = value; } }
		public int B { get { return Status[2]; } set { Status[2] = value; } }
		public int C { get { return Status[3]; } set { Status[3] = value; } }
		public int D { get { return Status[4]; } set { Status[4] = value; } }
		public int S { get { return Status[5]; } set { Status[5] = value; } }
		public int sum;

		public int[] Status = new int[6];

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
					H = int.Parse(reader["hp"].ToString());
					A = int.Parse(reader["a"].ToString());
					B = int.Parse(reader["b"].ToString());
					C = int.Parse(reader["c"].ToString());
					D = int.Parse(reader["d"].ToString());
					S = int.Parse(reader["s"].ToString());
					sum = int.Parse(reader["sum"].ToString());
				}
			}
		}

		#endregion
	}
}
