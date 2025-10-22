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

[ContainerType(8, 128)]
public class DogTagData
	: fb.GameShared.UnlockAssetBase
{
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string NameSID { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string DescriptionSID { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string ImageName { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public RarenessLevel RarenessLevel { get; set; } = fb.VeniceShared.RarenessLevel.RarenessLevel_Standard;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string SmallImageName { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public DogTagCategory Category { get; set; } = DogTagCategory.DTC_Invalid;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool InvertText { get; set; } = false;
	
	[ContainerField(0x75), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
	public bool IsAlwaysAvailable { get; set; } = false;
	
	[ContainerField(0x76), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
	public bool ExcludedOnXenon { get; set; } = false;
	
	[ContainerField(0x77), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
	public bool ExcludedOnPs3 { get; set; } = false;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public bool ExcludedOnWin32 { get; set; } = false;
	
	[ContainerField(0x79), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
	public bool ExcludedOnGen4a { get; set; } = false;
	
	[ContainerField(0x7a), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
	public bool ExcludedOnGen4b { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(NameSID));
		p_Writer.Write(p_EbxWriter.WriteString(DescriptionSID));
		p_Writer.Write(p_EbxWriter.WriteString(ImageName));
		p_Writer.Write((int) RarenessLevel);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(SmallImageName));
		p_Writer.Write((int) Category);
		p_Writer.Write(InvertText);
		p_Writer.Write(IsAlwaysAvailable);
		p_Writer.Write(ExcludedOnXenon);
		p_Writer.Write(ExcludedOnPs3);
		p_Writer.Write(ExcludedOnWin32);
		p_Writer.Write(ExcludedOnGen4a);
		p_Writer.Write(ExcludedOnGen4b);
		p_Writer.WriteNullBytes(5);
	}
}

