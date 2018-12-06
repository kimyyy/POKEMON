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

		/// <summary>
		/// 体力です。
		/// </summary>
		public int HP;

		public int a;
		public int b;
		public int c;
		public int d;
		public int s;
		public int sum;

		/// <summary>
		/// レベルです。
		/// </summary>
		public int Level;

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
					HP = int.Parse(reader["hp"].ToString());
					a = int.Parse(reader["a"].ToString());
					b = int.Parse(reader["b"].ToString());
					c = int.Parse(reader["c"].ToString());
					d = int.Parse(reader["d"].ToString());
					s = int.Parse(reader["s"].ToString());
					sum = int.Parse(reader["sum"].ToString());
				}
			}
		}

		#endregion
	}
}
