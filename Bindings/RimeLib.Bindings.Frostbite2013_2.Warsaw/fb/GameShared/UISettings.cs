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
using fb.UI;

namespace fb.GameShared;

[ContainerType(8, 80)]
public class UISettings
	: fb.Core.SystemSettings
{
	public UISettings()
	{
		//SystemSettings
		Name = @"UI";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public UISystemType System { get; set; } = UISystemType.UISystem_None;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<UIBundlesAsset> Bundles { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<ProfileOptionsAsset> ProfileOptions { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public LanguageFormat Language { get; set; } = LanguageFormat.LanguageFormat_English;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<UIImmediateModeFontConfigurationAsset> FontConfiguration { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool OneBundlePerGraph { get; set; } = false;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool DrawEnable { get; set; } = true;
	
	[ContainerField(0x4a), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
	public bool JobsEnabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) System);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Bundles));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ProfileOptions));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Language);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FontConfiguration));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(OneBundlePerGraph);
		p_Writer.Write(DrawEnable);
		p_Writer.Write(JobsEnabled);
		p_Writer.WriteNullBytes(5);
	}
}

