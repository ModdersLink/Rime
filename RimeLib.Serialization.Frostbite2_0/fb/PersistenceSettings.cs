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
	public class PersistenceSettings : 
		SystemSettings
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<StatCategoryTreeCollection> StatCategoryTreeCollection { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<PlayerTypeProfile> MPProfile { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<PlayerTypeProfile> SPProfile { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<PlayerTypeProfile> CoopProfile { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<PointSystemParamsAsset> PointSystemParams { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<LicenseConfiguration> LicenseConfig { get; set; } = new();

	}
}
