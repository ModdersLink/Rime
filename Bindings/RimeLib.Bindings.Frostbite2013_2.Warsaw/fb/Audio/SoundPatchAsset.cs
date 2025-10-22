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

[ContainerType(8, 136)]
public class SoundPatchAsset
	: fb.Audio.SoundGraphAsset
{
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<AudioGraphNodeData> OutputNodes { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float Loudness { get; set; } = 80.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float AILoudness { get; set; } = -1.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float Radius { get; set; } = 0.500f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float RadiusFalloffScalar { get; set; } = 1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float MinObstructionValue { get; set; } = 0.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float MaxObstructionValue { get; set; } = 1.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float DopplerFactor { get; set; } = 1.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float MasterPitch { get; set; } = 1.000f;
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<AudioGraphEvent> DefaultStartEvent { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<AudioGraphEvent> DefaultStopEvent { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<AudioGraphEvent> DefaultEnterScopeEvent { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<AudioGraphEvent> DefaultForceInitEvent { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float MaxAllowableDucking { get; set; } = -1000.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public bool IsLooping { get; set; } = false;
	
	[ContainerField(0x85), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
	public bool IsPersistent { get; set; } = false;
	
	[ContainerField(0x86), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
	public bool UpdateHdr { get; set; } = true;
	
	[ContainerField(0x87), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
	public bool IncludeMeasuredGain { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_OutputNodes = p_EbxWriter.GetArrayWriter(OutputNodes.GetType(), OutputNodes.Count);
		p_Writer.Write(s_OutputNodes.ArrayIndex);
		foreach (var s_Entry in OutputNodes)
		{
			s_OutputNodes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Loudness);
		p_Writer.Write(AILoudness);
		p_Writer.Write(Radius);
		p_Writer.Write(RadiusFalloffScalar);
		p_Writer.Write(MinObstructionValue);
		p_Writer.Write(MaxObstructionValue);
		p_Writer.Write(DopplerFactor);
		p_Writer.Write(MasterPitch);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultStartEvent));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultStopEvent));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultEnterScopeEvent));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultForceInitEvent));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MaxAllowableDucking);
		p_Writer.Write(IsLooping);
		p_Writer.Write(IsPersistent);
		p_Writer.Write(UpdateHdr);
		p_Writer.Write(IncludeMeasuredGain);
	}
}

