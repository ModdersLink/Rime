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
using fb.UI;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 240)]
public class UINPXTooltipWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float TitleLowerPadding { get; set; } = 10.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float ContentAlpha { get; set; } = 1.000f;
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec4 ParentScreenRect { get; set; } = new()
	{
		w = 720.000f,
		z = 1280.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public UIInputAction CloseAction { get; set; } = UIInputAction.UIInputAction_Deactivate;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public List<string> IconTextureIds { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float PreBlinkTime { get; set; } = 1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float CursorBlinkRate { get; set; } = 30.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float ExpansionTime { get; set; } = 1.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float TitleTextRate { get; set; } = 150.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float TitleTypingAnimationTime { get; set; } = 0.250f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float SecondaryBlinkTime { get; set; } = 1.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float WaitingTime { get; set; } = 1.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float TitleBodyFadeTime { get; set; } = 1.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float ShrinkTime { get; set; } = 1.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float PostBlinkTime { get; set; } = 1.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float FullscreenBackgroundFadeInDuration { get; set; } = 0.250f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float FullscreenBackgroundFadeOutDuration { get; set; } = 0.250f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float IconTextOffset { get; set; } = 10.000f;
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public List<UINPXTooltipWidgetLayout> PresetLayouts { get; set; } = new();
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float PaddingAfterButton { get; set; } = 10.000f;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<UIElementFillData> InputEaterFill { get; set; } = new();
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public bool BlockedByScreen { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TitleLowerPadding);
		p_Writer.Write(ContentAlpha);
		ParentScreenRect.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) CloseAction);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_IconTextureIds = p_EbxWriter.GetArrayWriter(IconTextureIds.GetType(), IconTextureIds.Count);
		p_Writer.Write(s_IconTextureIds.ArrayIndex);
		foreach (var s_Entry in IconTextureIds)
		{
			s_IconTextureIds.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PreBlinkTime);
		p_Writer.Write(CursorBlinkRate);
		p_Writer.Write(ExpansionTime);
		p_Writer.Write(TitleTextRate);
		p_Writer.Write(TitleTypingAnimationTime);
		p_Writer.Write(SecondaryBlinkTime);
		p_Writer.Write(WaitingTime);
		p_Writer.Write(TitleBodyFadeTime);
		p_Writer.Write(ShrinkTime);
		p_Writer.Write(PostBlinkTime);
		p_Writer.Write(FullscreenBackgroundFadeInDuration);
		p_Writer.Write(FullscreenBackgroundFadeOutDuration);
		p_Writer.Write(IconTextOffset);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PresetLayouts = p_EbxWriter.GetArrayWriter(PresetLayouts.GetType(), PresetLayouts.Count);
		p_Writer.Write(s_PresetLayouts.ArrayIndex);
		foreach (var s_Entry in PresetLayouts)
		{
			s_Entry.Serialize(s_PresetLayouts.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PaddingAfterButton);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(InputEaterFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(BlockedByScreen);
		p_Writer.WriteNullBytes(15);
	}
}

