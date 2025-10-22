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

[ContainerType(16, 320)]
public class MapMarkerEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 BaseTransform { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public LinearTransform VisualTransform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public string Sid { get; set; } = string.Empty;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public string NameLetter { get; set; } = string.Empty;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public int NrOfPassengers { get; set; } = 0;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public int NrOfEntries { get; set; } = 0;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float ShowRadius { get; set; } = 0.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float HideRadius { get; set; } = 0.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float BlinkTime { get; set; } = 5.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public MapMarkerType MarkerType { get; set; } = MapMarkerType.MMTMissionObjective;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public TeamId VisibleForTeam { get; set; } = TeamId.TeamNeutral;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public TeamId OwnerTeam { get; set; } = TeamId.TeamNeutral;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public UIHudIcon HudIcon { get; set; } = UIHudIcon.UIHudIcon_ObjectiveGeneral;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public string IconName { get; set; } = string.Empty;
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<UIWorldIconBehavior> IconBehavior { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float VerticalOffset { get; set; } = 0.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float FocusPointRadius { get; set; } = 80.000f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public int FocusPriority { get; set; } = 0;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float ProgressTime { get; set; } = 80.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float Progress { get; set; } = 0.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public uint TrackedPlayersInRange { get; set; } = 0;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float TrackingPlayerRange { get; set; } = 10.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float InstantFlagReturnRadius { get; set; } = 0.000f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float ProgressPlayerSpeedUpPercentage { get; set; } = 10.000f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float ProgressTime1Player { get; set; } = 0.000f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float ProgressMinTime { get; set; } = 15.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float PulseTimeLength { get; set; } = 0.000f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public bool IsVisible { get; set; } = false;
	
	[ContainerField(0x129), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
	public bool ShowAirTargetBox { get; set; } = true;
	
	[ContainerField(0x12a), LayoutImmutable, Blittable, JsonProperty(Order = 298)]
	public bool IsFocusPoint { get; set; } = true;
	
	[ContainerField(0x12b), LayoutImmutable, Blittable, JsonProperty(Order = 299)]
	public bool Snap { get; set; } = true;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public bool OnlyShowSnapped { get; set; } = false;
	
	[ContainerField(0x12d), LayoutImmutable, Blittable, JsonProperty(Order = 301)]
	public bool UseMarkerTransform { get; set; } = false;
	
	[ContainerField(0x12e), LayoutImmutable, Blittable, JsonProperty(Order = 302)]
	public bool ServerControlledPosition { get; set; } = false;
	
	[ContainerField(0x12f), LayoutImmutable, Blittable, JsonProperty(Order = 303)]
	public bool PositionStatic { get; set; } = false;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public bool Enabled { get; set; } = false;
	
	[ContainerField(0x131), LayoutImmutable, Blittable, JsonProperty(Order = 305)]
	public bool ShowDistanceInText { get; set; } = false;
	
	[ContainerField(0x132), LayoutImmutable, Blittable, JsonProperty(Order = 306)]
	public bool ShowProgress { get; set; } = false;
	
	[ContainerField(0x133), LayoutImmutable, Blittable, JsonProperty(Order = 307)]
	public bool UsePulseTimeLength { get; set; } = false;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public bool OverrideVisibleForTeamInSpectator { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		BaseTransform.Serialize(p_Writer, p_EbxWriter);
		VisualTransform.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Sid));
		p_Writer.Write(p_EbxWriter.WriteString(NameLetter));
		p_Writer.Write(NrOfPassengers);
		p_Writer.Write(NrOfEntries);
		p_Writer.Write(ShowRadius);
		p_Writer.Write(HideRadius);
		p_Writer.Write(BlinkTime);
		p_Writer.Write((int) MarkerType);
		p_Writer.Write((int) VisibleForTeam);
		p_Writer.Write((int) OwnerTeam);
		p_Writer.Write((int) HudIcon);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(IconName));
		p_Writer.Write(p_EbxWriter.WriteImport(IconBehavior));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(VerticalOffset);
		p_Writer.Write(FocusPointRadius);
		p_Writer.Write(FocusPriority);
		p_Writer.Write(ProgressTime);
		p_Writer.Write(Progress);
		p_Writer.Write(TrackedPlayersInRange);
		p_Writer.Write(TrackingPlayerRange);
		p_Writer.Write(InstantFlagReturnRadius);
		p_Writer.Write(ProgressPlayerSpeedUpPercentage);
		p_Writer.Write(ProgressTime1Player);
		p_Writer.Write(ProgressMinTime);
		p_Writer.Write(PulseTimeLength);
		p_Writer.Write(IsVisible);
		p_Writer.Write(ShowAirTargetBox);
		p_Writer.Write(IsFocusPoint);
		p_Writer.Write(Snap);
		p_Writer.Write(OnlyShowSnapped);
		p_Writer.Write(UseMarkerTransform);
		p_Writer.Write(ServerControlledPosition);
		p_Writer.Write(PositionStatic);
		p_Writer.Write(Enabled);
		p_Writer.Write(ShowDistanceInText);
		p_Writer.Write(ShowProgress);
		p_Writer.Write(UsePulseTimeLength);
		p_Writer.Write(OverrideVisibleForTeamInSpectator);
		p_Writer.WriteNullBytes(11);
	}
}

