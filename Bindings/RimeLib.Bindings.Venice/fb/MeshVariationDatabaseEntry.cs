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
    [ContainerType(4)]
	public class MeshVariationDatabaseEntry : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint VariationAssetNameHash { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<MeshVariationDatabaseMaterial> Materials { get; set; } = new List<MeshVariationDatabaseMaterial>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 442217361:
					VariationAssetNameHash = (uint) p_Value;
					break;

				case 2136313565:
					Materials = (List<MeshVariationDatabaseMaterial>) p_Value;
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
				case 2088783990:
					return Mesh;

				case 442217361:
					return VariationAssetNameHash;

				case 2136313565:
					return Materials;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088783990:
					return typeof(MeshVariationDatabaseEntry).GetProperty(nameof(Mesh));

				case 442217361:
					return typeof(MeshVariationDatabaseEntry).GetProperty(nameof(VariationAssetNameHash));

				case 2136313565:
					return typeof(MeshVariationDatabaseEntry).GetProperty(nameof(Materials));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
