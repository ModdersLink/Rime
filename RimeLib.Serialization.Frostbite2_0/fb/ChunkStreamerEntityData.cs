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
	[ContainerType(4, 16)]
	public class ChunkStreamerEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<ChunkStreamerCell> Cells { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Cells = p_EbxWriter.GetArrayWriter(Cells.GetType(), Cells.Count);
			p_Writer.Write(s_Cells.ArrayIndex);
			foreach (var s_Entry in Cells)
			{
				s_Entry.Serialize(s_Cells.Writer, p_EbxWriter);
			}
		}
	}
}
