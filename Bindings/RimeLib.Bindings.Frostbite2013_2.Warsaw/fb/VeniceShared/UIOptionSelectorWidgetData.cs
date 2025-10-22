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

[ContainerType(8, 136)]
public class UIOptionSelectorWidgetData
	: fb.VeniceShared.UIPageChildWidgetData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<string> Options { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public List<string> OptionValues { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float MinAlpha { get; set; } = 0.300f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float BlinkFrequency { get; set; } = 5.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float FlashTime { get; set; } = 0.500f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Options = p_EbxWriter.GetArrayWriter(Options.GetType(), Options.Count);
		p_Writer.Write(s_Options.ArrayIndex);
		foreach (var s_Entry in Options)
		{
			s_Options.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OptionValues = p_EbxWriter.GetArrayWriter(OptionValues.GetType(), OptionValues.Count);
		p_Writer.Write(s_OptionValues.ArrayIndex);
		foreach (var s_Entry in OptionValues)
		{
			s_OptionValues.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MinAlpha);
		p_Writer.Write(BlinkFrequency);
		p_Writer.Write(FlashTime);
		p_Writer.WriteNullBytes(4);
	}
}

