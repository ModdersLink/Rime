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

namespace fb.VeniceShared;

[ContainerType(8, 168)]
public class UIWeaponDescription
	: fb.VeniceShared.UIItemDescription
{
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Name { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string UnlockName { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string Description { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string Category { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string TexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string IconTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string UnlockTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string Ammo { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string RateOfFire { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string AmmoType { get; set; } = string.Empty;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public string Range { get; set; } = string.Empty;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float StatDamage { get; set; } = 0.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float StatAccuracy { get; set; } = 0.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float StatMobility { get; set; } = 0.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float StatRange { get; set; } = 0.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float StatHandling { get; set; } = 0.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public RarenessLevel RarenessLevel { get; set; } = fb.VeniceShared.RarenessLevel.RarenessLevel_Standard;
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public List<string> RequiredLicensesToShow { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool FireModeSingle { get; set; } = false;
	
	[ContainerField(0xa1), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
	public bool FireModeBurst { get; set; } = false;
	
	[ContainerField(0xa2), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
	public bool FireModeAuto { get; set; } = false;
	
	[ContainerField(0xa3), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
	public bool HiddenInProgression { get; set; } = false;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public bool HideIfNotUnlocked { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Name));
		p_Writer.Write(p_EbxWriter.WriteString(UnlockName));
		p_Writer.Write(p_EbxWriter.WriteString(Description));
		p_Writer.Write(p_EbxWriter.WriteString(Category));
		p_Writer.Write(p_EbxWriter.WriteString(TexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(IconTexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(UnlockTexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(Ammo));
		p_Writer.Write(p_EbxWriter.WriteString(RateOfFire));
		p_Writer.Write(p_EbxWriter.WriteString(AmmoType));
		p_Writer.Write(p_EbxWriter.WriteString(Range));
		p_Writer.Write(StatDamage);
		p_Writer.Write(StatAccuracy);
		p_Writer.Write(StatMobility);
		p_Writer.Write(StatRange);
		p_Writer.Write(StatHandling);
		p_Writer.Write((int) RarenessLevel);
		(RimeWriter Writer, uint ArrayIndex) s_RequiredLicensesToShow = p_EbxWriter.GetArrayWriter(RequiredLicensesToShow.GetType(), RequiredLicensesToShow.Count);
		p_Writer.Write(s_RequiredLicensesToShow.ArrayIndex);
		foreach (var s_Entry in RequiredLicensesToShow)
		{
			s_RequiredLicensesToShow.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FireModeSingle);
		p_Writer.Write(FireModeBurst);
		p_Writer.Write(FireModeAuto);
		p_Writer.Write(HiddenInProgression);
		p_Writer.Write(HideIfNotUnlocked);
		p_Writer.WriteNullBytes(3);
	}
}

