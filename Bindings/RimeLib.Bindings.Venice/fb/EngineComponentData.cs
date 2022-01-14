///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class EngineComponentData : 
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<EngineConfigData> Config { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public CtrRef<SoundAsset> SoundEffect { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<SoundAsset> SurfaceSoundEffect { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool UseFirstPersonSounds { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool OutputIsEngineInWater { get; set; }

	}
}
