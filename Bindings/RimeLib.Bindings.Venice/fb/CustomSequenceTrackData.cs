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
	[ContainerType(4, 40)]
	public class CustomSequenceTrackData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string TrackName { get; set; } = string.Empty;

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<CustomSequenceTrackLinkMapping> InputLinkMap { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<CustomSequenceTrackLinkMapping> OutputLinkMap { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<CustomSequenceTrackEventMapping> EventMap { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public RefArray<CustomSequenceTrackPropertyMapping> SourcePropertyMap { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public RefArray<CustomSequenceTrackPropertyMapping> TargetPropertyMap { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public RefArray<CustomSequenceTrackPropertyMapping> SourceAndTargetPropertyMap { get; set; } = new();

	}
}
