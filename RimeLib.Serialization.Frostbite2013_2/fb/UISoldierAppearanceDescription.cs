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

[ContainerType(8, 128)]
public class UISoldierAppearanceDescription
	: fb.VeniceShared.UIItemDescription
{
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Name { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string UnlockName { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public RarenessLevel RarenessLevel { get; set; } = fb.VeniceShared.RarenessLevel.RarenessLevel_Standard;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string Description { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string Category { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string TexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string IconTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string UnlockTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public UIHudIcon HudIcon { get; set; } = UIHudIcon.UIHudIcon_Unused;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public List<string> RequiredLicensesToShow { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public bool HiddenInProgression { get; set; } = false;
	
	[ContainerField(0x79), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
	public bool NotExplicitelySelectable { get; set; } = false;
	
	[ContainerField(0x7a), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
	public bool HideIfNotUnlocked { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Name));
		p_Writer.Write(p_EbxWriter.WriteString(UnlockName));
		p_Writer.Write((int) RarenessLevel);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Description));
		p_Writer.Write(p_EbxWriter.WriteString(Category));
		p_Writer.Write(p_EbxWriter.WriteString(TexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(IconTexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(UnlockTexturePath));
		p_Writer.Write((int) HudIcon);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_RequiredLicensesToShow = p_EbxWriter.GetArrayWriter(RequiredLicensesToShow.GetType(), RequiredLicensesToShow.Count);
		p_Writer.Write(s_RequiredLicensesToShow.ArrayIndex);
		foreach (var s_Entry in RequiredLicensesToShow)
		{
			s_RequiredLicensesToShow.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HiddenInProgression);
		p_Writer.Write(NotExplicitelySelectable);
		p_Writer.Write(HideIfNotUnlocked);
		p_Writer.WriteNullBytes(5);
	}
}

