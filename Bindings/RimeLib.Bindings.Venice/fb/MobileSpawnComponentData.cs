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
	public class MobileSpawnComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ParachuteSpawnRadiusMin { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float ParachuteSpawnDistance { get; set; }

		[ContainerField(104), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable]
		public float ParachuteSpawnRadiusMax { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public bool EnterMobileSpawnPoint { get; set; }

	}
}
