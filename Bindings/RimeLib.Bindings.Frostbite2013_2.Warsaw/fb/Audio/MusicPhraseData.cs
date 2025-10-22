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

[ContainerType(8, 120)]
public class MusicPhraseData
	: fb.Audio.MusicStreamableData
{
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public MusicPhraseSelectionType SelectionType { get; set; } = MusicPhraseSelectionType.MusicPhraseSelectionType_Sequential;
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<MusicParameterData> SelectionParameter { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<MusicFadeData> RangeFade { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public RefArray<MusicStreamableData> Playables { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool RestartIfAlreadyPlaying { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) SelectionType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectionParameter));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RangeFade));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Playables = p_EbxWriter.GetArrayWriter(Playables.GetType(), Playables.Count);
		p_Writer.Write(s_Playables.ArrayIndex);
		foreach (var s_Entry in Playables)
		{
			s_Playables.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RestartIfAlreadyPlaying);
		p_Writer.WriteNullBytes(7);
	}
}

