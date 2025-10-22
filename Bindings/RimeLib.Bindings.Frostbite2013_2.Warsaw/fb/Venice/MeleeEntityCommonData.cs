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

using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.Venice;

[ContainerType(8, 440)]
public class MeleeEntityCommonData
	: fb.Entity.DataContainerPolicyAsset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CharacterMeleeBinding MeleeBinding { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CharacterMeleeCommonBinding MeleeCommonBinding { get; set; } = new();
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public float TriggerDelay { get; set; } = 0.000f;
	
	[ContainerField(0x15c), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
	public float DefendWindowDelay { get; set; } = 0.000f;
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float DefendWindowDuration { get; set; } = 2.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float KillDeadline { get; set; } = 3.000f;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public float FrontAttackKillDeadline { get; set; } = 4.300f;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public float DefendKillDeadline { get; set; } = 2.000f;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public float ReviveDelay { get; set; } = 3.000f;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public float MeleeEndDelay { get; set; } = 4.000f;
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public float InvalidMeleeAttackZone { get; set; } = 150.000f;
	
	[ContainerField(0x17c), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
	public float MeleeAttackFrontZone { get; set; } = 70.000f;
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public float MeleeAttackBackZone { get; set; } = 90.000f;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public float MeleeAttackFrustumAngle { get; set; } = 90.000f;
	
	[ContainerField(0x188), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
	public float MeleeAttackDistance { get; set; } = 3.000f;
	
	[ContainerField(0x18c), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
	public float MaxAttackHeightDifference { get; set; } = 1.200f;
	
	[ContainerField(0x190), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public float KillDamage { get; set; } = 100.000f;
	
	[ContainerField(0x198), JsonProperty(Order = 408)]
	public CtrRef<AntEnumeration> ProneAttackType { get; set; } = new();
	
	[ContainerField(0x1a0), JsonProperty(Order = 416)]
	public CtrRef<AntEnumeration> CrouchAttackType { get; set; } = new();
	
	[ContainerField(0x1a8), JsonProperty(Order = 424)]
	public CtrRef<AntEnumeration> ReviveAttackType { get; set; } = new();
	
	[ContainerField(0x1b0), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
	public bool EnableDefend { get; set; } = true;
	
	[ContainerField(0x1b1), LayoutImmutable, Blittable, JsonProperty(Order = 433)]
	public bool EnableAbortPossibility { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		MeleeBinding.Serialize(p_Writer, p_EbxWriter);
		MeleeCommonBinding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TriggerDelay);
		p_Writer.Write(DefendWindowDelay);
		p_Writer.Write(DefendWindowDuration);
		p_Writer.Write(KillDeadline);
		p_Writer.Write(FrontAttackKillDeadline);
		p_Writer.Write(DefendKillDeadline);
		p_Writer.Write(ReviveDelay);
		p_Writer.Write(MeleeEndDelay);
		p_Writer.Write(InvalidMeleeAttackZone);
		p_Writer.Write(MeleeAttackFrontZone);
		p_Writer.Write(MeleeAttackBackZone);
		p_Writer.Write(MeleeAttackFrustumAngle);
		p_Writer.Write(MeleeAttackDistance);
		p_Writer.Write(MaxAttackHeightDifference);
		p_Writer.Write(KillDamage);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ProneAttackType));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CrouchAttackType));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ReviveAttackType));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(EnableDefend);
		p_Writer.Write(EnableAbortPossibility);
		p_Writer.WriteNullBytes(6);
	}
}

