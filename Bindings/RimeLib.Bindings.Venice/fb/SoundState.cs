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
	[ContainerType(4, 44)]
	public class SoundState : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable]
		public float LpCutoffFrequency { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float Duration { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FadeInTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float FadeOutTime { get; set; }

		[ContainerField(28)]
		public CtrRef<SoundAsset> BypassSound { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<HdrSetting> HdrSetting { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<MixerAsset> Mixer { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool FadeSound { get; set; }

	}
}
