using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
	class Waza
	{
		public string Name;

		public string type;

		public string category;

		public int damage;

		public Waza(string name)
		{
			var cBuilder = new SQLiteConnectionStringBuilder { DataSource = "poketool.db" };
			using(var cn = new SQLiteConnection(cBuilder.ToString()))
			{
				cn.Open();
				using (var cmd = new SQLiteCommand(cn))
				{
					cmd.CommandText = string.Format("select * from waza where name = '{0}'", name);
					var reader = cmd.ExecuteReader();
					reader.Read();
					type = reader["type"].ToString();
					category = reader["category"].ToString();
					damage = int.Parse(reader["damage"].ToString());
				}
			}
		}
	}
}
