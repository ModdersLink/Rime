///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class PlayerScore : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int Rank { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint Kills { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint Deaths { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ScoreMultiplier { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int Score { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int GlobalScoreOriginal { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int GlobalScoreUpdated { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Time { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint GunMasterLevel { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089381491:
					Rank = (int) p_Value;
					break;

				case 221663060:
					Kills = (uint) p_Value;
					break;

				case 2594217034:
					Deaths = (uint) p_Value;
					break;

				case 81894022:
					ScoreMultiplier = (uint) p_Value;
					break;

				case 231225165:
					Score = (int) p_Value;
					break;

				case 3481353183:
					GlobalScoreOriginal = (int) p_Value;
					break;

				case 816609331:
					GlobalScoreUpdated = (int) p_Value;
					break;

				case 2089313744:
					Time = (float) p_Value;
					break;

				case 1411188979:
					GunMasterLevel = (uint) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089381491:
					return Rank;

				case 221663060:
					return Kills;

				case 2594217034:
					return Deaths;

				case 81894022:
					return ScoreMultiplier;

				case 231225165:
					return Score;

				case 3481353183:
					return GlobalScoreOriginal;

				case 816609331:
					return GlobalScoreUpdated;

				case 2089313744:
					return Time;

				case 1411188979:
					return GunMasterLevel;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089381491:
					return typeof(PlayerScore).GetProperty(nameof(Rank));

				case 221663060:
					return typeof(PlayerScore).GetProperty(nameof(Kills));

				case 2594217034:
					return typeof(PlayerScore).GetProperty(nameof(Deaths));

				case 81894022:
					return typeof(PlayerScore).GetProperty(nameof(ScoreMultiplier));

				case 231225165:
					return typeof(PlayerScore).GetProperty(nameof(Score));

				case 3481353183:
					return typeof(PlayerScore).GetProperty(nameof(GlobalScoreOriginal));

				case 816609331:
					return typeof(PlayerScore).GetProperty(nameof(GlobalScoreUpdated));

				case 2089313744:
					return typeof(PlayerScore).GetProperty(nameof(Time));

				case 1411188979:
					return typeof(PlayerScore).GetProperty(nameof(GunMasterLevel));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
