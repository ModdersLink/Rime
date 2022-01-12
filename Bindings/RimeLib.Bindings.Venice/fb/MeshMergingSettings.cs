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
	public class MeshMergingSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int StatsSeedIndex { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public int StatsLodIndex { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint TextureAtlasWidth { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool DrawDebugTexturesEnable { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool VirtualTextureArrayStreamingEnable { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool TextureAtlasMergeEnable { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool ClearMergeReport { get; set; }

	}
}
