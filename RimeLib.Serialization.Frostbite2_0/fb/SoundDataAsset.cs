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
	[ContainerType(4, 20)]
	public class SoundDataAsset :
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint NameHash { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<SoundDataChunk> Chunks { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(NameHash);
			(RimeWriter Writer, uint ArrayIndex) s_Chunks = p_EbxWriter.GetArrayWriter(Chunks.GetType(), Chunks.Count);
			p_Writer.Write(s_Chunks.ArrayIndex);
			foreach (var s_Entry in Chunks)
			{
				s_Entry.Serialize(s_Chunks.Writer, p_EbxWriter);
			}
		}
	}
}
