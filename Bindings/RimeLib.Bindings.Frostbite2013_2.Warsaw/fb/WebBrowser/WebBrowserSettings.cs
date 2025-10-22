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

namespace fb.WebBrowser;

[ContainerType(8, 120)]
public class WebBrowserSettings
	: fb.Core.SystemSettings
{
	public WebBrowserSettings()
	{
		//SystemSettings
		Name = @"WebBrowser";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string ApplicationName { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string StandardFont { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string SerifFont { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string SansSerifFont { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string MonospaceFont { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string CursiveFont { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string FantasyFont { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string SystemFont { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string DefaultCSS { get; set; } = @"html {-webkit-user-select: none;}";
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<WebBrowserBundleAsset> WebBrowserBundle { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool SystemFontBold { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ApplicationName));
		p_Writer.Write(p_EbxWriter.WriteString(StandardFont));
		p_Writer.Write(p_EbxWriter.WriteString(SerifFont));
		p_Writer.Write(p_EbxWriter.WriteString(SansSerifFont));
		p_Writer.Write(p_EbxWriter.WriteString(MonospaceFont));
		p_Writer.Write(p_EbxWriter.WriteString(CursiveFont));
		p_Writer.Write(p_EbxWriter.WriteString(FantasyFont));
		p_Writer.Write(p_EbxWriter.WriteString(SystemFont));
		p_Writer.Write(p_EbxWriter.WriteString(DefaultCSS));
		p_Writer.Write(p_EbxWriter.WriteImport(WebBrowserBundle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SystemFontBold);
		p_Writer.WriteNullBytes(7);
	}
}

