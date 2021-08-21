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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class MeshMaterialVariation : 
		DataContainer
	{
		protected SurfaceShaderInstanceDataStruct m_Shader = new SurfaceShaderInstanceDataStruct();
		[ContainerField(Name: "Shader", Offset: 8, NameHash: 3352909900, Flags: 41)]
		public SurfaceShaderInstanceDataStruct Shader { get { return m_Shader; } set { if (OnPropertyChanging("MeshMaterialVariation." + nameof(Shader), this, m_Shader, value)) m_Shader = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3352909900:
					Shader = (SurfaceShaderInstanceDataStruct) p_Value;
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
				case 3352909900:
					return Shader;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3352909900:
					return typeof(MeshMaterialVariation).GetProperty(nameof(Shader));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
