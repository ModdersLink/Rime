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
	public class MatchmakingSizeConfiguration
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public MatchmakingPlatform Platform { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<string> Settings { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint DesiredPlayerCount { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint MinPlayerCount { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint MaxPlayerCapacity { get; set; }
		
		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string MinFitThreshold { get; set; } = string.Empty;
		
	}
}
