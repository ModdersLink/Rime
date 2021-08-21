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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class UnlockableShaderParameterValueCollection : 
		DataContainer
	{
		protected string m_ShaderParameterName = string.Empty;
		[ContainerField(Name: "ShaderParameterName", Offset: 8, NameHash: 610960642, Flags: 16509), LayoutImmutable]
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
