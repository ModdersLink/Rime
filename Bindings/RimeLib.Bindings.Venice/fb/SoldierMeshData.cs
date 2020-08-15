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
	[ContainerType(4)]
	public class SoldierMeshData : FrostbiteContainer
	{
		[ContainerField(0)]
		public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new CtrRef<SkinnedMeshAsset>(); // 0x0 (0)
		
		[ContainerField(4)]
		public CtrRef<ObjectBlueprint> MeshBlueprint { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int RandomGroup { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088783990:
					Mesh = (CtrRef<SkinnedMeshAsset>) p_Value;
					break;

				case 1662348825:
					MeshBlueprint = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 1141181985:
					RandomGroup = (int) p_Value;
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

				case 1662348825:
					return MeshBlueprint;

				case 1141181985:
					return RandomGroup;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088783990:
					return typeof(SoldierMeshData).GetProperty(nameof(Mesh));

				case 1662348825:
					return typeof(SoldierMeshData).GetProperty(nameof(MeshBlueprint));

				case 1141181985:
					return typeof(SoldierMeshData).GetProperty(nameof(RandomGroup));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
