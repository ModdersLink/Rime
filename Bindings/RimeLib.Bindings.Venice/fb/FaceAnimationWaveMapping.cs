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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class FaceAnimationWaveMapping : FrostbiteContainer
	{
		[ContainerField(Name: "WaveNameHash", Offset: 0, NameHash: 1305133845, Flags: 49405), LayoutImmutable, Blittable]
		public int WaveNameHash { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "AntEnumValue", Offset: 4, NameHash: 3039218790, Flags: 49405), LayoutImmutable, Blittable]
		public int AntEnumValue { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1305133845:
					WaveNameHash = (int) p_Value;
					break;

				case 3039218790:
					AntEnumValue = (int) p_Value;
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
				case 1305133845:
					return WaveNameHash;

				case 3039218790:
					return AntEnumValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1305133845:
					return typeof(FaceAnimationWaveMapping).GetProperty(nameof(WaveNameHash));

				case 3039218790:
					return typeof(FaceAnimationWaveMapping).GetProperty(nameof(AntEnumValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
