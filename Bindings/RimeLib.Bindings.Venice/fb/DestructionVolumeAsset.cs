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
	[ContainerType(4, 24)]
	public class DestructionVolumeAsset : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<TextureAsset> DiffuseAtlas { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<TextureAsset> NormalmapAtlas { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float AtlasTextureScale { get; set; }

	}
}
