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
	[ContainerType(4, 52)]
	public class SequenceEntityData : 
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<SequenceEventData> Events { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int SequenceStartTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public int SequenceLength { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float ExternalTime { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public RefArray<PropertyTrackData> PropertyTracks { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public Realm Realm { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public UpdatePass ServerUpdatePass { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public UpdatePass ClientUpdatePass { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public RefArray<CustomSequenceTrackData> CustomSequenceTracks { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public bool AutoPlayFirstFrame { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		public bool Looping { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		public bool AutoStart { get; set; }

		[ContainerField(51), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
		public bool PlayInReverse { get; set; }

	}
}
