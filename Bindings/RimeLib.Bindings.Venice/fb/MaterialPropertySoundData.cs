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
	[ContainerType(4, 32)]
	public class MaterialPropertySoundData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> ImpactSound { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<SoundAsset> ScrapeSound { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float ScrapeLength { get; set; }

		[ContainerField(20)]
		public CtrRef<MaterialSoldierSoundSettings> SoldierSettings { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Softness { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaterialSoundId { get; set; }

	}
}
