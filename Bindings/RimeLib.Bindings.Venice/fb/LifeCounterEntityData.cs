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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 160)]
	public class LifeCounterEntityData : 
		GameEntityData
	{
		protected int m_StartingLifeCount = new int();
		[ContainerField(Name: "StartingLifeCount", Offset: 96, NameHash: 3417547968, Flags: 49405), LayoutImmutable, Blittable]
		public int StartingLifeCount { get { return m_StartingLifeCount; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(StartingLifeCount), this, m_StartingLifeCount, value)) m_StartingLifeCount = value; } } // 0x60 (96)
		
		protected float m_DisplayTime = new float();
		[ContainerField(Name: "DisplayTime", Offset: 100, NameHash: 1925139498, Flags: 49469), LayoutImmutable, Blittable]
		public float DisplayTime { get { return m_DisplayTime; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(DisplayTime), this, m_DisplayTime, value)) m_DisplayTime = value; } } // 0x64 (100)
		
		protected TeamId m_TeamId = new TeamId();
		[ContainerField(Name: "TeamId", Offset: 104, NameHash: 3220374101, Flags: 137)]
		public TeamId TeamId { get { return m_TeamId; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(TeamId), this, m_TeamId, value)) m_TeamId = value; } } // 0x68 (104)
		
		protected List<int> m_LifeTresholdValues = new List<int>();
		[ContainerField(Name: "LifeTresholdValues", Offset: 108, NameHash: 3392040548, Flags: 65)]
		public List<int> LifeTresholdValues { get { return m_LifeTresholdValues; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(LifeTresholdValues), this, m_LifeTresholdValues, value)) m_LifeTresholdValues = value; } } // 0x6C (108)
		
		protected int m_UiShowCountLowerThreshold = new int();
		[ContainerField(Name: "UiShowCountLowerThreshold", Offset: 112, NameHash: 2785336653, Flags: 49405), LayoutImmutable, Blittable]
		public int UiShowCountLowerThreshold { get { return m_UiShowCountLowerThreshold; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(UiShowCountLowerThreshold), this, m_UiShowCountLowerThreshold, value)) m_UiShowCountLowerThreshold = value; } } // 0x70 (112)
		
		protected int m_UiShowCountUpperThreshold = new int();
		[ContainerField(Name: "UiShowCountUpperThreshold", Offset: 116, NameHash: 3322873612, Flags: 49405), LayoutImmutable, Blittable]
		public int UiShowCountUpperThreshold { get { return m_UiShowCountUpperThreshold; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(UiShowCountUpperThreshold), this, m_UiShowCountUpperThreshold, value)) m_UiShowCountUpperThreshold = value; } } // 0x74 (116)
		
		protected int m_BaseCount = new int();
		[ContainerField(Name: "BaseCount", Offset: 120, NameHash: 1694831539, Flags: 49405), LayoutImmutable, Blittable]
		public int BaseCount { get { return m_BaseCount; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(BaseCount), this, m_BaseCount, value)) m_BaseCount = value; } } // 0x78 (120)
		
		protected List<float> m_ReinforceTable = new List<float>();
		[ContainerField(Name: "ReinforceTable", Offset: 124, NameHash: 2268254326, Flags: 65)]
		public List<float> ReinforceTable { get { return m_ReinforceTable; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(ReinforceTable), this, m_ReinforceTable, value)) m_ReinforceTable = value; } } // 0x7C (124)
		
		protected int m_ReinforceThreshold = new int();
		[ContainerField(Name: "ReinforceThreshold", Offset: 128, NameHash: 3361010943, Flags: 49405), LayoutImmutable, Blittable]
		public int ReinforceThreshold { get { return m_ReinforceThreshold; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(ReinforceThreshold), this, m_ReinforceThreshold, value)) m_ReinforceThreshold = value; } } // 0x80 (128)
		
		protected string m_ReinforceMessageSid = string.Empty;
		[ContainerField(Name: "ReinforceMessageSid", Offset: 132, NameHash: 331217021, Flags: 16509), LayoutImmutable]
		public string ReinforceMessageSid { get { return m_ReinforceMessageSid; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(ReinforceMessageSid), this, m_ReinforceMessageSid, value)) m_ReinforceMessageSid = value; } } // 0x84 (132)
		
		protected float m_FightHarderTreshold = new float();
		[ContainerField(Name: "FightHarderTreshold", Offset: 136, NameHash: 2263650182, Flags: 49469), LayoutImmutable, Blittable]
		public float FightHarderTreshold { get { return m_FightHarderTreshold; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(FightHarderTreshold), this, m_FightHarderTreshold, value)) m_FightHarderTreshold = value; } } // 0x88 (136)
		
		protected float m_DefensiveKillRadius = new float();
		[ContainerField(Name: "DefensiveKillRadius", Offset: 140, NameHash: 2115687194, Flags: 49469), LayoutImmutable, Blittable]
		public float DefensiveKillRadius { get { return m_DefensiveKillRadius; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(DefensiveKillRadius), this, m_DefensiveKillRadius, value)) m_DefensiveKillRadius = value; } } // 0x8C (140)
		
		protected float m_FallbackTime = new float();
		[ContainerField(Name: "FallbackTime", Offset: 144, NameHash: 1213191836, Flags: 49469), LayoutImmutable, Blittable]
		public float FallbackTime { get { return m_FallbackTime; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(FallbackTime), this, m_FallbackTime, value)) m_FallbackTime = value; } } // 0x90 (144)
		
		protected string m_FightHarderMessageSid = string.Empty;
		[ContainerField(Name: "FightHarderMessageSid", Offset: 148, NameHash: 4210634540, Flags: 16509), LayoutImmutable]
		public string FightHarderMessageSid { get { return m_FightHarderMessageSid; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(FightHarderMessageSid), this, m_FightHarderMessageSid, value)) m_FightHarderMessageSid = value; } } // 0x94 (148)
		
		protected bool m_Attacker = new bool();
		[ContainerField(Name: "Attacker", Offset: 152, NameHash: 454612250, Flags: 49325), LayoutImmutable, Blittable]
		public bool Attacker { get { return m_Attacker; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(Attacker), this, m_Attacker, value)) m_Attacker = value; } } // 0x98 (152)
		
		protected bool m_SetBestSquadSpawner = new bool();
		[ContainerField(Name: "SetBestSquadSpawner", Offset: 153, NameHash: 1050080153, Flags: 49325), LayoutImmutable, Blittable]
		public bool SetBestSquadSpawner { get { return m_SetBestSquadSpawner; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(SetBestSquadSpawner), this, m_SetBestSquadSpawner, value)) m_SetBestSquadSpawner = value; } } // 0x99 (153)
		
		protected bool m_SimpleReinforce = new bool();
		[ContainerField(Name: "SimpleReinforce", Offset: 154, NameHash: 4042376934, Flags: 49325), LayoutImmutable, Blittable]
		public bool SimpleReinforce { get { return m_SimpleReinforce; } set { if (OnPropertyChanging("LifeCounterEntityData." + nameof(SimpleReinforce), this, m_SimpleReinforce, value)) m_SimpleReinforce = value; } } // 0x9A (154)
		
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
