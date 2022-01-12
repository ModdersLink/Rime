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
	[ContainerType(16, 208)]
	public class GrenadeEntityData : 
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable]
		public float CollisionSpeedMultiplier { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float Gravity { get; set; }

		[ContainerField(200)]
		public GrenadeType GrenadeType { get; set; } = new();

		[ContainerField(204), LayoutImmutable, Blittable]
		public float MinBounceSpeed { get; set; }

	}
}
