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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(144), ContainerClass]
	public class ChassisComponentData : 
		PartComponentData
	{
		protected CtrRef<VehicleConfigData> m_VehicleConfig = new CtrRef<VehicleConfigData>();
		[ContainerField(112), MemberInfoFlag(53), ContainerFieldNameHash(14921303), ContainerCtrRef]
		public CtrRef<VehicleConfigData> VehicleConfig { get { return m_VehicleConfig; } set { if (OnPropertyChanging("ChassisComponentData." + nameof(VehicleConfig), this, m_VehicleConfig, value)) m_VehicleConfig = value; } } // 0x70 (112)
		
		protected CtrRef<GearboxConfigData> m_GearboxConfig = new CtrRef<GearboxConfigData>();
		[ContainerField(116), MemberInfoFlag(53), ContainerFieldNameHash(1478960267), ContainerCtrRef]
		public CtrRef<GearboxConfigData> GearboxConfig { get { return m_GearboxConfig; } set { if (OnPropertyChanging("ChassisComponentData." + nameof(GearboxConfig), this, m_GearboxConfig, value)) m_GearboxConfig = value; } } // 0x74 (116)
		
		protected RefArray<VehicleWaterEffectData> m_WaterStreakEffects = new RefArray<VehicleWaterEffectData>();
		[ContainerField(120), MemberInfoFlag(65), ContainerFieldNameHash(1233991406), ContainerRefArray]
		public RefArray<VehicleWaterEffectData> WaterStreakEffects { get { return m_WaterStreakEffects; } set { if (OnPropertyChanging("ChassisComponentData." + nameof(WaterStreakEffects), this, m_WaterStreakEffects, value)) m_WaterStreakEffects = value; } } // 0x78 (120)
		
		protected RefArray<VehicleWaterEffectData> m_WaterEffects = new RefArray<VehicleWaterEffectData>();
		[ContainerField(124), MemberInfoFlag(65), ContainerFieldNameHash(1529363092), ContainerRefArray]
		public RefArray<VehicleWaterEffectData> WaterEffects { get { return m_WaterEffects; } set { if (OnPropertyChanging("ChassisComponentData." + nameof(WaterEffects), this, m_WaterEffects, value)) m_WaterEffects = value; } } // 0x7C (124)
		
		protected float m_TriggerGroundEffectImpulse = new float();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3804940212)]
		public float TriggerGroundEffectImpulse { get { return m_TriggerGroundEffectImpulse; } set { if (OnPropertyChanging("ChassisComponentData." + nameof(TriggerGroundEffectImpulse), this, m_TriggerGroundEffectImpulse, value)) m_TriggerGroundEffectImpulse = value; } } // 0x80 (128)
		
		protected CtrRef<LandingGearLogicData> m_LandingGearLogic = new CtrRef<LandingGearLogicData>();
		[ContainerField(132), MemberInfoFlag(53), ContainerFieldNameHash(3799182877), ContainerCtrRef]
		public CtrRef<LandingGearLogicData> LandingGearLogic { get { return m_LandingGearLogic; } set { if (OnPropertyChanging("ChassisComponentData." + nameof(LandingGearLogic), this, m_LandingGearLogic, value)) m_LandingGearLogic = value; } } // 0x84 (132)
		
		protected bool m_AlwaysFullThrottle = new bool();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2632109007)]
		public bool AlwaysFullThrottle { get { return m_AlwaysFullThrottle; } set { if (OnPropertyChanging("ChassisComponentData." + nameof(AlwaysFullThrottle), this, m_AlwaysFullThrottle, value)) m_AlwaysFullThrottle = value; } } // 0x88 (136)
		
		protected bool m_ForceLandingGearsRetract = new bool();
		[ContainerField(137), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1620848058)]
		public bool ForceLandingGearsRetract { get { return m_ForceLandingGearsRetract; } set { if (OnPropertyChanging("ChassisComponentData." + nameof(ForceLandingGearsRetract), this, m_ForceLandingGearsRetract, value)) m_ForceLandingGearsRetract = value; } } // 0x89 (137)
		
		protected bool m_AllowNegativeThrottle = new bool();
		[ContainerField(138), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1548999735)]
		public bool AllowNegativeThrottle { get { return m_AllowNegativeThrottle; } set { if (OnPropertyChanging("ChassisComponentData." + nameof(AllowNegativeThrottle), this, m_AllowNegativeThrottle, value)) m_AllowNegativeThrottle = value; } } // 0x8A (138)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 14921303:
					VehicleConfig = (CtrRef<VehicleConfigData>) p_Value;
					break;

				case 1478960267:
					GearboxConfig = (CtrRef<GearboxConfigData>) p_Value;
					break;

				case 1233991406:
					WaterStreakEffects = (RefArray<VehicleWaterEffectData>) p_Value;
					break;

				case 1529363092:
					WaterEffects = (RefArray<VehicleWaterEffectData>) p_Value;
					break;

				case 3804940212:
					TriggerGroundEffectImpulse = (float) p_Value;
					break;

				case 3799182877:
					LandingGearLogic = (CtrRef<LandingGearLogicData>) p_Value;
					break;

				case 2632109007:
					AlwaysFullThrottle = (bool) p_Value;
					break;

				case 1620848058:
					ForceLandingGearsRetract = (bool) p_Value;
					break;

				case 1548999735:
					AllowNegativeThrottle = (bool) p_Value;
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
				case 14921303:
					return VehicleConfig;

				case 1478960267:
					return GearboxConfig;

				case 1233991406:
					return WaterStreakEffects;

				case 1529363092:
					return WaterEffects;

				case 3804940212:
					return TriggerGroundEffectImpulse;

				case 3799182877:
					return LandingGearLogic;

				case 2632109007:
					return AlwaysFullThrottle;

				case 1620848058:
					return ForceLandingGearsRetract;

				case 1548999735:
					return AllowNegativeThrottle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 14921303:
					return typeof(ChassisComponentData).GetProperty(nameof(VehicleConfig));

				case 1478960267:
					return typeof(ChassisComponentData).GetProperty(nameof(GearboxConfig));

				case 1233991406:
					return typeof(ChassisComponentData).GetProperty(nameof(WaterStreakEffects));

				case 1529363092:
					return typeof(ChassisComponentData).GetProperty(nameof(WaterEffects));

				case 3804940212:
					return typeof(ChassisComponentData).GetProperty(nameof(TriggerGroundEffectImpulse));

				case 3799182877:
					return typeof(ChassisComponentData).GetProperty(nameof(LandingGearLogic));

				case 2632109007:
					return typeof(ChassisComponentData).GetProperty(nameof(AlwaysFullThrottle));

				case 1620848058:
					return typeof(ChassisComponentData).GetProperty(nameof(ForceLandingGearsRetract));

				case 1548999735:
					return typeof(ChassisComponentData).GetProperty(nameof(AllowNegativeThrottle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
