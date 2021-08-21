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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 80)]
	public class VehicleInputData : FrostbiteContainer
	{
		[ContainerField(Name: "ThrottleDeadzone", Offset: 0, NameHash: 3586441143, Flags: 49469), LayoutImmutable, Blittable]
		public float ThrottleDeadzone { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "BrakeDeadzone", Offset: 4, NameHash: 2635895680, Flags: 49469), LayoutImmutable, Blittable]
		public float BrakeDeadzone { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "YawDeadzone", Offset: 8, NameHash: 221068432, Flags: 49469), LayoutImmutable, Blittable]
		public float YawDeadzone { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "PitchDeadzone", Offset: 12, NameHash: 2611479609, Flags: 49469), LayoutImmutable, Blittable]
		public float PitchDeadzone { get; set; } // 0xC (12)
		
		[ContainerField(Name: "RollDeadzone", Offset: 16, NameHash: 3606820258, Flags: 49469), LayoutImmutable, Blittable]
		public float RollDeadzone { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "ThrottleInertiaOutDuration", Offset: 20, NameHash: 3896636145, Flags: 49469), LayoutImmutable, Blittable]
		public float ThrottleInertiaOutDuration { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "ThrottleInertiaInDuration", Offset: 24, NameHash: 4199800312, Flags: 49469), LayoutImmutable, Blittable]
		public float ThrottleInertiaInDuration { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "ThrottleInertiaMinRatio", Offset: 28, NameHash: 3532696330, Flags: 49469), LayoutImmutable, Blittable]
		public float ThrottleInertiaMinRatio { get; set; } // 0x1C (28)
		
		[ContainerField(Name: "BrakeInertiaOutDuration", Offset: 32, NameHash: 2112213382, Flags: 49469), LayoutImmutable, Blittable]
		public float BrakeInertiaOutDuration { get; set; } // 0x20 (32)
		
		[ContainerField(Name: "BrakeInertiaInDuration", Offset: 36, NameHash: 4079208687, Flags: 49469), LayoutImmutable, Blittable]
		public float BrakeInertiaInDuration { get; set; } // 0x24 (36)
		
		[ContainerField(Name: "BrakeInertiaMinRatio", Offset: 40, NameHash: 428285341, Flags: 49469), LayoutImmutable, Blittable]
		public float BrakeInertiaMinRatio { get; set; } // 0x28 (40)
		
		[ContainerField(Name: "YawInertiaOutDuration", Offset: 44, NameHash: 2864738966, Flags: 49469), LayoutImmutable, Blittable]
		public float YawInertiaOutDuration { get; set; } // 0x2C (44)
		
		[ContainerField(Name: "YawInertiaInDuration", Offset: 48, NameHash: 2493810687, Flags: 49469), LayoutImmutable, Blittable]
		public float YawInertiaInDuration { get; set; } // 0x30 (48)
		
		[ContainerField(Name: "YawInertiaMinRatio", Offset: 52, NameHash: 3669874829, Flags: 49469), LayoutImmutable, Blittable]
		public float YawInertiaMinRatio { get; set; } // 0x34 (52)
		
		[ContainerField(Name: "PitchInertiaOutDuration", Offset: 56, NameHash: 3484064127, Flags: 49469), LayoutImmutable, Blittable]
		public float PitchInertiaOutDuration { get; set; } // 0x38 (56)
		
		[ContainerField(Name: "PitchInertiaInDuration", Offset: 60, NameHash: 1060816822, Flags: 49469), LayoutImmutable, Blittable]
		public float PitchInertiaInDuration { get; set; } // 0x3C (60)
		
		[ContainerField(Name: "PitchInertiaMinRatio", Offset: 64, NameHash: 2659870532, Flags: 49469), LayoutImmutable, Blittable]
		public float PitchInertiaMinRatio { get; set; } // 0x40 (64)
		
		[ContainerField(Name: "RollInertiaOutDuration", Offset: 68, NameHash: 2073583908, Flags: 49469), LayoutImmutable, Blittable]
		public float RollInertiaOutDuration { get; set; } // 0x44 (68)
		
		[ContainerField(Name: "RollInertiaInDuration", Offset: 72, NameHash: 2299067405, Flags: 49469), LayoutImmutable, Blittable]
		public float RollInertiaInDuration { get; set; } // 0x48 (72)
		
		[ContainerField(Name: "RollInertiaMinRatio", Offset: 76, NameHash: 2058100927, Flags: 49469), LayoutImmutable, Blittable]
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
