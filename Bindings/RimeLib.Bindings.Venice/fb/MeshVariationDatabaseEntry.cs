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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class MeshVariationDatabaseEntry : 
		DataContainer
	{
		protected CtrRef<MeshAsset> m_Mesh = new CtrRef<MeshAsset>();
		[ContainerField(Name: "Mesh", Offset: 8, NameHash: 2088783990, Flags: 53)]
		public CtrRef<MeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("MeshVariationDatabaseEntry." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x8 (8)
		
		protected uint m_VariationAssetNameHash = new uint();
		[ContainerField(Name: "VariationAssetNameHash", Offset: 12, NameHash: 442217361, Flags: 49421), LayoutImmutable, Blittable]
		public uint VariationAssetNameHash { get { return m_VariationAssetNameHash; } set { if (OnPropertyChanging("MeshVariationDatabaseEntry." + nameof(VariationAssetNameHash), this, m_VariationAssetNameHash, value)) m_VariationAssetNameHash = value; } } // 0xC (12)
		
		protected List<MeshVariationDatabaseMaterial> m_Materials = new List<MeshVariationDatabaseMaterial>();
		[ContainerField(Name: "Materials", Offset: 16, NameHash: 2136313565, Flags: 65)]
		public List<MeshVariationDatabaseMaterial> Materials { get { return m_Materials; } set { if (OnPropertyChanging("MeshVariationDatabaseEntry." + nameof(Materials), this, m_Materials, value)) m_Materials = value; } } // 0x10 (16)
		
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
