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
using fb.GameShared;

namespace fb.VeniceShared;

[ContainerType(8, 80)]
public class ScoringTypeData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public StatEvent Measuring { get; set; } = StatEvent.StatEvent_Invalid;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float Limit { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string DescriptionSid { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public ScoringVisibilityType VisibilityType { get; set; } = ScoringVisibilityType.ScoringVisibilityType_Major;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public ScoringBucket Bucket { get; set; } = ScoringBucket.ScoringBucket_General;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float Score { get; set; } = 0.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float AdditionalValueMultiplier { get; set; } = 0.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool ShowForTeam { get; set; } = false;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool DisplayStatValue { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Measuring);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ParamX));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ParamY));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Limit);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(DescriptionSid));
		p_Writer.Write((int) VisibilityType);
		p_Writer.Write((int) Bucket);
		p_Writer.Write(Score);
		p_Writer.Write(AdditionalValueMultiplier);
		p_Writer.Write(ShowForTeam);
		p_Writer.Write(DisplayStatValue);
		p_Writer.WriteNullBytes(6);
	}
}

