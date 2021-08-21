///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 36)]
	public class PlayerScore : FrostbiteContainer
	{
		[ContainerField(Name: "Rank", Offset: 0, NameHash: 2089381491, Flags: 49405), LayoutImmutable, Blittable]
		public int Rank { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Kills", Offset: 4, NameHash: 221663060, Flags: 49421), LayoutImmutable, Blittable]
		public uint Kills { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Deaths", Offset: 8, NameHash: 2594217034, Flags: 49421), LayoutImmutable, Blittable]
		public uint Deaths { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "ScoreMultiplier", Offset: 12, NameHash: 81894022, Flags: 49421), LayoutImmutable, Blittable]
		public uint ScoreMultiplier { get; set; } // 0xC (12)
		
		[ContainerField(Name: "Score", Offset: 16, NameHash: 231225165, Flags: 49405), LayoutImmutable, Blittable]
		public int Score { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "GlobalScoreOriginal", Offset: 20, NameHash: 3481353183, Flags: 49405), LayoutImmutable, Blittable]
		public int GlobalScoreOriginal { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "GlobalScoreUpdated", Offset: 24, NameHash: 816609331, Flags: 49405), LayoutImmutable, Blittable]
		public int GlobalScoreUpdated { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "Time", Offset: 28, NameHash: 2089313744, Flags: 49469), LayoutImmutable, Blittable]
		public float Time { get; set; } // 0x1C (28)
		
		[ContainerField(Name: "GunMasterLevel", Offset: 32, NameHash: 1411188979, Flags: 49421), LayoutImmutable, Blittable]
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
