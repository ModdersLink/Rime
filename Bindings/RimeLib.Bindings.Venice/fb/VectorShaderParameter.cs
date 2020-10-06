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
	[ContainerType(16), MemberInfoFlag(41), ContainerSize(32), ContainerStruct]
	public class VectorShaderParameter : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec4 Value { get; set; } = new Vec4(); // 0x0 (0)
		
		[ContainerField(16), MemberInfoFlag(137)]
		public ShaderParameterType ParameterType { get; set; } = new ShaderParameterType(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509)]
		public string ParameterName { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (Vec4) p_Value;
					break;

				case 1569850964:
						ParameterType = (ShaderParameterType) Enum.ToObject(typeof(ShaderParameterType), p_Value);
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

				case 1569850964:
					return ParameterType;

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
					return typeof(VectorShaderParameter).GetProperty(nameof(Value));

				case 1569850964:
					return typeof(VectorShaderParameter).GetProperty(nameof(ParameterType));

				case 1568946859:
					return typeof(VectorShaderParameter).GetProperty(nameof(ParameterName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
