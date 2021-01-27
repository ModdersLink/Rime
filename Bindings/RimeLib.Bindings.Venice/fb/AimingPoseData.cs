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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class AimingPoseData : FrostbiteContainer
	{
		[ContainerField(Name: "MinimumPitch", Offset: 0, NameHash: 4284033781, Flags: 49469), LayoutImmutable, Blittable]
		public float MinimumPitch { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "MaximumPitch", Offset: 4, NameHash: 1925433387, Flags: 49469), LayoutImmutable, Blittable]
		public float MaximumPitch { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "TargetingFov", Offset: 8, NameHash: 3029109579, Flags: 49469), LayoutImmutable, Blittable]
		public float TargetingFov { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "AimSteadiness", Offset: 12, NameHash: 3173957957, Flags: 49469), LayoutImmutable, Blittable]
		public float AimSteadiness { get; set; } // 0xC (12)
		
		[ContainerField(Name: "SpeedMultiplier", Offset: 16, NameHash: 1688256841, Flags: 49469), LayoutImmutable, Blittable]
		public float SpeedMultiplier { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "RecoilMultiplier", Offset: 20, NameHash: 2433005616, Flags: 49469), LayoutImmutable, Blittable]
		public float RecoilMultiplier { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4284033781:
					MinimumPitch = (float) p_Value;
					break;

				case 1925433387:
					MaximumPitch = (float) p_Value;
					break;

				case 3029109579:
					TargetingFov = (float) p_Value;
					break;

				case 3173957957:
					AimSteadiness = (float) p_Value;
					break;

				case 1688256841:
					SpeedMultiplier = (float) p_Value;
					break;

				case 2433005616:
					RecoilMultiplier = (float) p_Value;
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
				case 4284033781:
					return MinimumPitch;

				case 1925433387:
					return MaximumPitch;

				case 3029109579:
					return TargetingFov;

				case 3173957957:
					return AimSteadiness;

				case 1688256841:
					return SpeedMultiplier;

				case 2433005616:
					return RecoilMultiplier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4284033781:
					return typeof(AimingPoseData).GetProperty(nameof(MinimumPitch));

				case 1925433387:
					return typeof(AimingPoseData).GetProperty(nameof(MaximumPitch));

				case 3029109579:
					return typeof(AimingPoseData).GetProperty(nameof(TargetingFov));

				case 3173957957:
					return typeof(AimingPoseData).GetProperty(nameof(AimSteadiness));

				case 1688256841:
					return typeof(AimingPoseData).GetProperty(nameof(SpeedMultiplier));

				case 2433005616:
					return typeof(AimingPoseData).GetProperty(nameof(RecoilMultiplier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
