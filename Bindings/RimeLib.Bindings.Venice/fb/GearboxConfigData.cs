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
    [ContainerType(4)]
	public class GearboxConfigData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<float> ForwardGearRatios { get; set; } = new List<float>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<float> ForwardGearSpeeds { get; set; } = new List<float>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<float> ReverseGearRatios { get; set; } = new List<float>(); // 0x10 (16)
		
		[ContainerField(20)]
		public List<float> ReverseGearSpeeds { get; set; } = new List<float>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int GearboxType { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int GearboxMode { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float GearChangeTime { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float GearDownSpeedFactor { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float OppositeDirGearChangeMaxSpeed { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float OppositeDirGearChangeTime { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float ClutchSpeedFactor { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float TransmissionEfficiency { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float BackwardThrottleLimit { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool UseClassicGearBoxAutoClutch { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool UseNeutralGear { get; set; } // 0x3D (61)
		
		[ContainerField(62), LayoutImmutable, Blittable]
		public bool LimitBackwardThrottle { get; set; } // 0x3E (62)
		
		[ContainerField(63), LayoutImmutable, Blittable]
		public bool UseAutoClutch { get; set; } // 0x3F (63)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3289089437:
					ForwardGearRatios = (List<float>) p_Value;
					break;

				case 3306387643:
					ForwardGearSpeeds = (List<float>) p_Value;
					break;

				case 180205926:
					ReverseGearRatios = (List<float>) p_Value;
					break;

				case 162915904:
					ReverseGearSpeeds = (List<float>) p_Value;
					break;

				case 1540232153:
					GearboxType = (int) p_Value;
					break;

				case 1539978082:
					GearboxMode = (int) p_Value;
					break;

				case 2688527911:
					GearChangeTime = (float) p_Value;
					break;

				case 699099436:
					GearDownSpeedFactor = (float) p_Value;
					break;

				case 3344611765:
					OppositeDirGearChangeMaxSpeed = (float) p_Value;
					break;

				case 777981235:
					OppositeDirGearChangeTime = (float) p_Value;
					break;

				case 1429608074:
					ClutchSpeedFactor = (float) p_Value;
					break;

				case 846717476:
					TransmissionEfficiency = (float) p_Value;
					break;

				case 3691491475:
					BackwardThrottleLimit = (float) p_Value;
					break;

				case 1239657644:
					UseClassicGearBoxAutoClutch = (bool) p_Value;
					break;

				case 3124815010:
					UseNeutralGear = (bool) p_Value;
					break;

				case 3340732019:
					LimitBackwardThrottle = (bool) p_Value;
					break;

				case 3208098444:
					UseAutoClutch = (bool) p_Value;
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
				case 3289089437:
					return ForwardGearRatios;

				case 3306387643:
					return ForwardGearSpeeds;

				case 180205926:
					return ReverseGearRatios;

				case 162915904:
					return ReverseGearSpeeds;

				case 1540232153:
					return GearboxType;

				case 1539978082:
					return GearboxMode;

				case 2688527911:
					return GearChangeTime;

				case 699099436:
					return GearDownSpeedFactor;

				case 3344611765:
					return OppositeDirGearChangeMaxSpeed;

				case 777981235:
					return OppositeDirGearChangeTime;

				case 1429608074:
					return ClutchSpeedFactor;

				case 846717476:
					return TransmissionEfficiency;

				case 3691491475:
					return BackwardThrottleLimit;

				case 1239657644:
					return UseClassicGearBoxAutoClutch;

				case 3124815010:
					return UseNeutralGear;

				case 3340732019:
					return LimitBackwardThrottle;

				case 3208098444:
					return UseAutoClutch;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3289089437:
					return typeof(GearboxConfigData).GetProperty(nameof(ForwardGearRatios));

				case 3306387643:
					return typeof(GearboxConfigData).GetProperty(nameof(ForwardGearSpeeds));

				case 180205926:
					return typeof(GearboxConfigData).GetProperty(nameof(ReverseGearRatios));

				case 162915904:
					return typeof(GearboxConfigData).GetProperty(nameof(ReverseGearSpeeds));

				case 1540232153:
					return typeof(GearboxConfigData).GetProperty(nameof(GearboxType));

				case 1539978082:
					return typeof(GearboxConfigData).GetProperty(nameof(GearboxMode));

				case 2688527911:
					return typeof(GearboxConfigData).GetProperty(nameof(GearChangeTime));

				case 699099436:
					return typeof(GearboxConfigData).GetProperty(nameof(GearDownSpeedFactor));

				case 3344611765:
					return typeof(GearboxConfigData).GetProperty(nameof(OppositeDirGearChangeMaxSpeed));

				case 777981235:
					return typeof(GearboxConfigData).GetProperty(nameof(OppositeDirGearChangeTime));

				case 1429608074:
					return typeof(GearboxConfigData).GetProperty(nameof(ClutchSpeedFactor));

				case 846717476:
					return typeof(GearboxConfigData).GetProperty(nameof(TransmissionEfficiency));

				case 3691491475:
					return typeof(GearboxConfigData).GetProperty(nameof(BackwardThrottleLimit));

				case 1239657644:
					return typeof(GearboxConfigData).GetProperty(nameof(UseClassicGearBoxAutoClutch));

				case 3124815010:
					return typeof(GearboxConfigData).GetProperty(nameof(UseNeutralGear));

				case 3340732019:
					return typeof(GearboxConfigData).GetProperty(nameof(LimitBackwardThrottle));

				case 3208098444:
					return typeof(GearboxConfigData).GetProperty(nameof(UseAutoClutch));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
