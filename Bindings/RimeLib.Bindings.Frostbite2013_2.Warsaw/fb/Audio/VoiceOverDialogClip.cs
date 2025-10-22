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

[ContainerType(8, 56)]
public class VoiceOverDialogClip
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float MinOffset { get; set; } = 0.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float MaxOffset { get; set; } = 0.000f;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<VoiceOverDialogTake> Takes { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<VoiceOverDialogClip> OffsetReferences { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<VoiceOverDialogClipEvents> Events { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public byte SequenceIndex { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MinOffset);
		p_Writer.Write(MaxOffset);
		(RimeWriter Writer, uint ArrayIndex) s_Takes = p_EbxWriter.GetArrayWriter(Takes.GetType(), Takes.Count);
		p_Writer.Write(s_Takes.ArrayIndex);
		foreach (var s_Entry in Takes)
		{
			s_Entry.Serialize(s_Takes.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OffsetReferences = p_EbxWriter.GetArrayWriter(OffsetReferences.GetType(), OffsetReferences.Count);
		p_Writer.Write(s_OffsetReferences.ArrayIndex);
		foreach (var s_Entry in OffsetReferences)
		{
			s_OffsetReferences.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Events));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SequenceIndex);
		p_Writer.WriteNullBytes(7);
	}
}

