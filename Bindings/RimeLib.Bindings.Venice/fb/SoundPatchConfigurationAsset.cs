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
	[ContainerType(4, 28)]
	public class SoundPatchConfigurationAsset : 
		SoundAsset
	{
		[ContainerField(16)]
		public CtrRef<SoundPatchAsset> Sound { get; set; } = new();

		[ContainerField(20)]
		public RefArray<SoundPatchConfigurationEntry> Entries { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Loudness { get; set; }

	}
}
