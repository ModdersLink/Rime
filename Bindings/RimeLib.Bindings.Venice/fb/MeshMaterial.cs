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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class MeshMaterial : 
		DataContainer
	{
		protected CtrRef<SurfaceShaderInstanceData> m_ShaderInstance = new CtrRef<SurfaceShaderInstanceData>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(963778021), ContainerCtrRef]
		public CtrRef<SurfaceShaderInstanceData> ShaderInstance { get { return m_ShaderInstance; } set { if (OnPropertyChanging("MeshMaterial." + nameof(ShaderInstance), this, m_ShaderInstance, value)) m_ShaderInstance = value; } } // 0x8 (8)
		
		protected SurfaceShaderInstanceDataStruct m_Shader = new SurfaceShaderInstanceDataStruct();
		[ContainerField(12), MemberInfoFlag(41), ContainerFieldNameHash(3352909900)]
		public SurfaceShaderInstanceDataStruct Shader { get { return m_Shader; } set { if (OnPropertyChanging("MeshMaterial." + nameof(Shader), this, m_Shader, value)) m_Shader = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 963778021:
					ShaderInstance = (CtrRef<SurfaceShaderInstanceData>) p_Value;
					break;

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
				case 963778021:
					return ShaderInstance;

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
				case 963778021:
					return typeof(MeshMaterial).GetProperty(nameof(ShaderInstance));

				case 3352909900:
					return typeof(MeshMaterial).GetProperty(nameof(Shader));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
