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

namespace fb.VeniceShared;

[ContainerType(8, 104)]
public class UIMatchmakingDescription
	: fb.VeniceShared.UIItemDescription
{
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Identifier { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int SortIndex { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string Header { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string Description { get; set; } = string.Empty;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<UIMatchmakingGamemodeMappack> SupportedMapPacks { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public List<GamePlatform> IncludedPlatforms { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string VideoThumbnailPath { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool HasTutorialVideo { get; set; } = true;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public bool isPremiumPlaylist { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Identifier));
		p_Writer.Write(SortIndex);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Header));
		p_Writer.Write(p_EbxWriter.WriteString(Description));
		(RimeWriter Writer, uint ArrayIndex) s_SupportedMapPacks = p_EbxWriter.GetArrayWriter(SupportedMapPacks.GetType(), SupportedMapPacks.Count);
		p_Writer.Write(s_SupportedMapPacks.ArrayIndex);
		foreach (var s_Entry in SupportedMapPacks)
		{
			s_Entry.Serialize(s_SupportedMapPacks.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_IncludedPlatforms = p_EbxWriter.GetArrayWriter(IncludedPlatforms.GetType(), IncludedPlatforms.Count);
		p_Writer.Write(s_IncludedPlatforms.ArrayIndex);
		foreach (var s_Entry in IncludedPlatforms)
		{
			s_IncludedPlatforms.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(VideoThumbnailPath));
		p_Writer.Write(HasTutorialVideo);
		p_Writer.Write(isPremiumPlaylist);
		p_Writer.WriteNullBytes(6);
	}
}

