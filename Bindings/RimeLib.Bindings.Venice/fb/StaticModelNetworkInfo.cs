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
	[ContainerType(4, 16)]
	public class StaticModelNetworkInfo
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<IndexRange> PartNetworkIdRanges { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public uint NetworkIdCount { get; set; }
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<ChildStaticModelNetworkInfo> ChildNetworkInfos { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint ChildNetworkIdCount { get; set; }
		
	}
}
