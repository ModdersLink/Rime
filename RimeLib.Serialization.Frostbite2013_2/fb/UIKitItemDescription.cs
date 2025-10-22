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

[ContainerType(16, 176)]
public class UIKitItemDescription
	: fb.VeniceShared.UIItemDescription
{
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Name { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string UnlockName { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string Description { get; set; } = string.Empty;
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec4 CamoBackground { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec4 CamoColor1 { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec4 CamoColor2 { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec4 CamoColor3 { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public string Category { get; set; } = string.Empty;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public string TexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public string IconTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public string UnlockTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public UIHudIcon HudIcon { get; set; } = UIHudIcon.UIHudIcon_Unused;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public RarenessLevel RarenessLevel { get; set; } = fb.VeniceShared.RarenessLevel.RarenessLevel_Standard;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public bool HiddenInProgression { get; set; } = false;
	
	[ContainerField(0xa9), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
	public bool NotExplicitelySelectable { get; set; } = false;
	
	[ContainerField(0xaa), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
	public bool UseCamoShader { get; set; } = false;
	
	[ContainerField(0xab), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
	public bool CamoAdaptiveColors { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Name));
		p_Writer.Write(p_EbxWriter.WriteString(UnlockName));
		p_Writer.Write(p_EbxWriter.WriteString(Description));
		CamoBackground.Serialize(p_Writer, p_EbxWriter);
		CamoColor1.Serialize(p_Writer, p_EbxWriter);
		CamoColor2.Serialize(p_Writer, p_EbxWriter);
		CamoColor3.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Category));
		p_Writer.Write(p_EbxWriter.WriteString(TexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(IconTexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(UnlockTexturePath));
		p_Writer.Write((int) HudIcon);
		p_Writer.Write((int) RarenessLevel);
		p_Writer.Write(HiddenInProgression);
		p_Writer.Write(NotExplicitelySelectable);
		p_Writer.Write(UseCamoShader);
		p_Writer.Write(CamoAdaptiveColors);
		p_Writer.WriteNullBytes(4);
	}
}

