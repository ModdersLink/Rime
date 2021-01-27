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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 144)]
	public class TicketCounterEntityData : 
		GameEntityData
	{
		protected List<TicketCountPercentage> m_TicketPercentages = new List<TicketCountPercentage>();
		[ContainerField(Name: "TicketPercentages", Offset: 96, NameHash: 2204467466, Flags: 65)]
		public List<TicketCountPercentage> TicketPercentages { get { return m_TicketPercentages; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(TicketPercentages), this, m_TicketPercentages, value)) m_TicketPercentages = value; } } // 0x60 (96)
		
		protected int m_TicketLossPerMin = new int();
		[ContainerField(Name: "TicketLossPerMin", Offset: 100, NameHash: 2113367375, Flags: 49405), LayoutImmutable, Blittable]
		public int TicketLossPerMin { get { return m_TicketLossPerMin; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(TicketLossPerMin), this, m_TicketLossPerMin, value)) m_TicketLossPerMin = value; } } // 0x64 (100)
		
		protected TicketDecreaseType m_DecreaseTickets = new TicketDecreaseType();
		[ContainerField(Name: "DecreaseTickets", Offset: 104, NameHash: 3370519728, Flags: 137)]
		public TicketDecreaseType DecreaseTickets { get { return m_DecreaseTickets; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(DecreaseTickets), this, m_DecreaseTickets, value)) m_DecreaseTickets = value; } } // 0x68 (104)
		
		protected TeamId m_TeamId = new TeamId();
		[ContainerField(Name: "TeamId", Offset: 108, NameHash: 3220374101, Flags: 137)]
		public TeamId TeamId { get { return m_TeamId; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(TeamId), this, m_TeamId, value)) m_TeamId = value; } } // 0x6C (108)
		
		protected int m_TicketLossWhenLostAll = new int();
		[ContainerField(Name: "TicketLossWhenLostAll", Offset: 112, NameHash: 664870867, Flags: 49405), LayoutImmutable, Blittable]
		public int TicketLossWhenLostAll { get { return m_TicketLossWhenLostAll; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(TicketLossWhenLostAll), this, m_TicketLossWhenLostAll, value)) m_TicketLossWhenLostAll = value; } } // 0x70 (112)
		
		protected int m_TicketLossWhenLostAllControlsPoint = new int();
		[ContainerField(Name: "TicketLossWhenLostAllControlsPoint", Offset: 116, NameHash: 1341075147, Flags: 49405), LayoutImmutable, Blittable]
		public int TicketLossWhenLostAllControlsPoint { get { return m_TicketLossWhenLostAllControlsPoint; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(TicketLossWhenLostAllControlsPoint), this, m_TicketLossWhenLostAllControlsPoint, value)) m_TicketLossWhenLostAllControlsPoint = value; } } // 0x74 (116)
		
		protected int m_InitialTicketCount = new int();
		[ContainerField(Name: "InitialTicketCount", Offset: 120, NameHash: 264089340, Flags: 49405), LayoutImmutable, Blittable]
		public int InitialTicketCount { get { return m_InitialTicketCount; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(InitialTicketCount), this, m_InitialTicketCount, value)) m_InitialTicketCount = value; } } // 0x78 (120)
		
		protected int m_TicketLossStart = new int();
		[ContainerField(Name: "TicketLossStart", Offset: 124, NameHash: 3058094434, Flags: 49405), LayoutImmutable, Blittable]
		public int TicketLossStart { get { return m_TicketLossStart; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(TicketLossStart), this, m_TicketLossStart, value)) m_TicketLossStart = value; } } // 0x7C (124)
		
		protected bool m_SetBestSquadSpawner = new bool();
		[ContainerField(Name: "SetBestSquadSpawner", Offset: 128, NameHash: 1050080153, Flags: 49325), LayoutImmutable, Blittable]
		public bool SetBestSquadSpawner { get { return m_SetBestSquadSpawner; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(SetBestSquadSpawner), this, m_SetBestSquadSpawner, value)) m_SetBestSquadSpawner = value; } } // 0x80 (128)
		
		protected bool m_HaltTicketLossOnEqualPointCount = new bool();
		[ContainerField(Name: "HaltTicketLossOnEqualPointCount", Offset: 129, NameHash: 2787909457, Flags: 49325), LayoutImmutable, Blittable]
		public bool HaltTicketLossOnEqualPointCount { get { return m_HaltTicketLossOnEqualPointCount; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(HaltTicketLossOnEqualPointCount), this, m_HaltTicketLossOnEqualPointCount, value)) m_HaltTicketLossOnEqualPointCount = value; } } // 0x81 (129)
		
		protected bool m_ResetCapturePointsOnReset = new bool();
		[ContainerField(Name: "ResetCapturePointsOnReset", Offset: 130, NameHash: 2592156447, Flags: 49325), LayoutImmutable, Blittable]
		public bool ResetCapturePointsOnReset { get { return m_ResetCapturePointsOnReset; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(ResetCapturePointsOnReset), this, m_ResetCapturePointsOnReset, value)) m_ResetCapturePointsOnReset = value; } } // 0x82 (130)
		
		protected bool m_SpawnAlwaysAllowed = new bool();
		[ContainerField(Name: "SpawnAlwaysAllowed", Offset: 131, NameHash: 1811462007, Flags: 49325), LayoutImmutable, Blittable]
		public bool SpawnAlwaysAllowed { get { return m_SpawnAlwaysAllowed; } set { if (OnPropertyChanging("TicketCounterEntityData." + nameof(SpawnAlwaysAllowed), this, m_SpawnAlwaysAllowed, value)) m_SpawnAlwaysAllowed = value; } } // 0x83 (131)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2204467466:
					TicketPercentages = (List<TicketCountPercentage>) p_Value;
					break;

				case 2113367375:
					TicketLossPerMin = (int) p_Value;
					break;

				case 3370519728:
					DecreaseTickets = (TicketDecreaseType) Enum.ToObject(typeof(TicketDecreaseType), p_Value);
					break;

				case 3220374101:
					TeamId = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 664870867:
					TicketLossWhenLostAll = (int) p_Value;
					break;

				case 1341075147:
					TicketLossWhenLostAllControlsPoint = (int) p_Value;
					break;

				case 264089340:
					InitialTicketCount = (int) p_Value;
					break;

				case 3058094434:
					TicketLossStart = (int) p_Value;
					break;

				case 1050080153:
					SetBestSquadSpawner = (bool) p_Value;
					break;

				case 2787909457:
					HaltTicketLossOnEqualPointCount = (bool) p_Value;
					break;

				case 2592156447:
					ResetCapturePointsOnReset = (bool) p_Value;
					break;

				case 1811462007:
					SpawnAlwaysAllowed = (bool) p_Value;
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
				case 2204467466:
					return TicketPercentages;

				case 2113367375:
					return TicketLossPerMin;

				case 3370519728:
					return DecreaseTickets;

				case 3220374101:
					return TeamId;

				case 664870867:
					return TicketLossWhenLostAll;

				case 1341075147:
					return TicketLossWhenLostAllControlsPoint;

				case 264089340:
					return InitialTicketCount;

				case 3058094434:
					return TicketLossStart;

				case 1050080153:
					return SetBestSquadSpawner;

				case 2787909457:
					return HaltTicketLossOnEqualPointCount;

				case 2592156447:
					return ResetCapturePointsOnReset;

				case 1811462007:
					return SpawnAlwaysAllowed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2204467466:
					return typeof(TicketCounterEntityData).GetProperty(nameof(TicketPercentages));

				case 2113367375:
					return typeof(TicketCounterEntityData).GetProperty(nameof(TicketLossPerMin));

				case 3370519728:
					return typeof(TicketCounterEntityData).GetProperty(nameof(DecreaseTickets));

				case 3220374101:
					return typeof(TicketCounterEntityData).GetProperty(nameof(TeamId));

				case 664870867:
					return typeof(TicketCounterEntityData).GetProperty(nameof(TicketLossWhenLostAll));

				case 1341075147:
					return typeof(TicketCounterEntityData).GetProperty(nameof(TicketLossWhenLostAllControlsPoint));

				case 264089340:
					return typeof(TicketCounterEntityData).GetProperty(nameof(InitialTicketCount));

				case 3058094434:
					return typeof(TicketCounterEntityData).GetProperty(nameof(TicketLossStart));

				case 1050080153:
					return typeof(TicketCounterEntityData).GetProperty(nameof(SetBestSquadSpawner));

				case 2787909457:
					return typeof(TicketCounterEntityData).GetProperty(nameof(HaltTicketLossOnEqualPointCount));

				case 2592156447:
					return typeof(TicketCounterEntityData).GetProperty(nameof(ResetCapturePointsOnReset));

				case 1811462007:
					return typeof(TicketCounterEntityData).GetProperty(nameof(SpawnAlwaysAllowed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
