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
	[ContainerType(16, 96)]
	public class LensFlareEntityData :
		SpatialEntityData
	{
		[ContainerField(80), JsonProperty(Order = 80)]
		public List<LensFlareElement> Elements { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float OccluderSize { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public bool Visible { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		public bool HalfRes { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
		public bool DebugDrawOccluder { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Elements = p_EbxWriter.GetArrayWriter(Elements.GetType(), Elements.Count);
			p_Writer.Write(s_Elements.ArrayIndex);
			foreach (var s_Entry in Elements)
			{
				s_Entry.Serialize(s_Elements.Writer, p_EbxWriter);
			}
			p_Writer.Write(OccluderSize);
			p_Writer.Write(Visible);
			p_Writer.Write(HalfRes);
			p_Writer.Write(DebugDrawOccluder);
			p_Writer.WriteNullBytes(5);
		}
	}
}
