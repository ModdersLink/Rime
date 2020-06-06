///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class VegetationBaseEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<LinearTransform> BasePoseTransforms { get; set; } = new List<LinearTransform>(); // 0x60 (96)
		
		[ContainerField(100)]
		public List<Vec3> BasePoseTranslations { get; set; } = new List<Vec3>(); // 0x64 (100)
		
		[ContainerField(104)]
		public List<int> Hierarchy { get; set; } = new List<int>(); // 0x68 (104)
		
		[ContainerField(108)]
		public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new CtrRef<SkinnedMeshAsset>(); // 0x6C (108)
		
		[ContainerField(112)]
		public CtrRef<SkinnedMeshAsset> ShadowMesh { get; set; } = new CtrRef<SkinnedMeshAsset>(); // 0x70 (112)
		
		[ContainerField(116)]
		public CtrRef<PhysicsEntityData> PhysicsData { get; set; } = new CtrRef<PhysicsEntityData>(); // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2949884966:
					BasePoseTransforms = (List<LinearTransform>) p_Value;
					break;

				case 3010608801:
					BasePoseTranslations = (List<Vec3>) p_Value;
					break;

				case 2981249554:
					Hierarchy = (List<int>) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<SkinnedMeshAsset>) p_Value;
					break;

				case 699932784:
					ShadowMesh = (CtrRef<SkinnedMeshAsset>) p_Value;
					break;

				case 1743842718:
					PhysicsData = (CtrRef<PhysicsEntityData>) p_Value;
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
				case 2949884966:
					return BasePoseTransforms;

				case 3010608801:
					return BasePoseTranslations;

				case 2981249554:
					return Hierarchy;

				case 2088783990:
					return Mesh;

				case 699932784:
					return ShadowMesh;

				case 1743842718:
					return PhysicsData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2949884966:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(BasePoseTransforms));

				case 3010608801:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(BasePoseTranslations));

				case 2981249554:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(Hierarchy));

				case 2088783990:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(Mesh));

				case 699932784:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(ShadowMesh));

				case 1743842718:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(PhysicsData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
