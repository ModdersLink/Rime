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
using fb.Audio;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 272)]
public class GameInteractionEntityData
	: fb.GameShared.InteractionEntityData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float DelayBetweenUses { get; set; } = 0.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public TeamId TeamId { get; set; } = fb.GameShared.TeamId.TeamNeutral;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public TeamId SpectatorTeamId { get; set; } = TeamId.TeamNeutral;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public int InputAction { get; set; } = 1573615674;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float HoldToInteractTime { get; set; } = 0.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public InteractionEntityType InteractionEntityType { get; set; } = fb.GameShared.InteractionEntityType.IET_None;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public string InteractionSid { get; set; } = string.Empty;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public BlinkType Blink { get; set; } = BlinkType.BTHold;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public string InteractingSid { get; set; } = string.Empty;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public string NameSid { get; set; } = string.Empty;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float InteractionVerticalOffset { get; set; } = 0.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public string FriendlyTextSid { get; set; } = string.Empty;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public string EnemyTextSid { get; set; } = string.Empty;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float CapturepointVerticalOffset { get; set; } = 0.000f;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public List<string> LicensesNeeded { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public List<string> ConsumablesDisabling { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public string IconName { get; set; } = string.Empty;
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<UIWorldIconBehavior> IconBehavior { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float TacticalRadius { get; set; } = 0.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public bool ShrinkSnap { get; set; } = false;
	
	[ContainerField(0xfd), LayoutImmutable, Blittable, JsonProperty(Order = 253)]
	public bool ShowAsCapturePoint { get; set; } = false;
	
	[ContainerField(0xfe), LayoutImmutable, Blittable, JsonProperty(Order = 254)]
	public bool FriendlyInteractionEnabled { get; set; } = true;
	
	[ContainerField(0xff), LayoutImmutable, Blittable, JsonProperty(Order = 255)]
	public bool EnemyInteractionEnabled { get; set; } = true;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public bool ForceSnap { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DelayBetweenUses);
		p_Writer.Write((int) TeamId);
		p_Writer.Write((int) SpectatorTeamId);
		p_Writer.Write(InputAction);
		p_Writer.Write(HoldToInteractTime);
		p_Writer.Write((int) InteractionEntityType);
		p_Writer.Write(p_EbxWriter.WriteString(InteractionSid));
		p_Writer.Write((int) Blink);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(InteractingSid));
		p_Writer.Write(p_EbxWriter.WriteString(NameSid));
		p_Writer.Write(InteractionVerticalOffset);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(FriendlyTextSid));
		p_Writer.Write(p_EbxWriter.WriteString(EnemyTextSid));
		p_Writer.Write(CapturepointVerticalOffset);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LicensesNeeded = p_EbxWriter.GetArrayWriter(LicensesNeeded.GetType(), LicensesNeeded.Count);
		p_Writer.Write(s_LicensesNeeded.ArrayIndex);
		foreach (var s_Entry in LicensesNeeded)
		{
			s_LicensesNeeded.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ConsumablesDisabling = p_EbxWriter.GetArrayWriter(ConsumablesDisabling.GetType(), ConsumablesDisabling.Count);
		p_Writer.Write(s_ConsumablesDisabling.ArrayIndex);
		foreach (var s_Entry in ConsumablesDisabling)
		{
			s_ConsumablesDisabling.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(IconName));
		p_Writer.Write(p_EbxWriter.WriteImport(IconBehavior));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TacticalRadius);
		p_Writer.Write(ShrinkSnap);
		p_Writer.Write(ShowAsCapturePoint);
		p_Writer.Write(FriendlyInteractionEnabled);
		p_Writer.Write(EnemyInteractionEnabled);
		p_Writer.Write(ForceSnap);
		p_Writer.WriteNullBytes(15);
	}
}

