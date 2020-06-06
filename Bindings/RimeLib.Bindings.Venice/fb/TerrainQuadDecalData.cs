///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class TerrainQuadDecalData : 
		VisualVectorShapeData
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UserMasks { get; set; } = new Vec4(); // 0x30 (48)
		
		[ContainerField(64)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x40 (64)
		
		[ContainerField(68)]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x44 (68)
		
		[ContainerField(72)]
		public CtrRef<TerrainQuadDecalAtlasTileTemplateData> AtlasTileTemplate { get; set; } = new CtrRef<TerrainQuadDecalAtlasTileTemplateData>(); // 0x48 (72)
		
		[ContainerField(76)]
		public TerrainQuadDecalAtlasTile AtlasTile { get; set; } = new TerrainQuadDecalAtlasTile(); // 0x4C (76)
		
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
