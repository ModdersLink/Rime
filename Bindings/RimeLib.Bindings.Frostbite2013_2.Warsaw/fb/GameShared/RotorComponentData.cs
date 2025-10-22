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

[ContainerType(16, 176)]
public class RotorComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public RotorModelData LowRpmModel { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public RotorModelData HighRpmModel { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public RotationAxis RotationAxis { get; set; } = fb.GameShared.RotationAxis.raX;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float RotationMultiplier { get; set; } = 0.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float ChangeModelRpm { get; set; } = 0.000f;
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<EffectBlueprint> BlowEffect { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float TriggerGroundEffectHeight { get; set; } = 0.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float CriticallyDamagedRotationForce { get; set; } = 0.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool OnlyTriggerBlowEffectInWater { get; set; } = true;
	
	[ContainerField(0xa1), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
	public bool GroundEffectOnTerrainOnly { get; set; } = false;
	
	[ContainerField(0xa2), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
	public bool CriticalDamage { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		LowRpmModel.Serialize(p_Writer, p_EbxWriter);
		HighRpmModel.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) RotationAxis);
		p_Writer.Write(RotationMultiplier);
		p_Writer.Write(ChangeModelRpm);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(BlowEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TriggerGroundEffectHeight);
		p_Writer.Write(CriticallyDamagedRotationForce);
		p_Writer.Write(OnlyTriggerBlowEffectInWater);
		p_Writer.Write(GroundEffectOnTerrainOnly);
		p_Writer.Write(CriticalDamage);
		p_Writer.WriteNullBytes(13);
	}
}

