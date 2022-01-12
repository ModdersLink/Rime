///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class MeshVariationDatabaseEntry : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint VariationAssetNameHash { get; set; }

		[ContainerField(16)]
		public List<MeshVariationDatabaseMaterial> Materials { get; set; } = new();

	}
}
