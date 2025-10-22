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

[ContainerType(8, 56)]
public class UIOptionControlTextFieldMapping_BothChanging
	: fb.VeniceShared.UIOptionControlTextFieldMapping
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<string> ButtonOn1Text { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<string> ButtonOn2Text { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<string> ButtonOn3Text { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<string> ButtonOn4Text { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ButtonOn1Text = p_EbxWriter.GetArrayWriter(ButtonOn1Text.GetType(), ButtonOn1Text.Count);
		p_Writer.Write(s_ButtonOn1Text.ArrayIndex);
		foreach (var s_Entry in ButtonOn1Text)
		{
			s_ButtonOn1Text.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ButtonOn2Text = p_EbxWriter.GetArrayWriter(ButtonOn2Text.GetType(), ButtonOn2Text.Count);
		p_Writer.Write(s_ButtonOn2Text.ArrayIndex);
		foreach (var s_Entry in ButtonOn2Text)
		{
			s_ButtonOn2Text.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ButtonOn3Text = p_EbxWriter.GetArrayWriter(ButtonOn3Text.GetType(), ButtonOn3Text.Count);
		p_Writer.Write(s_ButtonOn3Text.ArrayIndex);
		foreach (var s_Entry in ButtonOn3Text)
		{
			s_ButtonOn3Text.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ButtonOn4Text = p_EbxWriter.GetArrayWriter(ButtonOn4Text.GetType(), ButtonOn4Text.Count);
		p_Writer.Write(s_ButtonOn4Text.ArrayIndex);
		foreach (var s_Entry in ButtonOn4Text)
		{
			s_ButtonOn4Text.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

