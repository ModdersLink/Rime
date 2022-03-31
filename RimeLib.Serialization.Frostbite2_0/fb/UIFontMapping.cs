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
	[ContainerType(4, 8)]
	public class UIFontMapping :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<string> ScaleformFontName { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string FontLongName { get; set; } = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ScaleformFontName = p_EbxWriter.GetArrayWriter(ScaleformFontName.GetType(), ScaleformFontName.Count);
			p_Writer.Write(s_ScaleformFontName.ArrayIndex);
			foreach (var s_Entry in ScaleformFontName)
			{
				s_ScaleformFontName.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteString(FontLongName));
		}
	}
}
