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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 160)]
	public class SpottingComponentData : 
		ComponentData
	{
		protected float m_SpottingFov = new float();
		[ContainerField(Name: "SpottingFov", Offset: 96, NameHash: 397806838, Flags: 49469), LayoutImmutable, Blittable]
		public float SpottingFov { get { return m_SpottingFov; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(SpottingFov), this, m_SpottingFov, value)) m_SpottingFov = value; } } // 0x60 (96)
		
		protected float m_TeamOrderFov = new float();
		[ContainerField(Name: "TeamOrderFov", Offset: 100, NameHash: 3618311177, Flags: 49469), LayoutImmutable, Blittable]
		public float TeamOrderFov { get { return m_TeamOrderFov; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(TeamOrderFov), this, m_TeamOrderFov, value)) m_TeamOrderFov = value; } } // 0x64 (100)
		
		protected float m_SpottingDistance = new float();
		[ContainerField(Name: "SpottingDistance", Offset: 104, NameHash: 3680681002, Flags: 49469), LayoutImmutable, Blittable]
		public float SpottingDistance { get { return m_SpottingDistance; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(SpottingDistance), this, m_SpottingDistance, value)) m_SpottingDistance = value; } } // 0x68 (104)
		
		protected float m_PassiveSpottingTimeInterval = new float();
		[ContainerField(Name: "PassiveSpottingTimeInterval", Offset: 108, NameHash: 3147290600, Flags: 49469), LayoutImmutable, Blittable]
		public float PassiveSpottingTimeInterval { get { return m_PassiveSpottingTimeInterval; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(PassiveSpottingTimeInterval), this, m_PassiveSpottingTimeInterval, value)) m_PassiveSpottingTimeInterval = value; } } // 0x6C (108)
		
		protected float m_TimeRequiredToPassiveSpot = new float();
		[ContainerField(Name: "TimeRequiredToPassiveSpot", Offset: 112, NameHash: 1717291665, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeRequiredToPassiveSpot { get { return m_TimeRequiredToPassiveSpot; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(TimeRequiredToPassiveSpot), this, m_TimeRequiredToPassiveSpot, value)) m_TimeRequiredToPassiveSpot = value; } } // 0x70 (112)
		
		protected float m_OrderNeedAmmoPercentage = new float();
		[ContainerField(Name: "OrderNeedAmmoPercentage", Offset: 116, NameHash: 92823575, Flags: 49469), LayoutImmutable, Blittable]
		public float OrderNeedAmmoPercentage { get { return m_OrderNeedAmmoPercentage; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(OrderNeedAmmoPercentage), this, m_OrderNeedAmmoPercentage, value)) m_OrderNeedAmmoPercentage = value; } } // 0x74 (116)
		
		protected float m_OrderHealPercentage = new float();
		[ContainerField(Name: "OrderHealPercentage", Offset: 120, NameHash: 727727347, Flags: 49469), LayoutImmutable, Blittable]
		public float OrderHealPercentage { get { return m_OrderHealPercentage; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(OrderHealPercentage), this, m_OrderHealPercentage, value)) m_OrderHealPercentage = value; } } // 0x78 (120)
		
		protected float m_OrderRepairPercentage = new float();
		[ContainerField(Name: "OrderRepairPercentage", Offset: 124, NameHash: 579931694, Flags: 49469), LayoutImmutable, Blittable]
		public float OrderRepairPercentage { get { return m_OrderRepairPercentage; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(OrderRepairPercentage), this, m_OrderRepairPercentage, value)) m_OrderRepairPercentage = value; } } // 0x7C (124)
		
		protected float m_PickupOrderDistance = new float();
		[ContainerField(Name: "PickupOrderDistance", Offset: 128, NameHash: 968171260, Flags: 49469), LayoutImmutable, Blittable]
		public float PickupOrderDistance { get { return m_PickupOrderDistance; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(PickupOrderDistance), this, m_PickupOrderDistance, value)) m_PickupOrderDistance = value; } } // 0x80 (128)
		
		protected float m_HealOrderDistance = new float();
		[ContainerField(Name: "HealOrderDistance", Offset: 132, NameHash: 1879982728, Flags: 49469), LayoutImmutable, Blittable]
		public float HealOrderDistance { get { return m_HealOrderDistance; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(HealOrderDistance), this, m_HealOrderDistance, value)) m_HealOrderDistance = value; } } // 0x84 (132)
		
		protected float m_AmmoOrderDistance = new float();
		[ContainerField(Name: "AmmoOrderDistance", Offset: 136, NameHash: 1349582694, Flags: 49469), LayoutImmutable, Blittable]
		public float AmmoOrderDistance { get { return m_AmmoOrderDistance; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(AmmoOrderDistance), this, m_AmmoOrderDistance, value)) m_AmmoOrderDistance = value; } } // 0x88 (136)
		
		protected float m_RepairOrderDistance = new float();
		[ContainerField(Name: "RepairOrderDistance", Offset: 140, NameHash: 3910859893, Flags: 49469), LayoutImmutable, Blittable]
		public float RepairOrderDistance { get { return m_RepairOrderDistance; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(RepairOrderDistance), this, m_RepairOrderDistance, value)) m_RepairOrderDistance = value; } } // 0x8C (140)
		
		protected float m_CoolDownHistoryTime = new float();
		[ContainerField(Name: "CoolDownHistoryTime", Offset: 144, NameHash: 717220879, Flags: 49469), LayoutImmutable, Blittable]
		public float CoolDownHistoryTime { get { return m_CoolDownHistoryTime; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(CoolDownHistoryTime), this, m_CoolDownHistoryTime, value)) m_CoolDownHistoryTime = value; } } // 0x90 (144)
		
		protected int m_CoolDownAllowedSpotsWithinHistory = new int();
		[ContainerField(Name: "CoolDownAllowedSpotsWithinHistory", Offset: 148, NameHash: 2646556076, Flags: 49405), LayoutImmutable, Blittable]
		public int CoolDownAllowedSpotsWithinHistory { get { return m_CoolDownAllowedSpotsWithinHistory; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(CoolDownAllowedSpotsWithinHistory), this, m_CoolDownAllowedSpotsWithinHistory, value)) m_CoolDownAllowedSpotsWithinHistory = value; } } // 0x94 (148)
		
		protected bool m_OnlyAllowedToHaveOneSpottedPlayer = new bool();
		[ContainerField(Name: "OnlyAllowedToHaveOneSpottedPlayer", Offset: 152, NameHash: 1329177458, Flags: 49325), LayoutImmutable, Blittable]
		public bool OnlyAllowedToHaveOneSpottedPlayer { get { return m_OnlyAllowedToHaveOneSpottedPlayer; } set { if (OnPropertyChanging("SpottingComponentData." + nameof(OnlyAllowedToHaveOneSpottedPlayer), this, m_OnlyAllowedToHaveOneSpottedPlayer, value)) m_OnlyAllowedToHaveOneSpottedPlayer = value; } } // 0x98 (152)
		
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
