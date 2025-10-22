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

[ContainerType(8, 200)]
public class UIButtonsTextureAtlasAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<UIAxesButtonTexture> AxesTextures { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<UIPadButtonTexture> PadTextures { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<UIKeysButtonTexture> KeysTextures { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<UIMouseButtonTexture> MouseTextures { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public UITextureAtlasInfo EchapKeyTexture { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public UITextureAtlasInfo EspaceKeyTexture { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public UITextureAtlasInfo FinKeyTexture { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public UITextureAtlasInfo OrigineKeyTexture { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public UITextureAtlasInfo VerrNumKeyTexture { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public UITextureAtlasInfo PageSuivKeyTexture { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public UITextureAtlasInfo PagePrecKeyTexture { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public UITextureAtlasInfo EmptyIconTexture { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<TextureAsset> TextureAtlas { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public bool OnDemandEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_AxesTextures = p_EbxWriter.GetArrayWriter(AxesTextures.GetType(), AxesTextures.Count);
		p_Writer.Write(s_AxesTextures.ArrayIndex);
		foreach (var s_Entry in AxesTextures)
		{
			s_Entry.Serialize(s_AxesTextures.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PadTextures = p_EbxWriter.GetArrayWriter(PadTextures.GetType(), PadTextures.Count);
		p_Writer.Write(s_PadTextures.ArrayIndex);
		foreach (var s_Entry in PadTextures)
		{
			s_Entry.Serialize(s_PadTextures.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_KeysTextures = p_EbxWriter.GetArrayWriter(KeysTextures.GetType(), KeysTextures.Count);
		p_Writer.Write(s_KeysTextures.ArrayIndex);
		foreach (var s_Entry in KeysTextures)
		{
			s_Entry.Serialize(s_KeysTextures.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_MouseTextures = p_EbxWriter.GetArrayWriter(MouseTextures.GetType(), MouseTextures.Count);
		p_Writer.Write(s_MouseTextures.ArrayIndex);
		foreach (var s_Entry in MouseTextures)
		{
			s_Entry.Serialize(s_MouseTextures.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		EchapKeyTexture.Serialize(p_Writer, p_EbxWriter);
		EspaceKeyTexture.Serialize(p_Writer, p_EbxWriter);
		FinKeyTexture.Serialize(p_Writer, p_EbxWriter);
		OrigineKeyTexture.Serialize(p_Writer, p_EbxWriter);
		VerrNumKeyTexture.Serialize(p_Writer, p_EbxWriter);
		PageSuivKeyTexture.Serialize(p_Writer, p_EbxWriter);
		PagePrecKeyTexture.Serialize(p_Writer, p_EbxWriter);
		EmptyIconTexture.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(TextureAtlas));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(OnDemandEnable);
		p_Writer.WriteNullBytes(7);
	}
}

