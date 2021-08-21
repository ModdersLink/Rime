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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 32)]
	public class PitchModifier : FrostbiteContainer
	{
		[ContainerField(Name: "Offset", Offset: 0, NameHash: 2871410728, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "PitchVal", Offset: 16, NameHash: 1095283832, Flags: 49469), LayoutImmutable, Blittable]
		public float PitchVal { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "PitchAngle", Offset: 20, NameHash: 3042696834, Flags: 49469), LayoutImmutable, Blittable]
		public float PitchAngle { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2871410728:
					Offset = (Vec3) p_Value;
					break;

				case 1095283832:
					PitchVal = (float) p_Value;
					break;

				case 3042696834:
					PitchAngle = (float) p_Value;
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
				case 2871410728:
					return Offset;

				case 1095283832:
					return PitchVal;

				case 3042696834:
					return PitchAngle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2871410728:
					return typeof(PitchModifier).GetProperty(nameof(Offset));

				case 1095283832:
					return typeof(PitchModifier).GetProperty(nameof(PitchVal));

				case 3042696834:
					return typeof(PitchModifier).GetProperty(nameof(PitchAngle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
