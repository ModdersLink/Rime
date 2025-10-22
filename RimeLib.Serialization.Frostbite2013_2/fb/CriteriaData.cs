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

[ContainerType(8, 96)]
public class CriteriaData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float CompletionValue { get; set; } = 1.000f;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<CriteriaGateList> GateList { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public StatEvent Measuring { get; set; } = StatEvent.StatEvent_Invalid;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<StatsCategoryBaseData> OrParamsX { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public CriteriaType CriteriaType { get; set; } = fb.VeniceShared.CriteriaType.CriteriaType_IAR_InARound;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string DescriptionSid { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float ScaleFactor { get; set; } = 1.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float Scale { get; set; } = 1.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool ShouldSummarize { get; set; } = false;
	
	[ContainerField(0x59), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
	public bool ShouldHide { get; set; } = false;
	
	[ContainerField(0x5a), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
	public bool CountEvents { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CompletionValue);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(GateList));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Measuring);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ParamX));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ParamY));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OrParamsX = p_EbxWriter.GetArrayWriter(OrParamsX.GetType(), OrParamsX.Count);
		p_Writer.Write(s_OrParamsX.ArrayIndex);
		foreach (var s_Entry in OrParamsX)
		{
			s_OrParamsX.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) CriteriaType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(DescriptionSid));
		p_Writer.Write(ScaleFactor);
		p_Writer.Write(Scale);
		p_Writer.Write(ShouldSummarize);
		p_Writer.Write(ShouldHide);
		p_Writer.Write(CountEvents);
		p_Writer.WriteNullBytes(5);
	}
}

