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

namespace fb.Audio;

[ContainerType(8, 88)]
public class MusicPlaylistAsset
	: fb.Audio.MusicBaseAsset
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public MusicPlaylistType PlaylistType { get; set; } = MusicPlaylistType.MusicPlaylistType_Shuffle;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<MusicAsset> Assets { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<MusicInterfaceAsset> Interface { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<MusicPlaylistSelector> Selectors { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<MusicFadeData> Fade { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float MinDelay { get; set; } = 0.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float MaxDelay { get; set; } = 0.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool Continuous { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool Repeat { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) PlaylistType);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Assets = p_EbxWriter.GetArrayWriter(Assets.GetType(), Assets.Count);
		p_Writer.Write(s_Assets.ArrayIndex);
		foreach (var s_Entry in Assets)
		{
			s_Assets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Interface));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Selectors = p_EbxWriter.GetArrayWriter(Selectors.GetType(), Selectors.Count);
		p_Writer.Write(s_Selectors.ArrayIndex);
		foreach (var s_Entry in Selectors)
		{
			s_Selectors.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Fade));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MinDelay);
		p_Writer.Write(MaxDelay);
		p_Writer.Write(Continuous);
		p_Writer.Write(Repeat);
		p_Writer.WriteNullBytes(6);
	}
}

