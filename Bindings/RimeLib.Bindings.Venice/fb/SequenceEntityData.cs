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
	[ContainerType(4, 52)]
	public class SequenceEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<SequenceEventData> Events { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public int SequenceStartTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int SequenceLength { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; }

		[ContainerField(28)]
		public RefArray<PropertyTrackData> PropertyTracks { get; set; } = new();

		[ContainerField(32)]
		public Realm Realm { get; set; } = new();

		[ContainerField(36)]
		public UpdatePass ServerUpdatePass { get; set; } = new();

		[ContainerField(40)]
		public UpdatePass ClientUpdatePass { get; set; } = new();

		[ContainerField(44)]
		public RefArray<CustomSequenceTrackData> CustomSequenceTracks { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool AutoPlayFirstFrame { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool Looping { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; }

		[ContainerField(51), LayoutImmutable, Blittable]
		public bool PlayInReverse { get; set; }

	}
}
