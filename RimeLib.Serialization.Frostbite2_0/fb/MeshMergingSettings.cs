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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 28)]
	public class MeshMergingSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public int StatsSeedIndex { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public int StatsLodIndex { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint TextureAtlasWidth { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool DrawStatsEnable { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		public bool DrawDebugTexturesEnable { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		public bool VirtualTextureArrayStreamingEnable { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable, JsonProperty(Order = 23)]
		public bool Enable { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool TextureAtlasMergeEnable { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		public bool ClearMergeReport { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StatsSeedIndex);
			p_Writer.Write(StatsLodIndex);
			p_Writer.Write(TextureAtlasWidth);
			p_Writer.Write(DrawStatsEnable);
			p_Writer.Write(DrawDebugTexturesEnable);
			p_Writer.Write(VirtualTextureArrayStreamingEnable);
			p_Writer.Write(Enable);
			p_Writer.Write(TextureAtlasMergeEnable);
			p_Writer.Write(ClearMergeReport);
			p_Writer.WriteNullBytes(2);
		}
	}
}
