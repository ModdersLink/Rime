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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class EloExpectedFunctionPoint : FrostbiteContainer
	{
		[ContainerField(Name: "XValue", Offset: 0, NameHash: 3631738966, Flags: 49469), LayoutImmutable, Blittable]
		public float XValue { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "YValue", Offset: 4, NameHash: 3436064183, Flags: 49469), LayoutImmutable, Blittable]
		public float YValue { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3631738966:
					XValue = (float) p_Value;
					break;

				case 3436064183:
					YValue = (float) p_Value;
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
				case 3631738966:
					return XValue;

				case 3436064183:
					return YValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3631738966:
					return typeof(EloExpectedFunctionPoint).GetProperty(nameof(XValue));

				case 3436064183:
					return typeof(EloExpectedFunctionPoint).GetProperty(nameof(YValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
