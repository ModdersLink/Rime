///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class LifeCounterEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int StartingLifeCount { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float DisplayTime { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public TeamId TeamId { get; set; } = new TeamId(); // 0x68 (104)
		
		[ContainerField(108)]
		public List<int> LifeTresholdValues { get; set; } = new List<int>(); // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public int UiShowCountLowerThreshold { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public int UiShowCountUpperThreshold { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public int BaseCount { get; set; } // 0x78 (120)
		
		[ContainerField(124)]
		public List<float> ReinforceTable { get; set; } = new List<float>(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public int ReinforceThreshold { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable]
		public string ReinforceMessageSid { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float FightHarderTreshold { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float DefensiveKillRadius { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float FallbackTime { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable]
		public string FightHarderMessageSid { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool Attacker { get; set; } // 0x98 (152)
		
		[ContainerField(153), LayoutImmutable, Blittable]
		public bool SetBestSquadSpawner { get; set; } // 0x99 (153)
		
		[ContainerField(154), LayoutImmutable, Blittable]
		public bool SimpleReinforce { get; set; } // 0x9A (154)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3417547968:
					StartingLifeCount = (int) p_Value;
					break;

				case 1925139498:
					DisplayTime = (float) p_Value;
					break;

				case 3220374101:
					TeamId = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 3392040548:
					LifeTresholdValues = (List<int>) p_Value;
					break;

				case 2785336653:
					UiShowCountLowerThreshold = (int) p_Value;
					break;

				case 3322873612:
					UiShowCountUpperThreshold = (int) p_Value;
					break;

				case 1694831539:
					BaseCount = (int) p_Value;
					break;

				case 2268254326:
					ReinforceTable = (List<float>) p_Value;
					break;

				case 3361010943:
					ReinforceThreshold = (int) p_Value;
					break;

				case 331217021:
					ReinforceMessageSid = (string) p_Value;
					break;

				case 2263650182:
					FightHarderTreshold = (float) p_Value;
					break;

				case 2115687194:
					DefensiveKillRadius = (float) p_Value;
					break;

				case 1213191836:
					FallbackTime = (float) p_Value;
					break;

				case 4210634540:
					FightHarderMessageSid = (string) p_Value;
					break;

				case 454612250:
					Attacker = (bool) p_Value;
					break;

				case 1050080153:
					SetBestSquadSpawner = (bool) p_Value;
					break;

				case 4042376934:
					SimpleReinforce = (bool) p_Value;
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
				case 3417547968:
					return StartingLifeCount;

				case 1925139498:
					return DisplayTime;

				case 3220374101:
					return TeamId;

				case 3392040548:
					return LifeTresholdValues;

				case 2785336653:
					return UiShowCountLowerThreshold;

				case 3322873612:
					return UiShowCountUpperThreshold;

				case 1694831539:
					return BaseCount;

				case 2268254326:
					return ReinforceTable;

				case 3361010943:
					return ReinforceThreshold;

				case 331217021:
					return ReinforceMessageSid;

				case 2263650182:
					return FightHarderTreshold;

				case 2115687194:
					return DefensiveKillRadius;

				case 1213191836:
					return FallbackTime;

				case 4210634540:
					return FightHarderMessageSid;

				case 454612250:
					return Attacker;

				case 1050080153:
					return SetBestSquadSpawner;

				case 4042376934:
					return SimpleReinforce;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3417547968:
					return typeof(LifeCounterEntityData).GetProperty(nameof(StartingLifeCount));

				case 1925139498:
					return typeof(LifeCounterEntityData).GetProperty(nameof(DisplayTime));

				case 3220374101:
					return typeof(LifeCounterEntityData).GetProperty(nameof(TeamId));

				case 3392040548:
					return typeof(LifeCounterEntityData).GetProperty(nameof(LifeTresholdValues));

				case 2785336653:
					return typeof(LifeCounterEntityData).GetProperty(nameof(UiShowCountLowerThreshold));

				case 3322873612:
					return typeof(LifeCounterEntityData).GetProperty(nameof(UiShowCountUpperThreshold));

				case 1694831539:
					return typeof(LifeCounterEntityData).GetProperty(nameof(BaseCount));

				case 2268254326:
					return typeof(LifeCounterEntityData).GetProperty(nameof(ReinforceTable));

				case 3361010943:
					return typeof(LifeCounterEntityData).GetProperty(nameof(ReinforceThreshold));

				case 331217021:
					return typeof(LifeCounterEntityData).GetProperty(nameof(ReinforceMessageSid));

				case 2263650182:
					return typeof(LifeCounterEntityData).GetProperty(nameof(FightHarderTreshold));

				case 2115687194:
					return typeof(LifeCounterEntityData).GetProperty(nameof(DefensiveKillRadius));

				case 1213191836:
					return typeof(LifeCounterEntityData).GetProperty(nameof(FallbackTime));

				case 4210634540:
					return typeof(LifeCounterEntityData).GetProperty(nameof(FightHarderMessageSid));

				case 454612250:
					return typeof(LifeCounterEntityData).GetProperty(nameof(Attacker));

				case 1050080153:
					return typeof(LifeCounterEntityData).GetProperty(nameof(SetBestSquadSpawner));

				case 4042376934:
					return typeof(LifeCounterEntityData).GetProperty(nameof(SimpleReinforce));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
