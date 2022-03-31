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
	[ContainerType(4, 44)]
	public class UIGraphAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<UINodeData> Nodes { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<GlobalNode> GlobalNode { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<UINodeConnection> Connections { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<UIAudioEventAsset> AudioEventMappings { get; set; } = new();

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string BundleAssetName { get; set; } = string.Empty;

		[ContainerField(32), JsonProperty(Order = 32)]
		public RefArray<UIEventAsset> EventList { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool Modal { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool ProtectScreens { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		public bool IsWin32UIGraphAsset { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
		public bool IsXenonUIGraphAsset { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool IsPs3UIGraphAsset { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Nodes = p_EbxWriter.GetArrayWriter(Nodes.GetType(), Nodes.Count);
			p_Writer.Write(s_Nodes.ArrayIndex);
			foreach (var s_Entry in Nodes)
			{
				s_Nodes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(GlobalNode));
			(RimeWriter Writer, uint ArrayIndex) s_Connections = p_EbxWriter.GetArrayWriter(Connections.GetType(), Connections.Count);
			p_Writer.Write(s_Connections.ArrayIndex);
			foreach (var s_Entry in Connections)
			{
				s_Connections.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(AudioEventMappings));
			p_Writer.Write(p_EbxWriter.WriteString(BundleAssetName));
			(RimeWriter Writer, uint ArrayIndex) s_EventList = p_EbxWriter.GetArrayWriter(EventList.GetType(), EventList.Count);
			p_Writer.Write(s_EventList.ArrayIndex);
			foreach (var s_Entry in EventList)
			{
				s_EventList.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(Modal);
			p_Writer.Write(ProtectScreens);
			p_Writer.Write(IsWin32UIGraphAsset);
			p_Writer.Write(IsXenonUIGraphAsset);
			p_Writer.Write(IsPs3UIGraphAsset);
			p_Writer.WriteNullBytes(3);
		}
	}
}
