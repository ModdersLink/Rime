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
	public class ShaderParameterComponentData : 
		ComponentData
	{
		protected List<ShaderParameterVector> m_ShaderParameterVectors = new List<ShaderParameterVector>();
		[ContainerField(96), ContainerFieldNameHash(2124466895)]
		public List<ShaderParameterVector> ShaderParameterVectors { get { return m_ShaderParameterVectors; } set { if (OnPropertyChanging("ShaderParameterComponentData." + nameof(ShaderParameterVectors), this, m_ShaderParameterVectors, value)) m_ShaderParameterVectors = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2124466895:
					ShaderParameterVectors = (List<ShaderParameterVector>) p_Value;
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
				case 2124466895:
					return ShaderParameterVectors;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2124466895:
					return typeof(ShaderParameterComponentData).GetProperty(nameof(ShaderParameterVectors));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
