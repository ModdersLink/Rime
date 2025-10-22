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

namespace fb.UI;

[ContainerType(8, 56)]
public class UIFontAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string SourceFile { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<UITextDatabase> TextDatabase { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<string> ScaleformFontName { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool NumericsOnly { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool Bold { get; set; } = false;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool CompleteKorean { get; set; } = false;
	
	[ContainerField(0x33), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
	public bool CompleteJapanese { get; set; } = false;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool CompleteTraditionalChinese { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(SourceFile));
		p_Writer.Write(p_EbxWriter.WriteImport(TextDatabase));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ScaleformFontName = p_EbxWriter.GetArrayWriter(ScaleformFontName.GetType(), ScaleformFontName.Count);
		p_Writer.Write(s_ScaleformFontName.ArrayIndex);
		foreach (var s_Entry in ScaleformFontName)
		{
			s_ScaleformFontName.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(NumericsOnly);
		p_Writer.Write(Bold);
		p_Writer.Write(CompleteKorean);
		p_Writer.Write(CompleteJapanese);
		p_Writer.Write(CompleteTraditionalChinese);
		p_Writer.WriteNullBytes(3);
	}
}

