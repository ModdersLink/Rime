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

using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 144)]
public class UIOptionsListWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string ActivationString { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string TabName { get; set; } = string.Empty;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public List<UIOptionsOption> Options { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<UIWidgetBlueprint> SelectorTemplate { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<UIWidgetBlueprint> SliderTemplate { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ActivationString));
		p_Writer.Write(p_EbxWriter.WriteString(TabName));
		(RimeWriter Writer, uint ArrayIndex) s_Options = p_EbxWriter.GetArrayWriter(Options.GetType(), Options.Count);
		p_Writer.Write(s_Options.ArrayIndex);
		foreach (var s_Entry in Options)
		{
			s_Entry.Serialize(s_Options.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectorTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SliderTemplate));
		p_Writer.WriteNullBytes(4);
	}
}

