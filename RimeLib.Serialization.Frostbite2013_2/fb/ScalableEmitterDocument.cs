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

namespace fb.Emitter;

[ContainerType(8, 56)]
public class ScalableEmitterDocument
	: fb.Emitter.EmitterDocument
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<EmitterTemplateData> TemplateDataLow { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<EmitterTemplateData> TemplateDataMedium { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<EmitterTemplateData> TemplateDataHigh { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<EmitterTemplateData> TemplateDataUltra { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(TemplateDataLow));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TemplateDataMedium));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TemplateDataHigh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TemplateDataUltra));
		p_Writer.WriteNullBytes(4);
	}
}

