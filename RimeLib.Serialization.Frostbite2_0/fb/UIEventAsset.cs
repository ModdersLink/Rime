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
	[ContainerType(4, 20)]
	public class UIEventAsset :
		Asset
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string Category { get; set; } = string.Empty;

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<string> EventList { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Category));
			(RimeWriter Writer, uint ArrayIndex) s_EventList = p_EbxWriter.GetArrayWriter(EventList.GetType(), EventList.Count);
			p_Writer.Write(s_EventList.ArrayIndex);
			foreach (var s_Entry in EventList)
			{
				s_EventList.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
		}
	}
}
