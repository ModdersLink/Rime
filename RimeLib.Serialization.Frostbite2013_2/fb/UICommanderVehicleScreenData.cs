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

[ContainerType(16, 608)]
public class UICommanderVehicleScreenData
	: fb.VeniceShared.UIDeployScreenData
{
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public UIElementColor CrosshairEnabledColor { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor CrosshairDisabledColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementColor SelectedSquadBackgroundColor { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor MenuIconColor { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementColor MenuIconDisabledColor { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public UIElementColor MenuIconHoverColor { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public UIElementColor MenuIconCooldownColor { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public UIElementColor MenuIconWarmupColor { get; set; } = new();
	
	[ContainerField(0x160), JsonProperty(Order = 352)]
	public UIElementColor MenuIconRunningColor { get; set; } = new();
	
	[ContainerField(0x180), JsonProperty(Order = 384)]
	public CtrRef<UIElementFontStyle> SelectedSquadFont { get; set; } = new();
	
	[ContainerField(0x188), JsonProperty(Order = 392)]
	public CtrRef<UIElementFontStyle> UnselectedSquadFont { get; set; } = new();
	
	[ContainerField(0x190), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public Vec2 SelectedSquadTextPadding { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x198), JsonProperty(Order = 408)]
	public List<CommanderActionType> EnemyObjectiveActions { get; set; } = new();
	
	[ContainerField(0x1a0), JsonProperty(Order = 416)]
	public List<CommanderActionType> FriendlyObjectiveActions { get; set; } = new();
	
	[ContainerField(0x1a8), JsonProperty(Order = 424)]
	public List<CommanderActionType> NeutralCPActions { get; set; } = new();
	
	[ContainerField(0x1b0), JsonProperty(Order = 432)]
	public List<CommanderActionType> SquadActions { get; set; } = new();
	
	[ContainerField(0x1b8), JsonProperty(Order = 440)]
	public List<CommanderActionType> PlayerActions { get; set; } = new();
	
	[ContainerField(0x1c0), JsonProperty(Order = 448)]
	public List<CommanderActionType> FreeActions { get; set; } = new();
	
	[ContainerField(0x1c8), JsonProperty(Order = 456)]
	public List<CommanderActionType> TopAlignedAssets { get; set; } = new();
	
	[ContainerField(0x1d0), JsonProperty(Order = 464)]
	public List<CommanderActionType> RightAlignedAssets { get; set; } = new();
	
	[ContainerField(0x1d8), JsonProperty(Order = 472)]
	public List<CommanderActionType> BottomAlignedAssets { get; set; } = new();
	
	[ContainerField(0x1e0), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
	public float MenuEnableAnimSpeed { get; set; } = 10.000f;
	
	[ContainerField(0x1e4), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
	public float MenuDisableAnimSpeed { get; set; } = 5.000f;
	
	[ContainerField(0x1e8), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
	public float MenuEnableAnimDistance { get; set; } = 20.000f;
	
	[ContainerField(0x1ec), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
	public float MenuDisableAnimDistance { get; set; } = 20.000f;
	
	[ContainerField(0x1f0), JsonProperty(Order = 496)]
	public CtrRef<BFUIElement3SliceStatbarAlignedStyle> ProgressbarStyleWarmUp { get; set; } = new();
	
	[ContainerField(0x1f8), JsonProperty(Order = 504)]
	public CtrRef<BFUIElement3SliceStatbarAlignedStyle> ProgressbarStyleRunning { get; set; } = new();
	
	[ContainerField(0x200), JsonProperty(Order = 512)]
	public CtrRef<BFUIElement3SliceStatbarAlignedStyle> ProgressbarStyleCoolDown { get; set; } = new();
	
	[ContainerField(0x208), LayoutImmutable, Blittable, JsonProperty(Order = 520)]
	public int MenuButtonPadding { get; set; } = 3;
	
	[ContainerField(0x20c), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 524)]
	public Vec2 MenuButtonSize { get; set; } = new()
	{
		y = 32.000f,
		x = 32.000f,
	};
	
	[ContainerField(0x218), JsonProperty(Order = 536)]
	public CtrRef<UIElementButtonStyle> MenuButtonStyle { get; set; } = new();
	
	[ContainerField(0x220), JsonProperty(Order = 544)]
	public CtrRef<UIElementButtonStyle> MenuButtonDisabledStyle { get; set; } = new();
	
	[ContainerField(0x228), JsonProperty(Order = 552)]
	public CtrRef<UIElementButtonStyle> MenuButtonProgressStyle { get; set; } = new();
	
	[ContainerField(0x230), JsonProperty(Order = 560)]
	public CtrRef<UIElementFontStyle> EnabledButtonFont { get; set; } = new();
	
	[ContainerField(0x238), JsonProperty(Order = 568)]
	public CtrRef<UIElementFontStyle> DisabledButtonFont { get; set; } = new();
	
	[ContainerField(0x240), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 576)]
	public Vec2 MenuIconSize { get; set; } = new()
	{
		y = 32.000f,
		x = 32.000f,
	};
	
	[ContainerField(0x248), LayoutImmutable, Blittable, JsonProperty(Order = 584)]
	public uint ScrollThreshold3dView { get; set; } = 3;
	
	[ContainerField(0x24c), LayoutImmutable, Blittable, JsonProperty(Order = 588)]
	public float TimeThreshold3dView { get; set; } = 1.000f;
	
	[ContainerField(0x250), LayoutImmutable, Blittable, JsonProperty(Order = 592)]
	public float MinZoomThreshold3dView { get; set; } = 0.100f;
	
	[ContainerField(0x254), LayoutImmutable, Blittable, JsonProperty(Order = 596)]
	public float MouseSpeed3dView { get; set; } = 0.100f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		CrosshairEnabledColor.Serialize(p_Writer, p_EbxWriter);
		CrosshairDisabledColor.Serialize(p_Writer, p_EbxWriter);
		SelectedSquadBackgroundColor.Serialize(p_Writer, p_EbxWriter);
		MenuIconColor.Serialize(p_Writer, p_EbxWriter);
		MenuIconDisabledColor.Serialize(p_Writer, p_EbxWriter);
		MenuIconHoverColor.Serialize(p_Writer, p_EbxWriter);
		MenuIconCooldownColor.Serialize(p_Writer, p_EbxWriter);
		MenuIconWarmupColor.Serialize(p_Writer, p_EbxWriter);
		MenuIconRunningColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedSquadFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(UnselectedSquadFont));
		p_Writer.WriteNullBytes(4);
		SelectedSquadTextPadding.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_EnemyObjectiveActions = p_EbxWriter.GetArrayWriter(EnemyObjectiveActions.GetType(), EnemyObjectiveActions.Count);
		p_Writer.Write(s_EnemyObjectiveActions.ArrayIndex);
		foreach (var s_Entry in EnemyObjectiveActions)
		{
			s_EnemyObjectiveActions.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_FriendlyObjectiveActions = p_EbxWriter.GetArrayWriter(FriendlyObjectiveActions.GetType(), FriendlyObjectiveActions.Count);
		p_Writer.Write(s_FriendlyObjectiveActions.ArrayIndex);
		foreach (var s_Entry in FriendlyObjectiveActions)
		{
			s_FriendlyObjectiveActions.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_NeutralCPActions = p_EbxWriter.GetArrayWriter(NeutralCPActions.GetType(), NeutralCPActions.Count);
		p_Writer.Write(s_NeutralCPActions.ArrayIndex);
		foreach (var s_Entry in NeutralCPActions)
		{
			s_NeutralCPActions.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SquadActions = p_EbxWriter.GetArrayWriter(SquadActions.GetType(), SquadActions.Count);
		p_Writer.Write(s_SquadActions.ArrayIndex);
		foreach (var s_Entry in SquadActions)
		{
			s_SquadActions.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PlayerActions = p_EbxWriter.GetArrayWriter(PlayerActions.GetType(), PlayerActions.Count);
		p_Writer.Write(s_PlayerActions.ArrayIndex);
		foreach (var s_Entry in PlayerActions)
		{
			s_PlayerActions.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_FreeActions = p_EbxWriter.GetArrayWriter(FreeActions.GetType(), FreeActions.Count);
		p_Writer.Write(s_FreeActions.ArrayIndex);
		foreach (var s_Entry in FreeActions)
		{
			s_FreeActions.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_TopAlignedAssets = p_EbxWriter.GetArrayWriter(TopAlignedAssets.GetType(), TopAlignedAssets.Count);
		p_Writer.Write(s_TopAlignedAssets.ArrayIndex);
		foreach (var s_Entry in TopAlignedAssets)
		{
			s_TopAlignedAssets.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_RightAlignedAssets = p_EbxWriter.GetArrayWriter(RightAlignedAssets.GetType(), RightAlignedAssets.Count);
		p_Writer.Write(s_RightAlignedAssets.ArrayIndex);
		foreach (var s_Entry in RightAlignedAssets)
		{
			s_RightAlignedAssets.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BottomAlignedAssets = p_EbxWriter.GetArrayWriter(BottomAlignedAssets.GetType(), BottomAlignedAssets.Count);
		p_Writer.Write(s_BottomAlignedAssets.ArrayIndex);
		foreach (var s_Entry in BottomAlignedAssets)
		{
			s_BottomAlignedAssets.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MenuEnableAnimSpeed);
		p_Writer.Write(MenuDisableAnimSpeed);
		p_Writer.Write(MenuEnableAnimDistance);
		p_Writer.Write(MenuDisableAnimDistance);
		p_Writer.Write(p_EbxWriter.WriteImport(ProgressbarStyleWarmUp));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ProgressbarStyleRunning));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ProgressbarStyleCoolDown));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MenuButtonPadding);
		MenuButtonSize.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MenuButtonStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MenuButtonDisabledStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MenuButtonProgressStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EnabledButtonFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DisabledButtonFont));
		p_Writer.WriteNullBytes(4);
		MenuIconSize.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ScrollThreshold3dView);
		p_Writer.Write(TimeThreshold3dView);
		p_Writer.Write(MinZoomThreshold3dView);
		p_Writer.Write(MouseSpeed3dView);
		p_Writer.WriteNullBytes(8);
	}
}

