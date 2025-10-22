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

[ContainerType(8, 120)]
public class UIWeaponAccessoryDescription
	: fb.VeniceShared.UIItemDescription
{
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Name { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string Description { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string Category { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string TexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string IconTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string UnlockTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public RarenessLevel RarenessLevel { get; set; } = fb.VeniceShared.RarenessLevel.RarenessLevel_Standard;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float StatDamage { get; set; } = 1.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float StatAccuracy { get; set; } = 1.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float StatMobility { get; set; } = 1.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float StatRange { get; set; } = 1.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float StatHandling { get; set; } = 1.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool CoreAccessory { get; set; } = false;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool HiddenInProgression { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Name));
		p_Writer.Write(p_EbxWriter.WriteString(Description));
		p_Writer.Write(p_EbxWriter.WriteString(Category));
		p_Writer.Write(p_EbxWriter.WriteString(TexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(IconTexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(UnlockTexturePath));
		p_Writer.Write((int) RarenessLevel);
		p_Writer.Write(StatDamage);
		p_Writer.Write(StatAccuracy);
		p_Writer.Write(StatMobility);
		p_Writer.Write(StatRange);
		p_Writer.Write(StatHandling);
		p_Writer.Write(CoreAccessory);
		p_Writer.Write(HiddenInProgression);
		p_Writer.WriteNullBytes(6);
	}
}

