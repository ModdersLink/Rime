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
	[ContainerType(4, 16)]
	public class PropertyTrackData :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public int Id { get; set; }

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<int> Times { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Id);
			(RimeWriter Writer, uint ArrayIndex) s_Times = p_EbxWriter.GetArrayWriter(Times.GetType(), Times.Count);
			p_Writer.Write(s_Times.ArrayIndex);
			foreach (var s_Entry in Times)
			{
				s_Times.Writer.Write(s_Entry);
			}
		}
	}
}
