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
	[ContainerType(4, 48)]
	public class SoundWaveAsset : 
		SoundDataAsset
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<SoundWaveVariation> Variations { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<SoundWaveLocalizationInfo> Localization { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public List<string> SubtitleStringIds { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public SoundWaveVariationSelection Selection { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<StreamPoolAsset> StreamPool { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool Seekable { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		public bool PreferAvailableVariations { get; set; }

		[ContainerField(42), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
		public sbyte PersistentVariationCount { get; set; }

		[ContainerField(43), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
		public sbyte ChannelCount { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public sbyte VoicePriority { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public sbyte PrimePriority { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		public sbyte RequestPriority { get; set; }

	}
}
