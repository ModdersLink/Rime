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

using fb.Render;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 48)]
public class UIAnimatedTextureAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float FrameRate { get; set; } = 30.000f;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<TextureAsset> TextureAtlas { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<UITextureAtlasInfo> TextureInfos { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FrameRate);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TextureAtlas));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_TextureInfos = p_EbxWriter.GetArrayWriter(TextureInfos.GetType(), TextureInfos.Count);
		p_Writer.Write(s_TextureInfos.ArrayIndex);
		foreach (var s_Entry in TextureInfos)
		{
			s_Entry.Serialize(s_TextureInfos.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

