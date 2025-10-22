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

namespace fb.VeniceShared;

[ContainerType(16, 464)]
public class UIMinimapVisualWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public UIVisualWidgetType WidgetType { get; set; } = UIVisualWidgetType.UIVisualWidgetType_Default;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string MaskName { get; set; } = string.Empty;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor MinimapColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementColor JointColor { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor JointNameColor1 { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementColor JointNameColor2 { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public UIElementColor LineColor { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public UIElementColor AreaColor { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public UIElementColor SecondaryColor { get; set; } = new();
	
	[ContainerField(0x160), JsonProperty(Order = 352)]
	public UIElementColor CapturePointAreaNeutralColor { get; set; } = new();
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public float NativeViewWidth { get; set; } = 50.000f;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public float ViewVelocityExpandFactor { get; set; } = 0.050f;
	
	[ContainerField(0x188), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
	public float ViewVelocityMin { get; set; } = 25.000f;
	
	[ContainerField(0x18c), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
	public float ViewVelocityMax { get; set; } = 100.000f;
	
	[ContainerField(0x190), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public string JointImage { get; set; } = string.Empty;
	
	[ContainerField(0x198), JsonProperty(Order = 408)]
	public CtrRef<UIElementFontStyle> JointNameFont { get; set; } = new();
	
	[ContainerField(0x1a0), LayoutImmutable, Blittable, JsonProperty(Order = 416)]
	public string JointNameSequence { get; set; } = string.Empty;
	
	[ContainerField(0x1a8), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
	public float LineWidth { get; set; } = 0.000f;
	
	[ContainerField(0x1ac), LayoutImmutable, Blittable, JsonProperty(Order = 428)]
	public float PatternWidth { get; set; } = -1.000f;
	
	[ContainerField(0x1b0), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
	public float PatternSoftness { get; set; } = 3.000f;
	
	[ContainerField(0x1b4), LayoutImmutable, Blittable, JsonProperty(Order = 436)]
	public float CapturePointAreaAlpha { get; set; } = 0.100f;
	
	[ContainerField(0x1b8), LayoutImmutable, Blittable, JsonProperty(Order = 440)]
	public float CapturePointBlinkRate { get; set; } = 1.250f;
	
	[ContainerField(0x1bc), LayoutImmutable, Blittable, JsonProperty(Order = 444)]
	public bool UseStencil { get; set; } = true;
	
	[ContainerField(0x1bd), LayoutImmutable, Blittable, JsonProperty(Order = 445)]
	public bool UseMask { get; set; } = false;
	
	[ContainerField(0x1be), LayoutImmutable, Blittable, JsonProperty(Order = 446)]
	public bool RenderCombatArea { get; set; } = false;
	
	[ContainerField(0x1bf), LayoutImmutable, Blittable, JsonProperty(Order = 447)]
	public bool RenderCapturePointArea { get; set; } = false;
	
	[ContainerField(0x1c0), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
	public bool UseCapturePointAreaNeutralColor { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) WidgetType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(MaskName));
		p_Writer.WriteNullBytes(8);
		MinimapColor.Serialize(p_Writer, p_EbxWriter);
		JointColor.Serialize(p_Writer, p_EbxWriter);
		JointNameColor1.Serialize(p_Writer, p_EbxWriter);
		JointNameColor2.Serialize(p_Writer, p_EbxWriter);
		LineColor.Serialize(p_Writer, p_EbxWriter);
		AreaColor.Serialize(p_Writer, p_EbxWriter);
		SecondaryColor.Serialize(p_Writer, p_EbxWriter);
		CapturePointAreaNeutralColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(NativeViewWidth);
		p_Writer.Write(ViewVelocityExpandFactor);
		p_Writer.Write(ViewVelocityMin);
		p_Writer.Write(ViewVelocityMax);
		p_Writer.Write(p_EbxWriter.WriteString(JointImage));
		p_Writer.Write(p_EbxWriter.WriteImport(JointNameFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(JointNameSequence));
		p_Writer.Write(LineWidth);
		p_Writer.Write(PatternWidth);
		p_Writer.Write(PatternSoftness);
		p_Writer.Write(CapturePointAreaAlpha);
		p_Writer.Write(CapturePointBlinkRate);
		p_Writer.Write(UseStencil);
		p_Writer.Write(UseMask);
		p_Writer.Write(RenderCombatArea);
		p_Writer.Write(RenderCapturePointArea);
		p_Writer.Write(UseCapturePointAreaNeutralColor);
		p_Writer.WriteNullBytes(15);
	}
}

