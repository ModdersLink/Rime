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
	[ContainerType(4, 40)]
	public class MeshAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<MeshLodGroup> LodGroup { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float LodScale { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float CullScale { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint NameHash { get; set; }

		[ContainerField(28)]
		public EnlightenType EnlightenType { get; set; } = new();

		[ContainerField(32)]
		public RefArray<MeshMaterial> Materials { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool OccluderHighPriority { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool StreamingEnable { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable]
		public bool DestructionMaterialEnable { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable]
		public bool OccluderMeshEnable { get; set; }

	}
}
