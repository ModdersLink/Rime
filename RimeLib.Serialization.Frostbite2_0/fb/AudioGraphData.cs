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
	[ContainerType(4, 28)]
	public class AudioGraphData : 
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<AudioGraphNodeData> Nodes { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<AudioGraphParameter> PublicParameters { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<AudioGraphEvent> PublicEvents { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<AudioGraphAssetParameter> PublicAssetParameters { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public ushort PublicValueCount { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		public ushort ValueCount { get; set; }

	}
}
