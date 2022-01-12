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
	public class SoldierFootplantEffectComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<MaterialContainerPair> FootMaterialPair { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float HeightOverGroundThreshold { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float FootVelocityThreshold { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float LodDistance { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public bool FullFootplantingEnabled { get; set; }

	}
}
