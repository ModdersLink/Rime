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
	public class TicketCounterEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<TicketCountPercentage> TicketPercentages { get; set; } = new List<TicketCountPercentage>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public int TicketLossPerMin { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public TicketDecreaseType DecreaseTickets { get; set; } = new TicketDecreaseType(); // 0x68 (104)
		
		[ContainerField(108)]
		public TeamId TeamId { get; set; } = new TeamId(); // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public int TicketLossWhenLostAll { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public int TicketLossWhenLostAllControlsPoint { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public int InitialTicketCount { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public int TicketLossStart { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool SetBestSquadSpawner { get; set; } // 0x80 (128)
		
		[ContainerField(129), LayoutImmutable, Blittable]
		public bool HaltTicketLossOnEqualPointCount { get; set; } // 0x81 (129)
		
		[ContainerField(130), LayoutImmutable, Blittable]
		public bool ResetCapturePointsOnReset { get; set; } // 0x82 (130)
		
		[ContainerField(131), LayoutImmutable, Blittable]
		public bool SpawnAlwaysAllowed { get; set; } // 0x83 (131)
		
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
