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
		public static int[] CalculateDamage(Poke AttackPoke, Poke DefencePoke, Waza Skill)
		{
			int temp = AttackPoke.Level * 2 / 5 + 2;
			if (Skill.category == "物理")
			{
				temp = temp * Skill.damage * AttackPoke.a / DefencePoke.b;
			}
			else
			{
				temp = temp * Skill.damage * AttackPoke.c / DefencePoke.c;
			}

			temp = temp / 50 + 2;
			int templow = (int)(temp * 0.85);
			int temphigh = temp;
			templow = (int)(templow * CalculateTypeMatching(AttackPoke, DefencePoke, Skill));
			temphigh = (int)(temphigh * CalculateTypeMatching(AttackPoke, DefencePoke, Skill));
			var ret = new int[] { templow, temphigh };
			return ret;
		}

		/// <summary>
		/// タイプ相性を計算します。
		/// </summary>
		/// <param name="defensePokemon"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static double CalculateTypeMatching(Poke attackPokemon, Poke defensePokemon, Waza skill)
		{
			int skilltype = Array.IndexOf(arrayType, skill.type);
			int type1 = Array.IndexOf(arrayType, defensePokemon.Type1);
			double sametype = 1;
			if (attackPokemon.Type1 == skill.type || attackPokemon.Type2 == skill.type) sametype = 1.5;
			if (defensePokemon.Type2 == string.Empty)
			{
				return tableTypeMatch[skilltype, type1] * sametype;
			}
			int type2 = Array.IndexOf(arrayType, defensePokemon.Type2);
			return tableTypeMatch[skilltype, type1] * tableTypeMatch[skilltype, type2] * sametype;
		}
	}
}
