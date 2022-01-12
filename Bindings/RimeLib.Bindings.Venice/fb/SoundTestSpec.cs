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
	[ContainerType(4, 32)]
	public class SoundTestSpec : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable]
		public string Description { get; set; } = string.Empty;

		[ContainerField(16)]
		public CtrRef<SoundTestTask> MainStartTask { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<SoundTestTask> MainStopTask { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Duration { get; set; }

		[ContainerField(28)]
		public RefArray<SoundTestTask> Tasks { get; set; } = new();

	}
}
