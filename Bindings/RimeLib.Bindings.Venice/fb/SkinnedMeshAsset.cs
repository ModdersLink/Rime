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
	[ContainerType(16, 80)]
	public class SkinnedMeshAsset : 
		MeshAsset
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BoundingBoxPositionOffset { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BoundingBoxSizeOffset { get; set; } = new();

	}
}
