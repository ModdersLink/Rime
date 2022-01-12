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
	[ContainerType(16, 192)]
	public class MeshProjectileEntityData : 
		ProjectileEntityData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialAngularVelocity { get; set; } = new();

		[ContainerField(176)]
		public CtrRef<EffectBlueprint> TrailEffect { get; set; } = new();

		[ContainerField(180)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(184), LayoutImmutable, Blittable]
		public float MaxAttachableInclination { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public bool ExtraDamping { get; set; }

		[ContainerField(189), LayoutImmutable, Blittable]
		public bool IsAttachable { get; set; }

	}
}
