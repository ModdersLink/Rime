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

[ContainerType(8, 64)]
public class VoiceOverArithmeticNode
	: fb.Audio.VoiceOverExpressionNode
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public VoiceOverValueConnection A { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public VoiceOverValueConnection B { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<VoiceOverValue> Result { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public VoiceOverArithmeticExpressionType Operation { get; set; } = VoiceOverArithmeticExpressionType.VoiceOverArithmeticExpressionType_Addition;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		A.Serialize(p_Writer, p_EbxWriter);
		B.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Result));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Operation);
		p_Writer.WriteNullBytes(4);
	}
}

