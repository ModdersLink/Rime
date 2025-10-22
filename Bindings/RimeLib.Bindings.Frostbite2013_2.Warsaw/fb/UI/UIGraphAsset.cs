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

using fb.Core;

namespace fb.UI;

[ContainerType(8, 80)]
public class UIGraphAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<UINodeData> Nodes { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<GlobalNode> GlobalNode { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<UINodeConnection> Connections { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<UIAudioEventAsset> AudioEventMappings { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string BundleAssetName { get; set; } = string.Empty;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public RefArray<UIEventAsset> EventList { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool ProtectScreens { get; set; } = false;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool Modal { get; set; } = false;
	
	[ContainerField(0x4a), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
	public bool IsWin32UIGraphAsset { get; set; } = true;
	
	[ContainerField(0x4b), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
	public bool IsXenonUIGraphAsset { get; set; } = true;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool IsPs3UIGraphAsset { get; set; } = true;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool IsGen4aUIGraphAsset { get; set; } = true;
	
	[ContainerField(0x4e), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
	public bool IsGen4bUIGraphAsset { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Nodes = p_EbxWriter.GetArrayWriter(Nodes.GetType(), Nodes.Count);
		p_Writer.Write(s_Nodes.ArrayIndex);
		foreach (var s_Entry in Nodes)
		{
			s_Nodes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(GlobalNode));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Connections = p_EbxWriter.GetArrayWriter(Connections.GetType(), Connections.Count);
		p_Writer.Write(s_Connections.ArrayIndex);
		foreach (var s_Entry in Connections)
		{
			s_Connections.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AudioEventMappings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(BundleAssetName));
		(RimeWriter Writer, uint ArrayIndex) s_EventList = p_EbxWriter.GetArrayWriter(EventList.GetType(), EventList.Count);
		p_Writer.Write(s_EventList.ArrayIndex);
		foreach (var s_Entry in EventList)
		{
			s_EventList.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ProtectScreens);
		p_Writer.Write(Modal);
		p_Writer.Write(IsWin32UIGraphAsset);
		p_Writer.Write(IsXenonUIGraphAsset);
		p_Writer.Write(IsPs3UIGraphAsset);
		p_Writer.Write(IsGen4aUIGraphAsset);
		p_Writer.Write(IsGen4bUIGraphAsset);
		p_Writer.WriteNullBytes(1);
	}
}

