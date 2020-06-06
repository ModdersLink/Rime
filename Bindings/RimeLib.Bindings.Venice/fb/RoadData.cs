///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class RoadData : 
		RibbonData
	{
		[ContainerField(48)]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x30 (48)
		
		[ContainerField(52)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float UvTileFactor { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool StickToTerrain { get; set; } // 0x3C (60)
		
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
