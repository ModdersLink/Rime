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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(52), ContainerClass]
	public class TerrainFillDecalData : 
		VisualVectorShapeData
	{
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader2d = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(44), MemberInfoFlag(53), ContainerFieldNameHash(596681178), ContainerCtrRef]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get { return m_Shader2d; } set { if (OnPropertyChanging("TerrainFillDecalData." + nameof(Shader2d), this, m_Shader2d, value)) m_Shader2d = value; } } // 0x2C (44)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader3dZOnly = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(48), MemberInfoFlag(53), ContainerFieldNameHash(585356309), ContainerCtrRef]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get { return m_Shader3dZOnly; } set { if (OnPropertyChanging("TerrainFillDecalData." + nameof(Shader3dZOnly), this, m_Shader3dZOnly, value)) m_Shader3dZOnly = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 596681178:
					Shader2d = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 585356309:
					Shader3dZOnly = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
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
				case 596681178:
					return Shader2d;

				case 585356309:
					return Shader3dZOnly;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 596681178:
					return typeof(TerrainFillDecalData).GetProperty(nameof(Shader2d));

				case 585356309:
					return typeof(TerrainFillDecalData).GetProperty(nameof(Shader3dZOnly));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
