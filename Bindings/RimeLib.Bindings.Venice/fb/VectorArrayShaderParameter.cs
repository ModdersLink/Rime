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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(12), ContainerStruct]
	public class VectorArrayShaderParameter : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string ParameterName { get; set; } // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(137)]
		public ShaderParameterType ParameterType { get; set; } = new ShaderParameterType(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(65), ContainerArray]
		public List<Vec4> Values { get; set; } = new List<Vec4>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1568946859:
					ParameterName = (string) p_Value;
					break;

				case 1569850964:
						ParameterType = (ShaderParameterType) Enum.ToObject(typeof(ShaderParameterType), p_Value);
					break;

				case 3142410589:
					Values = (List<Vec4>) p_Value;
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
				case 1568946859:
					return ParameterName;

				case 1569850964:
					return ParameterType;

				case 3142410589:
					return Values;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1568946859:
					return typeof(VectorArrayShaderParameter).GetProperty(nameof(ParameterName));

				case 1569850964:
					return typeof(VectorArrayShaderParameter).GetProperty(nameof(ParameterType));

				case 3142410589:
					return typeof(VectorArrayShaderParameter).GetProperty(nameof(Values));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
