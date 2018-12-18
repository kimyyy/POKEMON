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
		private string type	{ get { return ConstParams[0]; } set { ConstParams[0] = value; } }
		private string category { get { return ConstParams[1]; } set { ConstParams[1] = value; } }
		public int Damage;
		public bool IsPhysical;
		
		private string[] ParamsString = { "type", "category", "damage" };
		private string[] ConstParams = new string[2];

		public Util.Type Type;

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
					for(int i = 0;i < 2; i++)
					{
						try
						{
							ConstParams[i] = reader[ParamsString[i]].ToString();
						}
						catch (InvalidOperationException)
						{
							throw new Exception("データベースからデータを読み込めませんでした。");
						}
					}
					try
					{
						Damage = int.Parse(reader[ParamsString[2]].ToString());
					}
					catch (InvalidOperationException)
					{
						throw new Exception("データベースからデータを読み込めませんでした。");
					}
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
				throw new Exception("存在しない技カテゴリがありました。");
			}

			// タイプを格納
			Type = (Util.Type)Util.DictType[type];

		}

		public void multipleDamage(double multi)
		{
			Damage = (int)(Damage * multi);
		}
	}
}
