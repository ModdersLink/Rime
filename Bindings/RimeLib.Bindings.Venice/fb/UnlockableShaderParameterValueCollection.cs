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
	[ContainerType(4)]
	public class UnlockableShaderParameterValueCollection : 
		DataContainer
	{
		protected string m_ShaderParameterName = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(610960642)]
		public string ShaderParameterName { get { return m_ShaderParameterName; } set { if (OnPropertyChanging("UnlockableShaderParameterValueCollection." + nameof(ShaderParameterName), this, m_ShaderParameterName, value)) m_ShaderParameterName = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 610960642:
					ShaderParameterName = (string) p_Value;
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
				case 610960642:
					return ShaderParameterName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 610960642:
					return typeof(UnlockableShaderParameterValueCollection).GetProperty(nameof(ShaderParameterName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
