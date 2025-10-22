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

namespace fb.VeniceShared;

[ContainerType(8, 88)]
public class UISurveyQuestionCompData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string Title { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string Question { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string LeftExtreme { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string RightExtreme { get; set; } = string.Empty;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public List<SurveyButton> Buttons { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Title));
		p_Writer.Write(p_EbxWriter.WriteString(Question));
		p_Writer.Write(p_EbxWriter.WriteString(LeftExtreme));
		p_Writer.Write(p_EbxWriter.WriteString(RightExtreme));
		(RimeWriter Writer, uint ArrayIndex) s_Buttons = p_EbxWriter.GetArrayWriter(Buttons.GetType(), Buttons.Count);
		p_Writer.Write(s_Buttons.ArrayIndex);
		foreach (var s_Entry in Buttons)
		{
			s_Entry.Serialize(s_Buttons.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

