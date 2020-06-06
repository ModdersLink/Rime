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
	public class HullFloatPhysicsData : 
		FloatPhysicsData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WaterResistanceAxisMod { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WaterFrictionAxisMod { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public int SubSurfaceSplits { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float Depth { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float Width { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float Length { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float FrontCurveDegree { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float SideCurveDegree { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float NonEngineSteer { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float NonEngineSteerMinSpeed { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float NonEngineSteerMaxSpeed { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float WaterDampeningMod { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float LiftModifier { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float SupportSizeMod { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float AngularDampening { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float FrictionThrottleModifier { get; set; } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3948471318:
					WaterResistanceAxisMod = (Vec3) p_Value;
					break;

				case 3626723959:
					WaterFrictionAxisMod = (Vec3) p_Value;
					break;

				case 2871410728:
					Offset = (Vec3) p_Value;
					break;

				case 1890108277:
					SubSurfaceSplits = (int) p_Value;
					break;

				case 208780552:
					Depth = (float) p_Value;
					break;

				case 226981187:
					Width = (float) p_Value;
					break;

				case 2906827577:
					Length = (float) p_Value;
					break;

				case 2319028903:
					FrontCurveDegree = (float) p_Value;
					break;

				case 2221634077:
					SideCurveDegree = (float) p_Value;
					break;

				case 2436950673:
					NonEngineSteer = (float) p_Value;
					break;

				case 625608988:
					NonEngineSteerMinSpeed = (float) p_Value;
					break;

				case 1082953922:
					NonEngineSteerMaxSpeed = (float) p_Value;
					break;

				case 4227810501:
					WaterDampeningMod = (float) p_Value;
					break;

				case 2708301317:
					LiftModifier = (float) p_Value;
					break;

				case 115690313:
					SupportSizeMod = (float) p_Value;
					break;

				case 705185012:
					AngularDampening = (float) p_Value;
					break;

				case 2928282680:
					FrictionThrottleModifier = (float) p_Value;
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
				case 3948471318:
					return WaterResistanceAxisMod;

				case 3626723959:
					return WaterFrictionAxisMod;

				case 2871410728:
					return Offset;

				case 1890108277:
					return SubSurfaceSplits;

				case 208780552:
					return Depth;

				case 226981187:
					return Width;

				case 2906827577:
					return Length;

				case 2319028903:
					return FrontCurveDegree;

				case 2221634077:
					return SideCurveDegree;

				case 2436950673:
					return NonEngineSteer;

				case 625608988:
					return NonEngineSteerMinSpeed;

				case 1082953922:
					return NonEngineSteerMaxSpeed;

				case 4227810501:
					return WaterDampeningMod;

				case 2708301317:
					return LiftModifier;

				case 115690313:
					return SupportSizeMod;

				case 705185012:
					return AngularDampening;

				case 2928282680:
					return FrictionThrottleModifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3948471318:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(WaterResistanceAxisMod));

				case 3626723959:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(WaterFrictionAxisMod));

				case 2871410728:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(Offset));

				case 1890108277:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(SubSurfaceSplits));

				case 208780552:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(Depth));

				case 226981187:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(Width));

				case 2906827577:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(Length));

				case 2319028903:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(FrontCurveDegree));

				case 2221634077:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(SideCurveDegree));

				case 2436950673:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(NonEngineSteer));

				case 625608988:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(NonEngineSteerMinSpeed));

				case 1082953922:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(NonEngineSteerMaxSpeed));

				case 4227810501:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(WaterDampeningMod));

				case 2708301317:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(LiftModifier));

				case 115690313:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(SupportSizeMod));

				case 705185012:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(AngularDampening));

				case 2928282680:
					return typeof(HullFloatPhysicsData).GetProperty(nameof(FrictionThrottleModifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
