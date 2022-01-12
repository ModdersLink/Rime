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
	[ContainerType(16, 48)]
	public class MaterialPropertyTerrainData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DirtTriggerColor { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<EffectBlueprint> DestructionEffect { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float DirtTriggerFactor { get; set; }

	}
}
