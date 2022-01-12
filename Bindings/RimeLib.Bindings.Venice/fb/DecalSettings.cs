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
	public class DecalSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint StaticBufferMaxVertexCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint RingBufferMaxVertexCount { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool DrawEnable { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool SystemEnable2 { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool SystemEnable { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool DebugMemUsageEnable { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool DebugWarningsEnable { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable]
		public bool NvidiaStreamOutputWorkaroundEnable { get; set; }

	}
}
