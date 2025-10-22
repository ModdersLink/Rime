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

[ContainerType(16, 384)]
public class UICommanderAssetStatusWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<BFUIElement3SliceStatbarAlignedStyle> ProgressbarStyleWarmUp { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<BFUIElement3SliceStatbarAlignedStyle> ProgressbarStyleRunning { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor IconEnabledColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementColor IconWarmupColor { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor IconCooldownColor { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementColor IconRunningColor { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public UIElementColor IconDisabledColor { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public CtrRef<BFUIElement3SliceStatbarAlignedStyle> ProgressbarStyleCoolDown { get; set; } = new();
	
	[ContainerField(0x128), JsonProperty(Order = 296)]
	public CtrRef<UIElementFontStyle> FontStyleRunning { get; set; } = new();
	
	[ContainerField(0x130), JsonProperty(Order = 304)]
	public CtrRef<UIElementFontStyle> FontStyleDisabled { get; set; } = new();
	
	[ContainerField(0x138), JsonProperty(Order = 312)]
	public CtrRef<UIElementFontStyle> FontStyleEnabled { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public CtrRef<UIElementFontStyle> FontStyleWarmup { get; set; } = new();
	
	[ContainerField(0x148), JsonProperty(Order = 328)]
	public CtrRef<UIElementFontStyle> FontStyleCooldown { get; set; } = new();
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public int RowSpacing { get; set; } = 2;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public int RowHeight { get; set; } = 32;
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public int TextPadding { get; set; } = 4;
	
	[ContainerField(0x160), JsonProperty(Order = 352)]
	public CtrRef<UIElementFillData> ObjectiveBackgroundData { get; set; } = new();
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public CtrRef<UIElementFillData> AssetBackgroundData { get; set; } = new();
	
	[ContainerField(0x170), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public Vec2 AssetIconSize { get; set; } = new()
	{
		y = 32.000f,
		x = 32.000f,
	};
	
	[ContainerField(0x178), JsonProperty(Order = 376)]
	public List<CommanderActionType> ExludedActions { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ProgressbarStyleWarmUp));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ProgressbarStyleRunning));
		p_Writer.WriteNullBytes(12);
		IconEnabledColor.Serialize(p_Writer, p_EbxWriter);
		IconWarmupColor.Serialize(p_Writer, p_EbxWriter);
		IconCooldownColor.Serialize(p_Writer, p_EbxWriter);
		IconRunningColor.Serialize(p_Writer, p_EbxWriter);
		IconDisabledColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ProgressbarStyleCoolDown));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyleRunning));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyleDisabled));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyleEnabled));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyleWarmup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyleCooldown));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RowSpacing);
		p_Writer.Write(RowHeight);
		p_Writer.Write(TextPadding);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ObjectiveBackgroundData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AssetBackgroundData));
		p_Writer.WriteNullBytes(4);
		AssetIconSize.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ExludedActions = p_EbxWriter.GetArrayWriter(ExludedActions.GetType(), ExludedActions.Count);
		p_Writer.Write(s_ExludedActions.ArrayIndex);
		foreach (var s_Entry in ExludedActions)
		{
			s_ExludedActions.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

