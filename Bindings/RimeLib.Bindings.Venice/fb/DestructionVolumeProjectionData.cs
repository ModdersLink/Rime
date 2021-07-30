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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 32)]
	public class DestructionVolumeProjectionData : FrostbiteContainer
	{
		[ContainerField(Name: "Normal", Offset: 0, NameHash: 2827188502, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Normal { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "TangentAngle", Offset: 16, NameHash: 3748635431, Flags: 49469), LayoutImmutable, Blittable]
		public float TangentAngle { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2827188502:
					Normal = (Vec3) p_Value;
					break;

				case 3748635431:
					TangentAngle = (float) p_Value;
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
				case 2827188502:
					return Normal;

				case 3748635431:
					return TangentAngle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2827188502:
					return typeof(DestructionVolumeProjectionData).GetProperty(nameof(Normal));

				case 3748635431:
					return typeof(DestructionVolumeProjectionData).GetProperty(nameof(TangentAngle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
