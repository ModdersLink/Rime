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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 12)]
	public class UICreditsPage :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Header1 { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string Header2 { get; set; } = string.Empty;
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<UICreditsLine> Lines { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Header1));
			p_Writer.Write(p_EbxWriter.WriteString(Header2));
			(RimeWriter Writer, uint ArrayIndex) s_Lines = p_EbxWriter.GetArrayWriter(Lines.GetType(), Lines.Count);
			p_Writer.Write(s_Lines.ArrayIndex);
			foreach (var s_Entry in Lines)
			{
				s_Entry.Serialize(s_Lines.Writer, p_EbxWriter);
			}
		}
	}
}
