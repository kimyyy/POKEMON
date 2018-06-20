using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
	class Pokemon
	{
		public string name;
		public string type1;
		public string type2;
		public string chara1;
		public string chara2;
		public string dchara;
		public int hp;
		public int a;
		public int b;
		public int c;
		public int d;
		public int s;
		public int sum;
		public int level;

		public Pokemon(string name)
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

					name = reader["name"].ToString();
					type1 = reader["type1"].ToString();
					type2 = reader["type2"].ToString();
					chara1 = reader["chara1"].ToString();
					chara2 = reader["chara2"].ToString();
					dchara = reader["dchara"].ToString();
					hp = int.Parse(reader["hp"].ToString());
					a = int.Parse(reader["a"].ToString());
					b = int.Parse(reader["b"].ToString());
					c = int.Parse(reader["c"].ToString());
					d = int.Parse(reader["d"].ToString());
					s = int.Parse(reader["s"].ToString());
					sum = int.Parse(reader["sum"].ToString());
				}
			}
		}
	}
}
