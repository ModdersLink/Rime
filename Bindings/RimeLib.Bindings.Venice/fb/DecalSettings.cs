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
	public class DecalSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint StaticBufferMaxVertexCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint RingBufferMaxVertexCount { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool DrawEnable { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		public bool SystemEnable2 { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		public bool SystemEnable { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable, JsonProperty(Order = 23)]
		public bool Enable { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool DebugMemUsageEnable { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		public bool DebugWarningsEnable { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		public bool NvidiaStreamOutputWorkaroundEnable { get; set; }

	}
}
