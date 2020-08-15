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
	[ContainerType(4)]
	public class VehicleInputData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float ThrottleDeadzone { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float BrakeDeadzone { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float YawDeadzone { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float PitchDeadzone { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float RollDeadzone { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ThrottleInertiaOutDuration { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ThrottleInertiaInDuration { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ThrottleInertiaMinRatio { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float BrakeInertiaOutDuration { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float BrakeInertiaInDuration { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float BrakeInertiaMinRatio { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float YawInertiaOutDuration { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float YawInertiaInDuration { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float YawInertiaMinRatio { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float PitchInertiaOutDuration { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float PitchInertiaInDuration { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float PitchInertiaMinRatio { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float RollInertiaOutDuration { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float RollInertiaInDuration { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float RollInertiaMinRatio { get; set; } // 0x4C (76)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3586441143:
					ThrottleDeadzone = (float) p_Value;
					break;

				case 2635895680:
					BrakeDeadzone = (float) p_Value;
					break;

				case 221068432:
					YawDeadzone = (float) p_Value;
					break;

				case 2611479609:
					PitchDeadzone = (float) p_Value;
					break;

				case 3606820258:
					RollDeadzone = (float) p_Value;
					break;

				case 3896636145:
					ThrottleInertiaOutDuration = (float) p_Value;
					break;

				case 4199800312:
					ThrottleInertiaInDuration = (float) p_Value;
					break;

				case 3532696330:
					ThrottleInertiaMinRatio = (float) p_Value;
					break;

				case 2112213382:
					BrakeInertiaOutDuration = (float) p_Value;
					break;

				case 4079208687:
					BrakeInertiaInDuration = (float) p_Value;
					break;

				case 428285341:
					BrakeInertiaMinRatio = (float) p_Value;
					break;

				case 2864738966:
					YawInertiaOutDuration = (float) p_Value;
					break;

				case 2493810687:
					YawInertiaInDuration = (float) p_Value;
					break;

				case 3669874829:
					YawInertiaMinRatio = (float) p_Value;
					break;

				case 3484064127:
					PitchInertiaOutDuration = (float) p_Value;
					break;

				case 1060816822:
					PitchInertiaInDuration = (float) p_Value;
					break;

				case 2659870532:
					PitchInertiaMinRatio = (float) p_Value;
					break;

				case 2073583908:
					RollInertiaOutDuration = (float) p_Value;
					break;

				case 2299067405:
					RollInertiaInDuration = (float) p_Value;
					break;

				case 2058100927:
					RollInertiaMinRatio = (float) p_Value;
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
				case 3586441143:
					return ThrottleDeadzone;

				case 2635895680:
					return BrakeDeadzone;

				case 221068432:
					return YawDeadzone;

				case 2611479609:
					return PitchDeadzone;

				case 3606820258:
					return RollDeadzone;

				case 3896636145:
					return ThrottleInertiaOutDuration;

				case 4199800312:
					return ThrottleInertiaInDuration;

				case 3532696330:
					return ThrottleInertiaMinRatio;

				case 2112213382:
					return BrakeInertiaOutDuration;

				case 4079208687:
					return BrakeInertiaInDuration;

				case 428285341:
					return BrakeInertiaMinRatio;

				case 2864738966:
					return YawInertiaOutDuration;

				case 2493810687:
					return YawInertiaInDuration;

				case 3669874829:
					return YawInertiaMinRatio;

				case 3484064127:
					return PitchInertiaOutDuration;

				case 1060816822:
					return PitchInertiaInDuration;

				case 2659870532:
					return PitchInertiaMinRatio;

				case 2073583908:
					return RollInertiaOutDuration;

				case 2299067405:
					return RollInertiaInDuration;

				case 2058100927:
					return RollInertiaMinRatio;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3586441143:
					return typeof(VehicleInputData).GetProperty(nameof(ThrottleDeadzone));

				case 2635895680:
					return typeof(VehicleInputData).GetProperty(nameof(BrakeDeadzone));

				case 221068432:
					return typeof(VehicleInputData).GetProperty(nameof(YawDeadzone));

				case 2611479609:
					return typeof(VehicleInputData).GetProperty(nameof(PitchDeadzone));

				case 3606820258:
					return typeof(VehicleInputData).GetProperty(nameof(RollDeadzone));

				case 3896636145:
					return typeof(VehicleInputData).GetProperty(nameof(ThrottleInertiaOutDuration));

				case 4199800312:
					return typeof(VehicleInputData).GetProperty(nameof(ThrottleInertiaInDuration));

				case 3532696330:
					return typeof(VehicleInputData).GetProperty(nameof(ThrottleInertiaMinRatio));

				case 2112213382:
					return typeof(VehicleInputData).GetProperty(nameof(BrakeInertiaOutDuration));

				case 4079208687:
					return typeof(VehicleInputData).GetProperty(nameof(BrakeInertiaInDuration));

				case 428285341:
					return typeof(VehicleInputData).GetProperty(nameof(BrakeInertiaMinRatio));

				case 2864738966:
					return typeof(VehicleInputData).GetProperty(nameof(YawInertiaOutDuration));

				case 2493810687:
					return typeof(VehicleInputData).GetProperty(nameof(YawInertiaInDuration));

				case 3669874829:
					return typeof(VehicleInputData).GetProperty(nameof(YawInertiaMinRatio));

				case 3484064127:
					return typeof(VehicleInputData).GetProperty(nameof(PitchInertiaOutDuration));

				case 1060816822:
					return typeof(VehicleInputData).GetProperty(nameof(PitchInertiaInDuration));

				case 2659870532:
					return typeof(VehicleInputData).GetProperty(nameof(PitchInertiaMinRatio));

				case 2073583908:
					return typeof(VehicleInputData).GetProperty(nameof(RollInertiaOutDuration));

				case 2299067405:
					return typeof(VehicleInputData).GetProperty(nameof(RollInertiaInDuration));

				case 2058100927:
					return typeof(VehicleInputData).GetProperty(nameof(RollInertiaMinRatio));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
