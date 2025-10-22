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

[ContainerType(16, 240)]
public class UITabBarWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<UITabBarButton> Buttons { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string DefaultIndexProperty { get; set; } = string.Empty;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor NewContentIconColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<UIElementFillData> BackgroundFillData { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UIElementButtonStyle> ButtonStyle { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<UIElementButtonStyle> DisabledButtonStyle { get; set; } = new();
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float VisibilityAnimationSpeed { get; set; } = 0.100f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public uint MaxVisibleButtons { get; set; } = 100;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float ButtonSpacing { get; set; } = 0.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float NavPadding { get; set; } = 0.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public string NavArrowTexture { get; set; } = string.Empty;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public string NewContentIconName { get; set; } = string.Empty;
	
	[ContainerField(0xd8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public Vec2 NewContentIconPadding { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec2 NewContentIconScaling { get; set; } = new()
	{
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public int SelectedTab { get; set; } = 0;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public bool UseTabButtons { get; set; } = true;
	
	[ContainerField(0xed), LayoutImmutable, Blittable, JsonProperty(Order = 237)]
	public bool UseDPad { get; set; } = false;
	
	[ContainerField(0xee), LayoutImmutable, Blittable, JsonProperty(Order = 238)]
	public bool UseStick { get; set; } = false;
	
	[ContainerField(0xef), LayoutImmutable, Blittable, JsonProperty(Order = 239)]
	public bool DistributeSizeEqually { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Buttons = p_EbxWriter.GetArrayWriter(Buttons.GetType(), Buttons.Count);
		p_Writer.Write(s_Buttons.ArrayIndex);
		foreach (var s_Entry in Buttons)
		{
			s_Entry.Serialize(s_Buttons.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(DefaultIndexProperty));
		p_Writer.WriteNullBytes(8);
		NewContentIconColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(BackgroundFillData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ButtonStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DisabledButtonStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(VisibilityAnimationSpeed);
		p_Writer.Write(MaxVisibleButtons);
		p_Writer.Write(ButtonSpacing);
		p_Writer.Write(NavPadding);
		p_Writer.Write(p_EbxWriter.WriteString(NavArrowTexture));
		p_Writer.Write(p_EbxWriter.WriteString(NewContentIconName));
		NewContentIconPadding.Serialize(p_Writer, p_EbxWriter);
		NewContentIconScaling.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SelectedTab);
		p_Writer.Write(UseTabButtons);
		p_Writer.Write(UseDPad);
		p_Writer.Write(UseStick);
		p_Writer.Write(DistributeSizeEqually);
	}
}

