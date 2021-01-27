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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 64)]
	public class RoadData : 
		RibbonData
	{
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader2d = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(Name: "Shader2d", Offset: 48, NameHash: 596681178, Flags: 53)]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get { return m_Shader2d; } set { if (OnPropertyChanging("RoadData." + nameof(Shader2d), this, m_Shader2d, value)) m_Shader2d = value; } } // 0x30 (48)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader3dZOnly = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(Name: "Shader3dZOnly", Offset: 52, NameHash: 585356309, Flags: 53)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get { return m_Shader3dZOnly; } set { if (OnPropertyChanging("RoadData." + nameof(Shader3dZOnly), this, m_Shader3dZOnly, value)) m_Shader3dZOnly = value; } } // 0x34 (52)
		
		protected float m_UvTileFactor = new float();
		[ContainerField(Name: "UvTileFactor", Offset: 56, NameHash: 1731623903, Flags: 49469), LayoutImmutable, Blittable]
		public float UvTileFactor { get { return m_UvTileFactor; } set { if (OnPropertyChanging("RoadData." + nameof(UvTileFactor), this, m_UvTileFactor, value)) m_UvTileFactor = value; } } // 0x38 (56)
		
		protected bool m_StickToTerrain = new bool();
		[ContainerField(Name: "StickToTerrain", Offset: 60, NameHash: 633294575, Flags: 49325), LayoutImmutable, Blittable]
		public bool StickToTerrain { get { return m_StickToTerrain; } set { if (OnPropertyChanging("RoadData." + nameof(StickToTerrain), this, m_StickToTerrain, value)) m_StickToTerrain = value; } } // 0x3C (60)
		
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

				case 1731623903:
					UvTileFactor = (float) p_Value;
					break;

				case 633294575:
					StickToTerrain = (bool) p_Value;
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

				case 1731623903:
					return UvTileFactor;

				case 633294575:
					return StickToTerrain;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 596681178:
					return typeof(RoadData).GetProperty(nameof(Shader2d));

				case 585356309:
					return typeof(RoadData).GetProperty(nameof(Shader3dZOnly));

				case 1731623903:
					return typeof(RoadData).GetProperty(nameof(UvTileFactor));

				case 633294575:
					return typeof(RoadData).GetProperty(nameof(StickToTerrain));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
