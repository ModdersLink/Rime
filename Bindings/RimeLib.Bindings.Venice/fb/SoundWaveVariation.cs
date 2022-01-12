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
	[ContainerType(4, 24)]
	public class SoundWaveVariation : 
		DataContainer
	{
		[ContainerField(8)]
		public List<SoundWaveSubtitle> Subtitles { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint SeekTablesSize { get; set; }

		[ContainerField(16)]
		public List<SoundWaveVariationSegment> Segments { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public sbyte ChunkIndex { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public sbyte FirstLoopSegmentIndex { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public sbyte LastLoopSegmentIndex { get; set; }

	}
}
