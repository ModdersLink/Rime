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
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 272)]
public class CapturePointEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public RefArray<ObjectBlueprint> FlagTemplates { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<ObjectBlueprint> CapturePoint { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public TeamId InitialOwnerTeam { get; set; } = TeamId.TeamNeutral;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float CaptureRadius { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public int AreaValue { get; set; } = 100;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public List<AreaValueTeam> AreaValues { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public int TimeToGetControl { get; set; } = 10;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public int TimeToLoseControl { get; set; } = 10;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float ReturnMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public int OnlyTakeableByTeam { get; set; } = 0;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public int MinNrToTakeControl { get; set; } = 1;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public int MaxCaptureMultiplier { get; set; } = 4;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float AddedMultiplierPerPlayer { get; set; } = 1.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public int EnemyTicketLossWhenCaptured { get; set; } = 0;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public uint SpawnMenuListOrdinal { get; set; } = 0;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public string IntruderWarningSID { get; set; } = @"Warning a base is under attack!";
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public CapturableType CapturableType { get; set; } = fb.VeniceShared.CapturableType.CTDefault;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public int ChainlinkOrderIndex { get; set; } = 0;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float ShowRadius { get; set; } = 0.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float HideRadius { get; set; } = 0.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public CapturePointUIType UiType { get; set; } = CapturePointUIType.CapturePointUIType_Default;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float VerticalOffset { get; set; } = 0.000f;
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIWorldIconBehavior> IconBehavior { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public string LocationNameSid { get; set; } = string.Empty;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public string LocationTextSid { get; set; } = string.Empty;
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public CtrRef<ObjectBlueprint> CTFSoldierCarriedFlag { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<ObjectBlueprint> CTFVehicleCarriedFlag { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0xf9), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
	public bool IsCapturedInUpperSphere { get; set; } = false;
	
	[ContainerField(0xfa), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
	public bool UseAreaValuesPerTeam { get; set; } = false;
	
	[ContainerField(0xfb), LayoutImmutable, Blittable, JsonProperty(Order = 251)]
	public bool IntruderWarning { get; set; } = true;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public bool DisableIfEnemyInside { get; set; } = false;
	
	[ContainerField(0xfd), LayoutImmutable, Blittable, JsonProperty(Order = 253)]
	public bool DisableWhenLosingControl { get; set; } = false;
	
	[ContainerField(0xfe), LayoutImmutable, Blittable, JsonProperty(Order = 254)]
	public bool LoseControlWhenNotClose { get; set; } = false;
	
	[ContainerField(0xff), LayoutImmutable, Blittable, JsonProperty(Order = 255)]
	public bool IsVisible { get; set; } = false;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public bool ShowOnMinimap { get; set; } = false;
	
	[ContainerField(0x101), LayoutImmutable, Blittable, JsonProperty(Order = 257)]
	public bool DrawBaseAsForwardBase { get; set; } = false;
	
	[ContainerField(0x102), LayoutImmutable, Blittable, JsonProperty(Order = 258)]
	public bool HoistFlag { get; set; } = true;
	
	[ContainerField(0x103), LayoutImmutable, Blittable, JsonProperty(Order = 259)]
	public bool StartAtBottom { get; set; } = false;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public bool RemoveWhenCaptured { get; set; } = false;
	
	[ContainerField(0x105), LayoutImmutable, Blittable, JsonProperty(Order = 261)]
	public bool SeesawCapturing { get; set; } = false;
	
	[ContainerField(0x106), LayoutImmutable, Blittable, JsonProperty(Order = 262)]
	public bool ForceSpawnAtVehicle { get; set; } = false;
	
	[ContainerField(0x107), LayoutImmutable, Blittable, JsonProperty(Order = 263)]
	public bool UseMirroredVehicleLayout { get; set; } = false;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public bool ForcedBlink { get; set; } = false;
	
	[ContainerField(0x109), LayoutImmutable, Blittable, JsonProperty(Order = 265)]
	public bool CTFBase { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_FlagTemplates = p_EbxWriter.GetArrayWriter(FlagTemplates.GetType(), FlagTemplates.Count);
		p_Writer.Write(s_FlagTemplates.ArrayIndex);
		foreach (var s_Entry in FlagTemplates)
		{
			s_FlagTemplates.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CapturePoint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) InitialOwnerTeam);
		p_Writer.Write(CaptureRadius);
		p_Writer.Write(AreaValue);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_AreaValues = p_EbxWriter.GetArrayWriter(AreaValues.GetType(), AreaValues.Count);
		p_Writer.Write(s_AreaValues.ArrayIndex);
		foreach (var s_Entry in AreaValues)
		{
			s_Entry.Serialize(s_AreaValues.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TimeToGetControl);
		p_Writer.Write(TimeToLoseControl);
		p_Writer.Write(ReturnMultiplier);
		p_Writer.Write(OnlyTakeableByTeam);
		p_Writer.Write(MinNrToTakeControl);
		p_Writer.Write(MaxCaptureMultiplier);
		p_Writer.Write(AddedMultiplierPerPlayer);
		p_Writer.Write(EnemyTicketLossWhenCaptured);
		p_Writer.Write(SpawnMenuListOrdinal);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(IntruderWarningSID));
		p_Writer.Write((int) CapturableType);
		p_Writer.Write(ChainlinkOrderIndex);
		p_Writer.Write(ShowRadius);
		p_Writer.Write(HideRadius);
		p_Writer.Write((int) UiType);
		p_Writer.Write(VerticalOffset);
		p_Writer.Write(p_EbxWriter.WriteImport(IconBehavior));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(LocationNameSid));
		p_Writer.Write(p_EbxWriter.WriteString(LocationTextSid));
		p_Writer.Write(p_EbxWriter.WriteImport(CTFSoldierCarriedFlag));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CTFVehicleCarriedFlag));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Enabled);
		p_Writer.Write(IsCapturedInUpperSphere);
		p_Writer.Write(UseAreaValuesPerTeam);
		p_Writer.Write(IntruderWarning);
		p_Writer.Write(DisableIfEnemyInside);
		p_Writer.Write(DisableWhenLosingControl);
		p_Writer.Write(LoseControlWhenNotClose);
		p_Writer.Write(IsVisible);
		p_Writer.Write(ShowOnMinimap);
		p_Writer.Write(DrawBaseAsForwardBase);
		p_Writer.Write(HoistFlag);
		p_Writer.Write(StartAtBottom);
		p_Writer.Write(RemoveWhenCaptured);
		p_Writer.Write(SeesawCapturing);
		p_Writer.Write(ForceSpawnAtVehicle);
		p_Writer.Write(UseMirroredVehicleLayout);
		p_Writer.Write(ForcedBlink);
		p_Writer.Write(CTFBase);
		p_Writer.WriteNullBytes(6);
	}
}

