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

[ContainerType(8, 48)]
public class WebBrowserBundleAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string BundlePath { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<string> Fonts { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<string> LocalURLs { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(BundlePath));
		(RimeWriter Writer, uint ArrayIndex) s_Fonts = p_EbxWriter.GetArrayWriter(Fonts.GetType(), Fonts.Count);
		p_Writer.Write(s_Fonts.ArrayIndex);
		foreach (var s_Entry in Fonts)
		{
			s_Fonts.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LocalURLs = p_EbxWriter.GetArrayWriter(LocalURLs.GetType(), LocalURLs.Count);
		p_Writer.Write(s_LocalURLs.ArrayIndex);
		foreach (var s_Entry in LocalURLs)
		{
			s_LocalURLs.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

