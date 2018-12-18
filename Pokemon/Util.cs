﻿using System;
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


		private static string[] TypeString = new string[]
		{"ノーマル", "ほのお", "みず" , "でんき", "くさ","こおり", "かくとう", "どく", "じめん",
			"ひこう", "エスパー", "むし", "いわ", "ゴースト", "ドラゴン", "あく", "はがね", "フェアリー"};

		public enum Type
		{
			ノーマル, ほのお, みず, でんき, くさ, こおり, かくとう, どく, じめん,
			ひこう, エスパー, むし, いわ, ゴースト, ドラゴン, あく, はがね, フェアリー, none
		};

		public enum Weather
		{

		}

		public static Dictionary<string, int> DictType = new Dictionary<string, int>()
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
			{"フェアリー",17 },
			{"",     18 }
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

		public static double[] DecidePersonality(string personality)
		{
			var arrayPerson = new double[] { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 };
			switch (personality)
			{
				case "さみしがり":
					arrayPerson[1] = 1.1;
					arrayPerson[2] = 0.9;
					break;
				case "いじっぱり":
					arrayPerson[1] = 1.1;
					arrayPerson[3] = 0.9;
					break;
				case "やんちゃ":
					arrayPerson[1] = 1.1;
					arrayPerson[4] = 0.9;
					break;
				case "ゆうかん":
					arrayPerson[1] = 1.1;
					arrayPerson[5] = 0.9;
					break;
				case "ずぶとい":
					arrayPerson[1] = 0.9;
					arrayPerson[2] = 1.1;
					break;
				case "わんぱく":
					arrayPerson[2] = 1.1;
					arrayPerson[3] = 0.9;
					break;
				case "のうてんき":
					arrayPerson[2] = 1.1;
					arrayPerson[4] = 0.9;
					break;
				case "のんき":
					arrayPerson[2] = 1.1;
					arrayPerson[5] = 0.9;
					break;
				case "ひかえめ":
					arrayPerson[1] = 0.9;
					arrayPerson[3] = 1.1;
					break;
				case "おっとり":
					arrayPerson[2] = 0.9;
					arrayPerson[3] = 1.1;
					break;
				case "うっかりや":
					arrayPerson[3] = 1.1;
					arrayPerson[4] = 0.9;
					break;
				case "れいせい":
					arrayPerson[3] = 1.1;
					arrayPerson[5] = 0.9;
					break;
				case "おだやか":
					arrayPerson[1] = 0.9;
					arrayPerson[4] = 1.1;
					break;
				case "おとなしい":
					arrayPerson[2] = 0.9;
					arrayPerson[4] = 1.1;
					break;
				case "しんちょう":
					arrayPerson[3] = 0.9;
					arrayPerson[4] = 1.1;
					break;
				case "なまいき":
					arrayPerson[4] = 1.1;
					arrayPerson[5] = 0.9;
					break;
				case "おくびょう":
					arrayPerson[1] = 0.9;
					arrayPerson[5] = 1.1;
					break;
				case "せっかち":
					arrayPerson[2] = 0.9;
					arrayPerson[5] = 1.1;
					break;
				case "ようき":
					arrayPerson[3] = 0.9;
					arrayPerson[5] = 1.1;
					break;
				case "むじゃき":
					arrayPerson[4] = 0.9;
					arrayPerson[5] = 1.1;
					break;
			}
			return arrayPerson;
		}

		/// <summary>
		/// 純粋ダメージ量を計算します。
		/// </summary>
		/// <returns></returns>
		public static int[] CalculateDamage(Poke AttackPoke, Poke DefencePoke, Waza Skill, int Level)
		{
			int Damage = Level * 2 / 5 + 2;
			if (Skill.IsPhysical)
			{
				Damage = Damage * Skill.Damage * AttackPoke.SyuzokuA / DefencePoke.SyuzokuB;
			}
			else
			{
				Damage = Damage * Skill.Damage * AttackPoke.SyuzokuC / DefencePoke.SyuzokuC;
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
			int skilltype = (int)skill.Type;
			int type1 = (int)defensePokemon.Type1;
			double sametype = 1;
			if (attackPokemon.Type1 == skill.Type || attackPokemon.Type2 == skill.Type) sametype = 1.5;
			if (defensePokemon.Type2 == Type.none)
			{
				return tableTypeMatch[skilltype, type1] * sametype;
			}
			int type2 = (int)defensePokemon.Type2;
			return tableTypeMatch[skilltype, type1] * tableTypeMatch[skilltype, type2] * sametype;
		}

		public static void ApplyItem(string Item, Waza Skill, Poke poke, double typeMatch)
		{
			switch (Item)
			{
				case "いのちのたま":
					Skill.multipleDamage(1.3);
					break;

				case "こだわりハチマキ":
					if (Skill.IsPhysical)
					{
						Skill.multipleDamage(1.5);
					}
					break;

				case "こだわりメガネ":
					if (!Skill.IsPhysical)
					{
						Skill.multipleDamage(1.5);
					}
					break;

				case "こだわりスカーフ":
					poke.StatusS = (int)(poke.StatusS);
					break;

				case "ちからのハチマキ":
					if (Skill.IsPhysical)
					{
						Skill.multipleDamage(1.1);
					}
					break;

				case "たつじんのおび":
					if (typeMatch == 2.0)
					{
						Skill.multipleDamage(1.2);
					}
					break;

				case "とつげきチョッキ":
					poke.StatusD = (int)(poke.StatusD * 1.5);
					break;

			}
		}

		public static void ApplyChara(string Chara, Waza Skill, Poke Poke, double typeMatching)
		{
			switch (Chara)
			{
				case "アイスボディ":
					// TODO あられの時にダメージを受けず、毎ターン終了時に最大HPの1/16回復
					break;

				case "あくしゅう":
					// TODO ダメージを与えると10%の確立でひるませる
					break;

				case "あついしぼう":
					if (!Poke.IsAttack && (Skill.Type == Type.ほのお || Skill.Type == Type.こおり))
					{
						Skill.multipleDamage(0.5);
					}
					break;

				case "あとだし":
					// かならず後攻
					break;

				case "アナライズ":
					// 技の順番が一番最後なら1.3倍
					break;

				case "あまのじゃく":
					// 能力ランクの変化の効果が逆
					break;

				case "あめうけざら":
					// TODO
					break;

				case "あめふらし":
					//TODO
					break;

				case "ありじごく":
					//TODO
					break;

				case "アロマベール":
					//TODO
					break;

				case "いかく":
					//TODO
					break;

				case "いかりのつぼ":
					//TODO
					break;

				case "いしあたま":
					//TODO
					break;

				case "いたずらごころ":
					//TODO
					break;

				case "いやしのこころ":
					//TODO
					break;

				case "イリュージョン":
					//TODO
					break;

				case "いろめがね":
					if(typeMatching < 1.0)
					{
						typeMatching = typeMatching * 2.0;
					}
					break;

				case "うるおいボイス":
					if (Poke.IsAttack)
					{
						switch (Skill.Name)
						{
							case "いびき":
							case "いやしのすず":
							case "いやなおと":
							case "うたう":
							case "うたかたのアリア":
							case "エコーボイス":
							case "おしゃべり":
							case "おたけび":
							case "きんぞくおん":
							case "くさぶえ":
							case "さわぐ":
							case "スケイルノイズ":
							case "すてゼリフ":
							case "チャームボイス":
							case "ちょうおんぱ":
							case "ないしょばなし":
							case "なきごえ":
							case "バークアウト":
							case "ハイパーボイス":
							case "ばくおんぱ":
							case "ほえる":
							case "ほろびのうた":
							case "むしのさざめき":
							case "りんしょう":
								Skill.Type = Type.みず;
								break;
						}
					}
					break;

				case "うるおいボディ":
					// TODO
					break;

				case "エアロック":
					//TODO
					break;

				case "エレスキン":
					if (Poke.IsAttack)
					{
						if(Skill.Type == Type.ノーマル)
						{
							Skill.Type = Type.でんき;
							Skill.multipleDamage(1.3);
						}
					}
					break;

				case "エレキメイカー":
					// TODO
					break;

				case "えんかく":
					if (Poke.IsAttack)
					{
						Skill.IsPhysical = false;
					}
					break;

				case "オーラブレイク":
					// TODO
					break;

				case "おどりこ":
					// TODO
					break;

				case "おみとおし":
					break;

				case "おやこあい":
					//TODO
					break;

				case "おわりのだいち":
					// TODO
					break;

				case "カーリーヘアー":
					// TODO
					break;

			}
		}
	}
}
