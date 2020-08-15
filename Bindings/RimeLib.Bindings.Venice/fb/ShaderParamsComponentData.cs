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
	[ContainerType(16)]
	public class ShaderParamsComponentData : 
		ComponentData
	{
		protected Vec4 m_Value = new Vec4();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(225375086)]
		public Vec4 Value { get { return m_Value; } set { if (OnPropertyChanging("ShaderParamsComponentData." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x60 (96)
		
		protected string m_ParameterName = new string();
		[ContainerField(112), LayoutImmutable, ContainerFieldNameHash(1568946859)]
		public string ParameterName { get { return m_ParameterName; } set { if (OnPropertyChanging("ShaderParamsComponentData." + nameof(ParameterName), this, m_ParameterName, value)) m_ParameterName = value; } } // 0x70 (112)
		
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
					return typeof(ShaderParamsComponentData).GetProperty(nameof(Value));

				case 1568946859:
					return typeof(ShaderParamsComponentData).GetProperty(nameof(ParameterName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
