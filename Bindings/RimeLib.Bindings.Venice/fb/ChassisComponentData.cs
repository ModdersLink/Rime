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
	public class ChassisComponentData : 
		PartComponentData
	{
		[ContainerField(112)]
		public CtrRef<VehicleConfigData> VehicleConfig { get; set; } = new CtrRef<VehicleConfigData>(); // 0x70 (112)
		
		[ContainerField(116)]
		public CtrRef<GearboxConfigData> GearboxConfig { get; set; } = new CtrRef<GearboxConfigData>(); // 0x74 (116)
		
		[ContainerField(120)]
		public RefArray<VehicleWaterEffectData> WaterStreakEffects { get; set; } = new RefArray<VehicleWaterEffectData>(); // 0x78 (120)
		
		[ContainerField(124)]
		public RefArray<VehicleWaterEffectData> WaterEffects { get; set; } = new RefArray<VehicleWaterEffectData>(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float TriggerGroundEffectImpulse { get; set; } // 0x80 (128)
		
		[ContainerField(132)]
		public CtrRef<LandingGearLogicData> LandingGearLogic { get; set; } = new CtrRef<LandingGearLogicData>(); // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public bool AlwaysFullThrottle { get; set; } // 0x88 (136)
		
		[ContainerField(137), LayoutImmutable, Blittable]
		public bool ForceLandingGearsRetract { get; set; } // 0x89 (137)
		
		[ContainerField(138), LayoutImmutable, Blittable]
		public bool AllowNegativeThrottle { get; set; } // 0x8A (138)
		
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
