using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
	/// <summary>
	/// ダメージ計算を扱うクラスです。
	/// </summary>
	static class Util
	{
		private static string[] arrayType = new string[]
		{"ノーマル", "ほのお", "みず" , "でんき", "くさ","こおり", "かくとう", "どく", "じめん",
			"ひこう", "エスパー", "むし", "いわ", "ゴースト", "ドラゴン", "あく", "はがね", "フェアリー"};

		private static Dictionary<string, int> DictType = new Dictionary<string, int>()
		{
			{"ノーマル", 0 },
			{"ほのお",   1 },
			{ "みず",    2 },
			{"でんき",   3 },
			{"くさ",     4 },
			{"こおり",   5 },
			{"かくとう", 6 },
			{"どく",     7 },
			{"じめん",   8 },
			{"ひこう",   9 },
			{"エスパー", 10 },
			{"むし",     11 },
			{"いわ",     12 },
			{"ゴースト", 13 },
			{"ドラゴン", 14 },
			{"あく",     15 },
			{"はがね",   16 },
			{"フェアリー",17 }
		};

		private static double[,] tableTypeMatch = new double[18, 18]
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

		/// <summary>
		/// 純粋ダメージ量を計算します。
		/// </summary>
		/// <returns></returns>
		public static int[] CalculateDamage(Poke AttackPoke, Poke DefencePoke, Waza Skill, int Level)
		{
			int Damage = Level * 2 / 5 + 2;
			if (Skill.IsPhysical)
			{
				Damage = Damage * Skill.Damage * AttackPoke.A / DefencePoke.B;
			}
			else
			{
				Damage = Damage * Skill.Damage * AttackPoke.C / DefencePoke.C;
			}

			Damage = Damage / 50 + 2;
			int DamegeLower = (int)(Damage * 0.85);
			int DamageUpper = Damage;
			DamegeLower = (int)(DamegeLower * CalculateTypeMatching(AttackPoke, DefencePoke, Skill));
			DamageUpper = (int)(DamageUpper * CalculateTypeMatching(AttackPoke, DefencePoke, Skill));
			var DamageRange = new int[] { DamegeLower, DamageUpper };
			return DamageRange;
		}

		/// <summary>
		/// タイプ相性を計算します。
		/// </summary>
		/// <param name="defensePokemon"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static double CalculateTypeMatching(Poke attackPokemon, Poke defensePokemon, Waza skill)
		{
			int skilltype = DictType[skill.Type];
			int type1 = DictType[defensePokemon.Type1];
			double sametype = 1;
			if (attackPokemon.Type1 == skill.Type || attackPokemon.Type2 == skill.Type) sametype = 1.5;
			if (defensePokemon.Type2 == string.Empty)
			{
				return tableTypeMatch[skilltype, type1] * sametype;
			}
			int type2 = DictType[defensePokemon.Type2];
			return tableTypeMatch[skilltype, type1] * tableTypeMatch[skilltype, type2] * sametype;
		}
	}
}
