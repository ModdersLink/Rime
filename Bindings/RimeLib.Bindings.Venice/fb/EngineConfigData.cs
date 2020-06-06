///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class EngineConfigData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32)]
		public List<float> RpmCurvePoints { get; set; } = new List<float>(); // 0x20 (32)
		
		[ContainerField(36)]
		public List<float> TorqueCurvePoints { get; set; } = new List<float>(); // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float RpmMin { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float RpmMax { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float RpmCut { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float EnginePowerMultiplier { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float InternalAccelerationFactor { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float InternalDeaccelerationFactor { get; set; } // 0x3C (60)
		
		[ContainerField(64)]
		public Boost Boost { get; set; } = new Boost(); // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec3) p_Value;
					break;

				case 3171241218:
					RpmCurvePoints = (List<float>) p_Value;
					break;

				case 3328974597:
					TorqueCurvePoints = (List<float>) p_Value;
					break;

				case 3287857536:
					RpmMin = (float) p_Value;
					break;

				case 3287857310:
					RpmMax = (float) p_Value;
					break;

				case 3287864328:
					RpmCut = (float) p_Value;
					break;

				case 3037532383:
					EnginePowerMultiplier = (float) p_Value;
					break;

				case 1996992141:
					InternalAccelerationFactor = (float) p_Value;
					break;

				case 820379788:
					InternalDeaccelerationFactor = (float) p_Value;
					break;

				case 211344160:
					Boost = (Boost) p_Value;
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
				case 3402582524:
					return Position;

				case 3171241218:
					return RpmCurvePoints;

				case 3328974597:
					return TorqueCurvePoints;

				case 3287857536:
					return RpmMin;

				case 3287857310:
					return RpmMax;

				case 3287864328:
					return RpmCut;

				case 3037532383:
					return EnginePowerMultiplier;

				case 1996992141:
					return InternalAccelerationFactor;

				case 820379788:
					return InternalDeaccelerationFactor;

				case 211344160:
					return Boost;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return typeof(EngineConfigData).GetProperty(nameof(Position));

				case 3171241218:
					return typeof(EngineConfigData).GetProperty(nameof(RpmCurvePoints));

				case 3328974597:
					return typeof(EngineConfigData).GetProperty(nameof(TorqueCurvePoints));

				case 3287857536:
					return typeof(EngineConfigData).GetProperty(nameof(RpmMin));

				case 3287857310:
					return typeof(EngineConfigData).GetProperty(nameof(RpmMax));

				case 3287864328:
					return typeof(EngineConfigData).GetProperty(nameof(RpmCut));

				case 3037532383:
					return typeof(EngineConfigData).GetProperty(nameof(EnginePowerMultiplier));

				case 1996992141:
					return typeof(EngineConfigData).GetProperty(nameof(InternalAccelerationFactor));

				case 820379788:
					return typeof(EngineConfigData).GetProperty(nameof(InternalDeaccelerationFactor));

				case 211344160:
					return typeof(EngineConfigData).GetProperty(nameof(Boost));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
