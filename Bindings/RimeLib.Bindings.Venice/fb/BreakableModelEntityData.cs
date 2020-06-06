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
	public class BreakableModelEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public CtrRef<SurfaceShaderBaseAsset> DecalVolumeShader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float DecalVolumeScaleFactor { get; set; } // 0x74 (116)
		
		[ContainerField(120)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public uint BoneCount { get; set; } // 0x7C (124)
		
		[ContainerField(128)]
		public CtrRef<EdgeModelLightMapData> EdgeModelLightMapData { get; set; } = new CtrRef<EdgeModelLightMapData>(); // 0x80 (128)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1251902379:
					DecalVolumeShader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 3086740471:
					DecalVolumeScaleFactor = (float) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 939250912:
					BoneCount = (uint) p_Value;
					break;

				case 863288475:
					EdgeModelLightMapData = (CtrRef<EdgeModelLightMapData>) p_Value;
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
				case 1251902379:
					return DecalVolumeShader;

				case 3086740471:
					return DecalVolumeScaleFactor;

				case 2088783990:
					return Mesh;

				case 939250912:
					return BoneCount;

				case 863288475:
					return EdgeModelLightMapData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1251902379:
					return typeof(BreakableModelEntityData).GetProperty(nameof(DecalVolumeShader));

				case 3086740471:
					return typeof(BreakableModelEntityData).GetProperty(nameof(DecalVolumeScaleFactor));

				case 2088783990:
					return typeof(BreakableModelEntityData).GetProperty(nameof(Mesh));

				case 939250912:
					return typeof(BreakableModelEntityData).GetProperty(nameof(BoneCount));

				case 863288475:
					return typeof(BreakableModelEntityData).GetProperty(nameof(EdgeModelLightMapData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
