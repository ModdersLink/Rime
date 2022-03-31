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
	[ContainerType(4, 36)]
	public class UISettings : 
		SystemSettings
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public UISystemType System { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<UIBundlesAsset> Bundles { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<ProfileOptionsAsset> ProfileOptions { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public LanguageFormat Language { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public DataCopSettings DataCop { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool OneBundlePerGraph { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool DrawEnable { get; set; }

	}
}
