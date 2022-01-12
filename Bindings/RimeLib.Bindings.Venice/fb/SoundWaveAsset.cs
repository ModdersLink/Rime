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
	[ContainerType(4, 48)]
	public class SoundWaveAsset : 
		SoundDataAsset
	{
		[ContainerField(20)]
		public RefArray<SoundWaveVariation> Variations { get; set; } = new();

		[ContainerField(24)]
		public List<SoundWaveLocalizationInfo> Localization { get; set; } = new();

		[ContainerField(28)]
		public List<string> SubtitleStringIds { get; set; } = new();

		[ContainerField(32)]
		public SoundWaveVariationSelection Selection { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<StreamPoolAsset> StreamPool { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool Seekable { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable]
		public bool PreferAvailableVariations { get; set; }

		[ContainerField(42), LayoutImmutable, Blittable]
		public sbyte PersistentVariationCount { get; set; }

		[ContainerField(43), LayoutImmutable, Blittable]
		public sbyte ChannelCount { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public sbyte VoicePriority { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public sbyte PrimePriority { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable]
		public sbyte RequestPriority { get; set; }

	}
}
