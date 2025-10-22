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
using fb.UI;

namespace fb.VeniceShared;

[ContainerType(8, 120)]
public class UIPageHeaderBinding
	: fb.UI.UIDataBinding
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public UIDataSourceInfo Header { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public UIDataSourceInfo SubHeader { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UIDataSourceInfo Icon { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string StaticHeader { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string StaticSubHeader { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string StaticIcon { get; set; } = string.Empty;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public List<UILevelSpecificPageHeader> LevelSpecificHeaders { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Header.Serialize(p_Writer, p_EbxWriter);
		SubHeader.Serialize(p_Writer, p_EbxWriter);
		Icon.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(StaticHeader));
		p_Writer.Write(p_EbxWriter.WriteString(StaticSubHeader));
		p_Writer.Write(p_EbxWriter.WriteString(StaticIcon));
		(RimeWriter Writer, uint ArrayIndex) s_LevelSpecificHeaders = p_EbxWriter.GetArrayWriter(LevelSpecificHeaders.GetType(), LevelSpecificHeaders.Count);
		p_Writer.Write(s_LevelSpecificHeaders.ArrayIndex);
		foreach (var s_Entry in LevelSpecificHeaders)
		{
			s_Entry.Serialize(s_LevelSpecificHeaders.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

