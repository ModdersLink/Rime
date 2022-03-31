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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 60)]
	public class DialogNode :
		StateNode
	{
		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string DialogTitle { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		public string DialogText { get; set; } = string.Empty;

		[ContainerField(56), JsonProperty(Order = 56)]
		public List<UIPopupButton> Buttons { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(DialogTitle));
			p_Writer.Write(p_EbxWriter.WriteString(DialogText));
			(RimeWriter Writer, uint ArrayIndex) s_Buttons = p_EbxWriter.GetArrayWriter(Buttons.GetType(), Buttons.Count);
			p_Writer.Write(s_Buttons.ArrayIndex);
			foreach (var s_Entry in Buttons)
			{
				s_Entry.Serialize(s_Buttons.Writer, p_EbxWriter);
			}
		}
	}
}
