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
	public class ShaderParameterVector : FrostbiteContainer
	{
		[ContainerField(Name: "Value", Offset: 0, NameHash: 225375086, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Value { get; set; } = new Vec4(); // 0x0 (0)
		
		[ContainerField(Name: "ParameterName", Offset: 16, NameHash: 1568946859, Flags: 16509), LayoutImmutable]
		public string ParameterName { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (Vec4) p_Value;
					break;

				case 1568946859:
					ParameterName = (string) p_Value;
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
				case 225375086:
					return Value;

				case 1568946859:
					return ParameterName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return typeof(ShaderParameterVector).GetProperty(nameof(Value));

				case 1568946859:
					return typeof(ShaderParameterVector).GetProperty(nameof(ParameterName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
