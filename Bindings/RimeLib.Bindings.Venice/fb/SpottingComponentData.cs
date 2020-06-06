///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SpottingComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float SpottingFov { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float TeamOrderFov { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float SpottingDistance { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float PassiveSpottingTimeInterval { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float TimeRequiredToPassiveSpot { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float OrderNeedAmmoPercentage { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float OrderHealPercentage { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float OrderRepairPercentage { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float PickupOrderDistance { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float HealOrderDistance { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float AmmoOrderDistance { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float RepairOrderDistance { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float CoolDownHistoryTime { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public int CoolDownAllowedSpotsWithinHistory { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool OnlyAllowedToHaveOneSpottedPlayer { get; set; } // 0x98 (152)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 397806838:
					SpottingFov = (float) p_Value;
					break;

				case 3618311177:
					TeamOrderFov = (float) p_Value;
					break;

				case 3680681002:
					SpottingDistance = (float) p_Value;
					break;

				case 3147290600:
					PassiveSpottingTimeInterval = (float) p_Value;
					break;

				case 1717291665:
					TimeRequiredToPassiveSpot = (float) p_Value;
					break;

				case 92823575:
					OrderNeedAmmoPercentage = (float) p_Value;
					break;

				case 727727347:
					OrderHealPercentage = (float) p_Value;
					break;

				case 579931694:
					OrderRepairPercentage = (float) p_Value;
					break;

				case 968171260:
					PickupOrderDistance = (float) p_Value;
					break;

				case 1879982728:
					HealOrderDistance = (float) p_Value;
					break;

				case 1349582694:
					AmmoOrderDistance = (float) p_Value;
					break;

				case 3910859893:
					RepairOrderDistance = (float) p_Value;
					break;

				case 717220879:
					CoolDownHistoryTime = (float) p_Value;
					break;

				case 2646556076:
					CoolDownAllowedSpotsWithinHistory = (int) p_Value;
					break;

				case 1329177458:
					OnlyAllowedToHaveOneSpottedPlayer = (bool) p_Value;
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
				case 397806838:
					return SpottingFov;

				case 3618311177:
					return TeamOrderFov;

				case 3680681002:
					return SpottingDistance;

				case 3147290600:
					return PassiveSpottingTimeInterval;

				case 1717291665:
					return TimeRequiredToPassiveSpot;

				case 92823575:
					return OrderNeedAmmoPercentage;

				case 727727347:
					return OrderHealPercentage;

				case 579931694:
					return OrderRepairPercentage;

				case 968171260:
					return PickupOrderDistance;

				case 1879982728:
					return HealOrderDistance;

				case 1349582694:
					return AmmoOrderDistance;

				case 3910859893:
					return RepairOrderDistance;

				case 717220879:
					return CoolDownHistoryTime;

				case 2646556076:
					return CoolDownAllowedSpotsWithinHistory;

				case 1329177458:
					return OnlyAllowedToHaveOneSpottedPlayer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 397806838:
					return typeof(SpottingComponentData).GetProperty(nameof(SpottingFov));

				case 3618311177:
					return typeof(SpottingComponentData).GetProperty(nameof(TeamOrderFov));

				case 3680681002:
					return typeof(SpottingComponentData).GetProperty(nameof(SpottingDistance));

				case 3147290600:
					return typeof(SpottingComponentData).GetProperty(nameof(PassiveSpottingTimeInterval));

				case 1717291665:
					return typeof(SpottingComponentData).GetProperty(nameof(TimeRequiredToPassiveSpot));

				case 92823575:
					return typeof(SpottingComponentData).GetProperty(nameof(OrderNeedAmmoPercentage));

				case 727727347:
					return typeof(SpottingComponentData).GetProperty(nameof(OrderHealPercentage));

				case 579931694:
					return typeof(SpottingComponentData).GetProperty(nameof(OrderRepairPercentage));

				case 968171260:
					return typeof(SpottingComponentData).GetProperty(nameof(PickupOrderDistance));

				case 1879982728:
					return typeof(SpottingComponentData).GetProperty(nameof(HealOrderDistance));

				case 1349582694:
					return typeof(SpottingComponentData).GetProperty(nameof(AmmoOrderDistance));

				case 3910859893:
					return typeof(SpottingComponentData).GetProperty(nameof(RepairOrderDistance));

				case 717220879:
					return typeof(SpottingComponentData).GetProperty(nameof(CoolDownHistoryTime));

				case 2646556076:
					return typeof(SpottingComponentData).GetProperty(nameof(CoolDownAllowedSpotsWithinHistory));

				case 1329177458:
					return typeof(SpottingComponentData).GetProperty(nameof(OnlyAllowedToHaveOneSpottedPlayer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
