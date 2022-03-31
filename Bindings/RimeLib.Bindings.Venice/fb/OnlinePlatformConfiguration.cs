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
	[ContainerType(4, 20)]
	public class OnlinePlatformConfiguration
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public GamePlatform Platform { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public CtrRef<OnlineServicesAsset> Services { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<PresenceBackendData> ClientBackends { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<ServerBackendData> ServerBackends { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool IsFallback { get; set; }
		
	}
}
