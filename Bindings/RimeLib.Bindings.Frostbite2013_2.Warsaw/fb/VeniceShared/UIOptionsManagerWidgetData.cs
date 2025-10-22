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

[ContainerType(8, 232)]
public class UIOptionsManagerWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementButtonStyle> ButtonStyle { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint RowSpacing { get; set; } = 1;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public uint RowHeight { get; set; } = 32;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float AutoScrollSpeed { get; set; } = 20.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public uint ScrollBarWidth { get; set; } = 15;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public uint ScrollBarMargin { get; set; } = 5;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<UIElementScrollbarStyle> ScrollBarStyle { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<UIWidgetBlueprint> SelectorTemplate { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public string SelectorTextureNormal { get; set; } = string.Empty;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public string SelectorTextureMouseOver { get; set; } = string.Empty;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public string SelectorTextureSelected { get; set; } = string.Empty;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float AnimationDuration { get; set; } = 0.100f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float AnimationTargetOffset { get; set; } = 2.000f;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<UIWidgetBlueprint> SliderTemplate { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<UIElementButtonStyle> SliderBackgroundStyle { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<UIElementButtonStyle> SliderStyle { get; set; } = new();
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public uint SliderBackgroundPadding { get; set; } = 1;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<UIWidgetBlueprint> ButtonTemplate { get; set; } = new();
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public uint MinAllowedResolutionHeight { get; set; } = 720;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public bool AskBeforeUnsavedLeave { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ButtonStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RowSpacing);
		p_Writer.Write(RowHeight);
		p_Writer.Write(AutoScrollSpeed);
		p_Writer.Write(ScrollBarWidth);
		p_Writer.Write(ScrollBarMargin);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ScrollBarStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectorTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(SelectorTextureNormal));
		p_Writer.Write(p_EbxWriter.WriteString(SelectorTextureMouseOver));
		p_Writer.Write(p_EbxWriter.WriteString(SelectorTextureSelected));
		p_Writer.Write(AnimationDuration);
		p_Writer.Write(AnimationTargetOffset);
		p_Writer.Write(p_EbxWriter.WriteImport(SliderTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SliderBackgroundStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SliderStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SliderBackgroundPadding);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ButtonTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MinAllowedResolutionHeight);
		p_Writer.Write(AskBeforeUnsavedLeave);
		p_Writer.WriteNullBytes(3);
	}
}

