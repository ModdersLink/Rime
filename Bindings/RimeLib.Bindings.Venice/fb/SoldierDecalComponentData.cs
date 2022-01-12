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
	public class SoldierDecalComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<DecalTemplateData> SplashDecal { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float SplashRayLength { get; set; }

		[ContainerField(104)]
		public CtrRef<DecalTemplateData> PoolDecal { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float PoolRayYOffset { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float PoolRayLength { get; set; }

	}
}
