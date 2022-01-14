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
	[ContainerType(16, 112)]
	public class StreamGridEntityData :
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float CellSize { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float ViewDistance { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public int MaxStreamInCountPerFrame { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public int MaxStreamOutCountPerFrame { get; set; }

		[ContainerField(96), JsonProperty(Order = 96)]
		public List<StreamGridCell> Cells { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CellSize);
			p_Writer.Write(ViewDistance);
			p_Writer.Write(MaxStreamInCountPerFrame);
			p_Writer.Write(MaxStreamOutCountPerFrame);
			(RimeWriter Writer, uint ArrayIndex) s_Cells = p_EbxWriter.GetArrayWriter(Cells.GetType(), Cells.Count);
			p_Writer.Write(s_Cells.ArrayIndex);
			foreach (var s_Entry in Cells)
			{
				s_Entry.Serialize(s_Cells.Writer, p_EbxWriter);
			}
			p_Writer.WriteNullBytes(12);
		}
	}
}
