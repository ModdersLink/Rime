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
	[ContainerType(4, 72)]
	public class DecalTemplateData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Size { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float RandomSize { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Rotation { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float RandomRotation { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float ClipAngle { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ProximityRadiusFactor { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float NormalOffset { get; set; }

		[ContainerField(40)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public int MeshUVIndex { get; set; }

		[ContainerField(48)]
		public DecalAtlasTile AtlasTile { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable]
		public sbyte SortingPriority { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable]
		public bool Projected { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable]
		public bool ProjectMultiple { get; set; }

		[ContainerField(71), LayoutImmutable, Blittable]
		public sbyte MaterialIndex { get; set; }

	}
}
