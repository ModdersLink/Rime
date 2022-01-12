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
	[ContainerType(4, 28)]
	public class AntTrackItemData : 
		DataContainer
	{
		[ContainerField(8)]
		public AntRef Controller { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public int SequenceTrackIndex { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int StartTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint NumTicks { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool ResumeAtEnd { get; set; }

	}
}
