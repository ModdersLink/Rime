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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class TerrainQuadDecalData : 
		VisualVectorShapeData
	{
		protected Vec4 m_UserMasks = new Vec4();
		[ContainerField(Name: "UserMasks", Offset: 48, NameHash: 1589111411, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UserMasks { get { return m_UserMasks; } set { if (OnPropertyChanging("TerrainQuadDecalData." + nameof(UserMasks), this, m_UserMasks, value)) m_UserMasks = value; } } // 0x30 (48)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader3dZOnly = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(Name: "Shader3dZOnly", Offset: 64, NameHash: 585356309, Flags: 53)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get { return m_Shader3dZOnly; } set { if (OnPropertyChanging("TerrainQuadDecalData." + nameof(Shader3dZOnly), this, m_Shader3dZOnly, value)) m_Shader3dZOnly = value; } } // 0x40 (64)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader2d = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(Name: "Shader2d", Offset: 68, NameHash: 596681178, Flags: 53)]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get { return m_Shader2d; } set { if (OnPropertyChanging("TerrainQuadDecalData." + nameof(Shader2d), this, m_Shader2d, value)) m_Shader2d = value; } } // 0x44 (68)
		
		protected CtrRef<TerrainQuadDecalAtlasTileTemplateData> m_AtlasTileTemplate = new CtrRef<TerrainQuadDecalAtlasTileTemplateData>();
		[ContainerField(Name: "AtlasTileTemplate", Offset: 72, NameHash: 3181192042, Flags: 53)]
		public CtrRef<TerrainQuadDecalAtlasTileTemplateData> AtlasTileTemplate { get { return m_AtlasTileTemplate; } set { if (OnPropertyChanging("TerrainQuadDecalData." + nameof(AtlasTileTemplate), this, m_AtlasTileTemplate, value)) m_AtlasTileTemplate = value; } } // 0x48 (72)
		
		protected TerrainQuadDecalAtlasTile m_AtlasTile = new TerrainQuadDecalAtlasTile();
		[ContainerField(Name: "AtlasTile", Offset: 76, NameHash: 3027817338, Flags: 41)]
		public TerrainQuadDecalAtlasTile AtlasTile { get { return m_AtlasTile; } set { if (OnPropertyChanging("TerrainQuadDecalData." + nameof(AtlasTile), this, m_AtlasTile, value)) m_AtlasTile = value; } } // 0x4C (76)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1589111411:
					UserMasks = (Vec4) p_Value;
					break;

				case 585356309:
					Shader3dZOnly = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 596681178:
					Shader2d = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 3181192042:
					AtlasTileTemplate = (CtrRef<TerrainQuadDecalAtlasTileTemplateData>) p_Value;
					break;

				case 3027817338:
					AtlasTile = (TerrainQuadDecalAtlasTile) p_Value;
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
				case 1589111411:
					return UserMasks;

				case 585356309:
					return Shader3dZOnly;

				case 596681178:
					return Shader2d;

				case 3181192042:
					return AtlasTileTemplate;

				case 3027817338:
					return AtlasTile;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1589111411:
					return typeof(TerrainQuadDecalData).GetProperty(nameof(UserMasks));

				case 585356309:
					return typeof(TerrainQuadDecalData).GetProperty(nameof(Shader3dZOnly));

				case 596681178:
					return typeof(TerrainQuadDecalData).GetProperty(nameof(Shader2d));

				case 3181192042:
					return typeof(TerrainQuadDecalData).GetProperty(nameof(AtlasTileTemplate));

				case 3027817338:
					return typeof(TerrainQuadDecalData).GetProperty(nameof(AtlasTile));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
