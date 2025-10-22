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

using fb.SoldierShared;
using fb.GameShared;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 584)]
public class VeniceSoldierHealthModuleData
	: fb.SoldierShared.SoldierHealthModuleData
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float TimeForCorpse { get; set; } = 20.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float InteractiveManDownThreshold { get; set; } = 10.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float ManDownStateTime { get; set; } = 15.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float ManDownStateHealthPoints { get; set; } = 200.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float ReviveQueryDelay { get; set; } = 2.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float ReviveQueryDuration { get; set; } = 10.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float ReviveQueryHealth { get; set; } = 10.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float ImmortalTimeAfterSpawn { get; set; } = 0.000f;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<int> AbortSpawnImmortalityInputs { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float PostReviveResponseTime { get; set; } = 5.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float RegenerationDelay { get; set; } = 5.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float RegenerationRate { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float PostReviveRegenerationDelay { get; set; } = 1.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float PostReviveRegenerationRate { get; set; } = 20.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float PostReviveRegenerationTime { get; set; } = 5.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float CriticalFakeImmortalTime { get; set; } = 0.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float SprintDisabledWhenDamagedTime { get; set; } = 0.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float SprintDisabledDamageThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x5c), JsonProperty(Order = 92)]
	public RotateToHitData ManDownRotate { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public SoldierHealthModuleBinding Binding { get; set; } = new();
	
	[ContainerField(0x240), LayoutImmutable, Blittable, JsonProperty(Order = 576)]
	public bool InteractiveManDown { get; set; } = false;
	
	[ContainerField(0x241), LayoutImmutable, Blittable, JsonProperty(Order = 577)]
	public bool TakeDamageInInteractiveMandown { get; set; } = true;
	
	[ContainerField(0x242), JsonProperty(Order = 578)]
	public PoseConstraintsData InteractiveManDownPoseConstraints { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TimeForCorpse);
		p_Writer.Write(InteractiveManDownThreshold);
		p_Writer.Write(ManDownStateTime);
		p_Writer.Write(ManDownStateHealthPoints);
		p_Writer.Write(ReviveQueryDelay);
		p_Writer.Write(ReviveQueryDuration);
		p_Writer.Write(ReviveQueryHealth);
		p_Writer.Write(ImmortalTimeAfterSpawn);
		(RimeWriter Writer, uint ArrayIndex) s_AbortSpawnImmortalityInputs = p_EbxWriter.GetArrayWriter(AbortSpawnImmortalityInputs.GetType(), AbortSpawnImmortalityInputs.Count);
		p_Writer.Write(s_AbortSpawnImmortalityInputs.ArrayIndex);
		foreach (var s_Entry in AbortSpawnImmortalityInputs)
		{
			s_AbortSpawnImmortalityInputs.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PostReviveResponseTime);
		p_Writer.Write(RegenerationDelay);
		p_Writer.Write(RegenerationRate);
		p_Writer.Write(PostReviveRegenerationDelay);
		p_Writer.Write(PostReviveRegenerationRate);
		p_Writer.Write(PostReviveRegenerationTime);
		p_Writer.Write(CriticalFakeImmortalTime);
		p_Writer.Write(SprintDisabledWhenDamagedTime);
		p_Writer.Write(SprintDisabledDamageThreshold);
		ManDownRotate.Serialize(p_Writer, p_EbxWriter);
		Binding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(InteractiveManDown);
		p_Writer.Write(TakeDamageInInteractiveMandown);
		InteractiveManDownPoseConstraints.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(3);
	}
}

