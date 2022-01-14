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
	[ContainerType(4, 40)]
	public class EnlightenDataAsset : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<TextureAsset> DebugBackFaceTexture { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int MaxResolutionY { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<TextureAsset> DebugChartTexture { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<TextureAsset> SkyVisibilityTexture { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float VisibilityThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public int MaxResolutionX { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool LoadDebugData { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool DynamicEnable { get; set; }

	}
}
