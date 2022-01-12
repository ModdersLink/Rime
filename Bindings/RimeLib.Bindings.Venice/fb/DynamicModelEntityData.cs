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
	[ContainerType(16, 128)]
	public class DynamicModelEntityData : 
		DynamicGamePhysicsEntityData
	{
		[ContainerField(112)]
		public CtrRef<PartComponentData> Part { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public bool NoCollision { get; set; }

	}
}
