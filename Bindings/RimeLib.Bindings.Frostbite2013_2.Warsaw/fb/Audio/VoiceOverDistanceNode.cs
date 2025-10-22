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

[ContainerType(8, 96)]
public class VoiceOverDistanceNode
	: fb.Audio.VoiceOverExpressionNode
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public VoiceOverValueConnection A { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public VoiceOverValueConnection B { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public VoiceOverValueConnection Threshold { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<VoiceOverValue> Distance { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<VoiceOverValue> False { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<VoiceOverValue> True { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public VoiceOverCompareExpressionType Operation { get; set; } = VoiceOverCompareExpressionType.VoiceOverCompareExpressionType_Equals;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		A.Serialize(p_Writer, p_EbxWriter);
		B.Serialize(p_Writer, p_EbxWriter);
		Threshold.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Distance));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(False));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(True));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Operation);
		p_Writer.WriteNullBytes(4);
	}
}

