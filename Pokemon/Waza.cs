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

		public string Type;

		private string category;

		public bool IsPhysical;

		public int Damage;

		public Waza(string name)
		{
			Name = name;
			var cBuilder = new SQLiteConnectionStringBuilder { DataSource = "poketool.db" };
			using(var cn = new SQLiteConnection(cBuilder.ToString()))
			{
				cn.Open();
				using (var cmd = new SQLiteCommand(cn))
				{
					cmd.CommandText = string.Format("select * from waza where name = '{0}'", name);
					var reader = cmd.ExecuteReader();
					reader.Read();
					Type = reader["type"].ToString();
					category = reader["category"].ToString();
					Damage = int.Parse(reader["damage"].ToString());
				}
			}

			// 物理か特殊か判定
			if(category == "物理")
			{
				IsPhysical = true;
			}
			else if (category == "特殊")
			{
				IsPhysical = false;
			}
			else
			{
				throw new Exception("存在しない技カテゴリです。");
			}
		}
	}
}
