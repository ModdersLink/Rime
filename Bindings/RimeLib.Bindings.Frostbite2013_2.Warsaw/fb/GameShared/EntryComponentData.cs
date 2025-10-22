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

using fb.Entity;
using fb.Core;

namespace fb.GameShared;

[ContainerType(16, 240)]
public class EntryComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 SoldierOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public EntryClass EntryClass { get; set; } = fb.GameShared.EntryClass.ecPrimary;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<GameAIEntryData> AIData { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<EntryInputActionMapsData> InputConceptDefinition { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<InputActionMappingsData> InputMapping { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public RefArray<InputCurveData> InputCurves { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public EntryComponentHudData HudData { get; set; } = new();
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public int EntryOrderNumber { get; set; } = 0;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float EnterImpulse { get; set; } = 0.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float EntryRadius { get; set; } = 1.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float SoldierTransitionInvisbleTime { get; set; } = 0.075f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public int NumberOfStances { get; set; } = 1;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public EntrySpottingSettings EntrySpottingSettings { get; set; } = fb.GameShared.EntrySpottingSettings.ESSDefault;
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<EntryComponentSoundData> EntryComponentSound { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public int TriggerEventOnKey { get; set; } = 899534898;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public bool ForbiddenForHuman { get; set; } = false;
	
	[ContainerField(0xdd), LayoutImmutable, Blittable, JsonProperty(Order = 221)]
	public bool IsAllowedToExitInAir { get; set; } = true;
	
	[ContainerField(0xde), LayoutImmutable, Blittable, JsonProperty(Order = 222)]
	public bool IsShielded { get; set; } = false;
	
	[ContainerField(0xdf), LayoutImmutable, Blittable, JsonProperty(Order = 223)]
	public bool LockSoldierAimingToEntry { get; set; } = true;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public bool ShowSoldierInEntry { get; set; } = true;
	
	[ContainerField(0xe1), LayoutImmutable, Blittable, JsonProperty(Order = 225)]
	public bool Show1pSoldierInEntry { get; set; } = false;
	
	[ContainerField(0xe2), LayoutImmutable, Blittable, JsonProperty(Order = 226)]
	public bool StancesEnabled { get; set; } = false;
	
	[ContainerField(0xe3), LayoutImmutable, Blittable, JsonProperty(Order = 227)]
	public bool ShowSoldierWeaponInEntry { get; set; } = false;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public bool Show1pSoldierInEntryForPlayerOnly { get; set; } = false;
	
	[ContainerField(0xe5), LayoutImmutable, Blittable, JsonProperty(Order = 229)]
	public bool Show3pSoldierWeaponInEntry { get; set; } = true;
	
	[ContainerField(0xe6), LayoutImmutable, Blittable, JsonProperty(Order = 230)]
	public bool ShowSoldierGearInEntry { get; set; } = false;
	
	[ContainerField(0xe7), JsonProperty(Order = 231)]
	public PoseConstraintsData PoseConstraints { get; set; } = new();
	
	[ContainerField(0xea), LayoutImmutable, Blittable, JsonProperty(Order = 234)]
	public bool AllowRagdollFromEntry { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		SoldierOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) EntryClass);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AIData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(InputConceptDefinition));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(InputMapping));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputCurves = p_EbxWriter.GetArrayWriter(InputCurves.GetType(), InputCurves.Count);
		p_Writer.Write(s_InputCurves.ArrayIndex);
		foreach (var s_Entry in InputCurves)
		{
			s_InputCurves.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		HudData.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(EntryOrderNumber);
		p_Writer.Write(EnterImpulse);
		p_Writer.Write(EntryRadius);
		p_Writer.Write(SoldierTransitionInvisbleTime);
		p_Writer.Write(NumberOfStances);
		p_Writer.Write((int) EntrySpottingSettings);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EntryComponentSound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TriggerEventOnKey);
		p_Writer.Write(ForbiddenForHuman);
		p_Writer.Write(IsAllowedToExitInAir);
		p_Writer.Write(IsShielded);
		p_Writer.Write(LockSoldierAimingToEntry);
		p_Writer.Write(ShowSoldierInEntry);
		p_Writer.Write(Show1pSoldierInEntry);
		p_Writer.Write(StancesEnabled);
		p_Writer.Write(ShowSoldierWeaponInEntry);
		p_Writer.Write(Show1pSoldierInEntryForPlayerOnly);
		p_Writer.Write(Show3pSoldierWeaponInEntry);
		p_Writer.Write(ShowSoldierGearInEntry);
		PoseConstraints.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AllowRagdollFromEntry);
		p_Writer.WriteNullBytes(5);
	}
}

