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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 160)]
public class EffectComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<EffectBlueprint> Effect { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float EmitterParameter1 { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float EmitterParameter2 { get; set; } = 0.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float EmitterParameter3 { get; set; } = 0.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float OverrideHeight { get; set; } = 0.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public int MaxInstances { get; set; } = 1;
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public RefArray<EffectParameter> EffectParameters { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool AutoStart { get; set; } = false;
	
	[ContainerField(0x99), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
	public bool SnapToWaterSurface { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Effect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(EmitterParameter1);
		p_Writer.Write(EmitterParameter2);
		p_Writer.Write(EmitterParameter3);
		p_Writer.Write(OverrideHeight);
		p_Writer.Write(MaxInstances);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_EffectParameters = p_EbxWriter.GetArrayWriter(EffectParameters.GetType(), EffectParameters.Count);
		p_Writer.Write(s_EffectParameters.ArrayIndex);
		foreach (var s_Entry in EffectParameters)
		{
			s_EffectParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AutoStart);
		p_Writer.Write(SnapToWaterSurface);
		p_Writer.WriteNullBytes(6);
	}
}

