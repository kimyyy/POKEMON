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
	public static class Util
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
			ひざしがつよい,あめ,あられ,すなあらし,きり
		}

		public enum Affection
		{
			なし,まひ,やけど,こおり,こんらん,ねむり,どく,どくどく
		}

		public enum Nature
		{
			さみしがり,いじっぱり,やんちゃ,ゆうかん,ずぶとい,わんぱく,のうてんき,のんき,
			ひかえめ,おっとり,うっかりや,れいせい,おだやか,おとなしい,しんちょう,なまいき,
			おくびょう,せっかち,ようき,むじゃき,てれや,すなお,まじめ,きまぐれ,がんばりや
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

		public static double[] DecidePersonality(Nature nature)
		{
			var arrayPerson = new double[] { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 };
			switch (nature)
			{
				case Nature.さみしがり:
					arrayPerson[1] = 1.1;
					arrayPerson[2] = 0.9;
					break;
				case Nature.いじっぱり:
					arrayPerson[1] = 1.1;
					arrayPerson[3] = 0.9;
					break;
				case Nature.やんちゃ:
					arrayPerson[1] = 1.1;
					arrayPerson[4] = 0.9;
					break;
				case Nature.ゆうかん:
					arrayPerson[1] = 1.1;
					arrayPerson[5] = 0.9;
					break;
				case Nature.ずぶとい:
					arrayPerson[1] = 0.9;
					arrayPerson[2] = 1.1;
					break;
				case Nature.わんぱく:
					arrayPerson[2] = 1.1;
					arrayPerson[3] = 0.9;
					break;
				case Nature.のうてんき:
					arrayPerson[2] = 1.1;
					arrayPerson[4] = 0.9;
					break;
				case Nature.のんき:
					arrayPerson[2] = 1.1;
					arrayPerson[5] = 0.9;
					break;
				case Nature.ひかえめ:
					arrayPerson[1] = 0.9;
					arrayPerson[3] = 1.1;
					break;
				case Nature.おっとり:
					arrayPerson[2] = 0.9;
					arrayPerson[3] = 1.1;
					break;
				case Nature.うっかりや:
					arrayPerson[3] = 1.1;
					arrayPerson[4] = 0.9;
					break;
				case Nature.れいせい:
					arrayPerson[3] = 1.1;
					arrayPerson[5] = 0.9;
					break;
				case Nature.おだやか:
					arrayPerson[1] = 0.9;
					arrayPerson[4] = 1.1;
					break;
				case Nature.おとなしい:
					arrayPerson[2] = 0.9;
					arrayPerson[4] = 1.1;
					break;
				case Nature.しんちょう:
					arrayPerson[3] = 0.9;
					arrayPerson[4] = 1.1;
					break;
				case Nature.なまいき:
					arrayPerson[4] = 1.1;
					arrayPerson[5] = 0.9;
					break;
				case Nature.おくびょう:
					arrayPerson[1] = 0.9;
					arrayPerson[5] = 1.1;
					break;
				case Nature.せっかち:
					arrayPerson[2] = 0.9;
					arrayPerson[5] = 1.1;
					break;
				case Nature.ようき:
					arrayPerson[3] = 0.9;
					arrayPerson[5] = 1.1;
					break;
				case Nature.むじゃき:
					arrayPerson[4] = 0.9;
					arrayPerson[5] = 1.1;
					break;
			}
			return arrayPerson;
		}

		public static void ShowMessage(string message)
		{
			using (var form = new NoticeForm(message))
			{
				form.ShowDialog();
			}
		}

		/// <summary>
		/// ポケモンのステータスを計算します。
		/// </summary>
		/// <param name="Level"></param>
		public static int[] CalculateStatus(int[] Syuzoku, int[] Indi, int[] Effort, int Level, Nature Nature)
		{
			var Status = new int[6];
			var personality = DecidePersonality(Nature);
			for (int i = 0; i < 6; i++)
			{
				double status = (Syuzoku[i] * 2.0 + Indi[i] + Effort[i] / 4.0) * Level / 100.0;
				if (i == 0)
				{
					Status[i] = (int)status + Level + 10;
				}
				else
				{
					Status[i] = (int)((status + 5) * personality[i]);
				}
			}
			return Status;
		}

		/// <summary>
		/// 純粋ダメージ量を計算します。
		/// </summary>
		/// <returns></returns>
		public static int[] CalculateDamage(Poke AttackPoke, Poke DefencePoke, Move Skill, int Level)
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
		public static double CalculateTypeMatching(Poke attackPokemon, Poke defensePokemon, Move skill)
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

		public static void ApplyItem(string Item, Move Skill, Poke poke, double typeMatch)
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

		public static void ApplyChara(string Chara, Move Skill, Poke Poke, double typeMatching)
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
					if (typeMatching < 1.0)
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
						if (Skill.Type == Type.ノーマル)
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

				case "かいりきバサミ":
					// TODO
					break;

				case "かがくのちから":
					// TODO
					break;

				case "かげふみ":
					// TODO
					break;

				case "かそく":
					// TODO
					break;

				case "かたいツメ":
					// TODO
					break;

				case "かたやぶり":
					// TODO
					break;

				case "かちき":
					// TODO
					break;

				case "カブトアーマー":
					// TODO
					break;

				case "かるわざ":
					// TODO
					break;

				case "かわりもの":
					// TODO
					break;

				case "かんそうはだ":
					// TODO
					break;

				case "がんじょう":
					// TODO
					break;

				case "がんじょうあご":
					if (!Poke.IsAttack)
					{
						break;
					}
					switch (Skill.Name)
					{
						case "かみつく":
						case "かみくだく":
						case "ひっさつまえば":
						case "ほのおのキバ":
						case "かみなりのキバ":
						case "こおりのキバ":
						case "どくどくのキバ":
						case "サイコファング":
							Skill.multipleDamage(1.5);
							break;
					}
					break;

				case "ききかいひ":
					// TODO
					break;

				case "きけんよち":
					break;

				case "きずなへんげ":
					// TODO
					break;

				case "きもったま":
					// TODO
					break;

				case "きゅうばん":
					// TODO
					break;

				case "きょううん":
					// TODO
					break;

				case "きょうせい":
					// TODO
					break;

				case "きんちょうかん":
					// TODO
					break;
			}
		}
	}
}
