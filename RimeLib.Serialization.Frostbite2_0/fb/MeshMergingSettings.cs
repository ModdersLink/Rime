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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 28)]
	public partial class MeshMergingSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private int _StatsSeedIndex;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private int _StatsLodIndex;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _TextureAtlasWidth;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private bool _DrawStatsEnable;

		[ObservableProperty]
		[property: ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		private bool _DrawDebugTexturesEnable;

		[ObservableProperty]
		[property: ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		private bool _VirtualTextureArrayStreamingEnable;

		[ObservableProperty]
		[property: ContainerField(23), LayoutImmutable, Blittable, JsonProperty(Order = 23)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _TextureAtlasMergeEnable;

		[ObservableProperty]
		[property: ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		private bool _ClearMergeReport;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
