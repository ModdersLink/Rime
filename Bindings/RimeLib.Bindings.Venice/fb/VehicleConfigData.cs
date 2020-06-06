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
	public class VehicleConfigData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CenterOfMass { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CenterOfMassHandlingOffset { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InertiaModifier { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64)]
		public CtrRef<AeroDynamicPhysicsData> AeroDynamicPhysics { get; set; } = new CtrRef<AeroDynamicPhysicsData>(); // 0x40 (64)
		
		[ContainerField(68)]
		public CtrRef<VehicleParachuteData> ParachutePhysics { get; set; } = new CtrRef<VehicleParachuteData>(); // 0x44 (68)
		
		[ContainerField(72)]
		public CtrRef<MotorbikeData> MotorbikePhysics { get; set; } = new CtrRef<MotorbikeData>(); // 0x48 (72)
		
		[ContainerField(76)]
		public CtrRef<MotionDampingData> MotionDamping { get; set; } = new CtrRef<MotionDampingData>(); // 0x4C (76)
		
		[ContainerField(80)]
		public VehicleInputData Input { get; set; } = new VehicleInputData(); // 0x50 (80)
		
		[ContainerField(160)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new CtrRef<FloatPhysicsData>(); // 0xA0 (160)
		
		[ContainerField(164)]
		public CtrRef<StabilizerData> Stabilizer { get; set; } = new CtrRef<StabilizerData>(); // 0xA4 (164)
		
		[ContainerField(168)]
		public List<StabilizerSettings> Stabilizers { get; set; } = new List<StabilizerSettings>(); // 0xA8 (168)
		
		[ContainerField(172)]
		public List<ConstantForceData> ConstantForce { get; set; } = new List<ConstantForceData>(); // 0xAC (172)
		
		[ContainerField(176)]
		public VehicleMode VehicleModeAtReset { get; set; } = new VehicleMode(); // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float BodyMass { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float GravityModifier { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float YawMin { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float YawMax { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float DownForceBaseFactor { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float DownForceWheelFactor { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float VehicleModeChangeEnteringTime { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float VehicleModeChangeStartingTime { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float VehicleModeChangeStoppingTime { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float VehicleModeChangeLeavingTime { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float StandStillLowSpeedTimeLimit { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float StaticFrictionBreakCollisionMod { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float StaticFrictionBreakVelocityMod { get; set; } // 0xE4 (228)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float CoefficientOfAirFriction { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float AirDensity { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public float AirDragArea { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public float WindResistanceBaseFactor { get; set; } // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public float WindResistanceVelocityFactor { get; set; } // 0xF8 (248)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public float WindResistanceVelocityFactorMin { get; set; } // 0xFC (252)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public float WindResistanceVelocityFactorMax { get; set; } // 0x100 (256)
		
		[ContainerField(260)]
		public AntiRollBars AntiRollBars { get; set; } = new AntiRollBars(); // 0x104 (260)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public bool UseDownForceWheelFactor { get; set; } // 0x10C (268)
		
		[ContainerField(269), LayoutImmutable, Blittable]
		public bool UseGearbox { get; set; } // 0x10D (269)
		
		[ContainerField(270), LayoutImmutable, Blittable]
		public bool UseStandStillBrake { get; set; } // 0x10E (270)
		
		[ContainerField(271), LayoutImmutable, Blittable]
		public bool UseStandStillSleep { get; set; } // 0x10F (271)
		
		[ContainerField(272), LayoutImmutable, Blittable]
		public bool UseTurnAroundForce { get; set; } // 0x110 (272)
		
		[ContainerField(273), LayoutImmutable, Blittable]
		public bool UseMotorcycleControl { get; set; } // 0x111 (273)
		
		[ContainerField(274), LayoutImmutable, Blittable]
		public bool InvertPitchAllowed { get; set; } // 0x112 (274)
		
		[ContainerField(275), LayoutImmutable, Blittable]
		public bool UseWindResistance { get; set; } // 0x113 (275)
		
		[ContainerField(276), LayoutImmutable, Blittable]
		public bool UseDownForce { get; set; } // 0x114 (276)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 361795531:
					CenterOfMass = (Vec3) p_Value;
					break;

				case 168252105:
					CenterOfMassHandlingOffset = (Vec3) p_Value;
					break;

				case 3532865534:
					InertiaModifier = (Vec3) p_Value;
					break;

				case 2399848130:
					AeroDynamicPhysics = (CtrRef<AeroDynamicPhysicsData>) p_Value;
					break;

				case 3076063843:
					ParachutePhysics = (CtrRef<VehicleParachuteData>) p_Value;
					break;

				case 3743341024:
					MotorbikePhysics = (CtrRef<MotorbikeData>) p_Value;
					break;

				case 1754408739:
					MotionDamping = (CtrRef<MotionDampingData>) p_Value;
					break;

				case 214522259:
					Input = (VehicleInputData) p_Value;
					break;

				case 2331402366:
					FloatPhysics = (CtrRef<FloatPhysicsData>) p_Value;
					break;

				case 103642688:
					Stabilizer = (CtrRef<StabilizerData>) p_Value;
					break;

				case 3420208691:
					Stabilizers = (List<StabilizerSettings>) p_Value;
					break;

				case 292465510:
					ConstantForce = (List<ConstantForceData>) p_Value;
					break;

				case 2802222942:
					VehicleModeAtReset = (VehicleMode) Enum.ToObject(typeof(VehicleMode), p_Value);
					break;

				case 1687717849:
					BodyMass = (float) p_Value;
					break;

				case 1597941524:
					GravityModifier = (float) p_Value;
					break;

				case 3424707936:
					YawMin = (float) p_Value;
					break;

				case 3424707710:
					YawMax = (float) p_Value;
					break;

				case 3150497810:
					DownForceBaseFactor = (float) p_Value;
					break;

				case 2362709428:
					DownForceWheelFactor = (float) p_Value;
					break;

				case 2388855333:
					VehicleModeChangeEnteringTime = (float) p_Value;
					break;

				case 3960598669:
					VehicleModeChangeStartingTime = (float) p_Value;
					break;

				case 1591712197:
					VehicleModeChangeStoppingTime = (float) p_Value;
					break;

				case 2810866003:
					VehicleModeChangeLeavingTime = (float) p_Value;
					break;

				case 1874961716:
					StandStillLowSpeedTimeLimit = (float) p_Value;
					break;

				case 2830214072:
					StaticFrictionBreakCollisionMod = (float) p_Value;
					break;

				case 2340632433:
					StaticFrictionBreakVelocityMod = (float) p_Value;
					break;

				case 2384886817:
					CoefficientOfAirFriction = (float) p_Value;
					break;

				case 2185227687:
					AirDensity = (float) p_Value;
					break;

				case 711586744:
					AirDragArea = (float) p_Value;
					break;

				case 2449706634:
					WindResistanceBaseFactor = (float) p_Value;
					break;

				case 1925688264:
					WindResistanceVelocityFactor = (float) p_Value;
					break;

				case 2945998498:
					WindResistanceVelocityFactorMin = (float) p_Value;
					break;

				case 2945998268:
					WindResistanceVelocityFactorMax = (float) p_Value;
					break;

				case 3162631432:
					AntiRollBars = (AntiRollBars) p_Value;
					break;

				case 1501599031:
					UseDownForceWheelFactor = (bool) p_Value;
					break;

				case 2279282370:
					UseGearbox = (bool) p_Value;
					break;

				case 1632443835:
					UseStandStillBrake = (bool) p_Value;
					break;

				case 1649809771:
					UseStandStillSleep = (bool) p_Value;
					break;

				case 3314651845:
					UseTurnAroundForce = (bool) p_Value;
					break;

				case 1123886874:
					UseMotorcycleControl = (bool) p_Value;
					break;

				case 2854376649:
					InvertPitchAllowed = (bool) p_Value;
					break;

				case 2549367409:
					UseWindResistance = (bool) p_Value;
					break;

				case 2101870921:
					UseDownForce = (bool) p_Value;
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
				case 361795531:
					return CenterOfMass;

				case 168252105:
					return CenterOfMassHandlingOffset;

				case 3532865534:
					return InertiaModifier;

				case 2399848130:
					return AeroDynamicPhysics;

				case 3076063843:
					return ParachutePhysics;

				case 3743341024:
					return MotorbikePhysics;

				case 1754408739:
					return MotionDamping;

				case 214522259:
					return Input;

				case 2331402366:
					return FloatPhysics;

				case 103642688:
					return Stabilizer;

				case 3420208691:
					return Stabilizers;

				case 292465510:
					return ConstantForce;

				case 2802222942:
					return VehicleModeAtReset;

				case 1687717849:
					return BodyMass;

				case 1597941524:
					return GravityModifier;

				case 3424707936:
					return YawMin;

				case 3424707710:
					return YawMax;

				case 3150497810:
					return DownForceBaseFactor;

				case 2362709428:
					return DownForceWheelFactor;

				case 2388855333:
					return VehicleModeChangeEnteringTime;

				case 3960598669:
					return VehicleModeChangeStartingTime;

				case 1591712197:
					return VehicleModeChangeStoppingTime;

				case 2810866003:
					return VehicleModeChangeLeavingTime;

				case 1874961716:
					return StandStillLowSpeedTimeLimit;

				case 2830214072:
					return StaticFrictionBreakCollisionMod;

				case 2340632433:
					return StaticFrictionBreakVelocityMod;

				case 2384886817:
					return CoefficientOfAirFriction;

				case 2185227687:
					return AirDensity;

				case 711586744:
					return AirDragArea;

				case 2449706634:
					return WindResistanceBaseFactor;

				case 1925688264:
					return WindResistanceVelocityFactor;

				case 2945998498:
					return WindResistanceVelocityFactorMin;

				case 2945998268:
					return WindResistanceVelocityFactorMax;

				case 3162631432:
					return AntiRollBars;

				case 1501599031:
					return UseDownForceWheelFactor;

				case 2279282370:
					return UseGearbox;

				case 1632443835:
					return UseStandStillBrake;

				case 1649809771:
					return UseStandStillSleep;

				case 3314651845:
					return UseTurnAroundForce;

				case 1123886874:
					return UseMotorcycleControl;

				case 2854376649:
					return InvertPitchAllowed;

				case 2549367409:
					return UseWindResistance;

				case 2101870921:
					return UseDownForce;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 361795531:
					return typeof(VehicleConfigData).GetProperty(nameof(CenterOfMass));

				case 168252105:
					return typeof(VehicleConfigData).GetProperty(nameof(CenterOfMassHandlingOffset));

				case 3532865534:
					return typeof(VehicleConfigData).GetProperty(nameof(InertiaModifier));

				case 2399848130:
					return typeof(VehicleConfigData).GetProperty(nameof(AeroDynamicPhysics));

				case 3076063843:
					return typeof(VehicleConfigData).GetProperty(nameof(ParachutePhysics));

				case 3743341024:
					return typeof(VehicleConfigData).GetProperty(nameof(MotorbikePhysics));

				case 1754408739:
					return typeof(VehicleConfigData).GetProperty(nameof(MotionDamping));

				case 214522259:
					return typeof(VehicleConfigData).GetProperty(nameof(Input));

				case 2331402366:
					return typeof(VehicleConfigData).GetProperty(nameof(FloatPhysics));

				case 103642688:
					return typeof(VehicleConfigData).GetProperty(nameof(Stabilizer));

				case 3420208691:
					return typeof(VehicleConfigData).GetProperty(nameof(Stabilizers));

				case 292465510:
					return typeof(VehicleConfigData).GetProperty(nameof(ConstantForce));

				case 2802222942:
					return typeof(VehicleConfigData).GetProperty(nameof(VehicleModeAtReset));

				case 1687717849:
					return typeof(VehicleConfigData).GetProperty(nameof(BodyMass));

				case 1597941524:
					return typeof(VehicleConfigData).GetProperty(nameof(GravityModifier));

				case 3424707936:
					return typeof(VehicleConfigData).GetProperty(nameof(YawMin));

				case 3424707710:
					return typeof(VehicleConfigData).GetProperty(nameof(YawMax));

				case 3150497810:
					return typeof(VehicleConfigData).GetProperty(nameof(DownForceBaseFactor));

				case 2362709428:
					return typeof(VehicleConfigData).GetProperty(nameof(DownForceWheelFactor));

				case 2388855333:
					return typeof(VehicleConfigData).GetProperty(nameof(VehicleModeChangeEnteringTime));

				case 3960598669:
					return typeof(VehicleConfigData).GetProperty(nameof(VehicleModeChangeStartingTime));

				case 1591712197:
					return typeof(VehicleConfigData).GetProperty(nameof(VehicleModeChangeStoppingTime));

				case 2810866003:
					return typeof(VehicleConfigData).GetProperty(nameof(VehicleModeChangeLeavingTime));

				case 1874961716:
					return typeof(VehicleConfigData).GetProperty(nameof(StandStillLowSpeedTimeLimit));

				case 2830214072:
					return typeof(VehicleConfigData).GetProperty(nameof(StaticFrictionBreakCollisionMod));

				case 2340632433:
					return typeof(VehicleConfigData).GetProperty(nameof(StaticFrictionBreakVelocityMod));

				case 2384886817:
					return typeof(VehicleConfigData).GetProperty(nameof(CoefficientOfAirFriction));

				case 2185227687:
					return typeof(VehicleConfigData).GetProperty(nameof(AirDensity));

				case 711586744:
					return typeof(VehicleConfigData).GetProperty(nameof(AirDragArea));

				case 2449706634:
					return typeof(VehicleConfigData).GetProperty(nameof(WindResistanceBaseFactor));

				case 1925688264:
					return typeof(VehicleConfigData).GetProperty(nameof(WindResistanceVelocityFactor));

				case 2945998498:
					return typeof(VehicleConfigData).GetProperty(nameof(WindResistanceVelocityFactorMin));

				case 2945998268:
					return typeof(VehicleConfigData).GetProperty(nameof(WindResistanceVelocityFactorMax));

				case 3162631432:
					return typeof(VehicleConfigData).GetProperty(nameof(AntiRollBars));

				case 1501599031:
					return typeof(VehicleConfigData).GetProperty(nameof(UseDownForceWheelFactor));

				case 2279282370:
					return typeof(VehicleConfigData).GetProperty(nameof(UseGearbox));

				case 1632443835:
					return typeof(VehicleConfigData).GetProperty(nameof(UseStandStillBrake));

				case 1649809771:
					return typeof(VehicleConfigData).GetProperty(nameof(UseStandStillSleep));

				case 3314651845:
					return typeof(VehicleConfigData).GetProperty(nameof(UseTurnAroundForce));

				case 1123886874:
					return typeof(VehicleConfigData).GetProperty(nameof(UseMotorcycleControl));

				case 2854376649:
					return typeof(VehicleConfigData).GetProperty(nameof(InvertPitchAllowed));

				case 2549367409:
					return typeof(VehicleConfigData).GetProperty(nameof(UseWindResistance));

				case 2101870921:
					return typeof(VehicleConfigData).GetProperty(nameof(UseDownForce));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
