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
	public class ChunkStreamerCell :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<Vec2> Shape { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string BundleName { get; set; } = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Shape = p_EbxWriter.GetArrayWriter(Shape.GetType(), Shape.Count);
			p_Writer.Write(s_Shape.ArrayIndex);
			foreach (var s_Entry in Shape)
			{
				s_Entry.Serialize(s_Shape.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteString(BundleName));
		}
	}
}
