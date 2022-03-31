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
	[ContainerType(4, 24)]
	public class PathfindingBlob :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public GUID BlobId { get; set; } = GUID.Empty;
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint BlobSize { get; set; }
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public List<uint> ChunkSizes { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			BlobId.Serialize(p_Writer);
			p_Writer.Write(BlobSize);
			(RimeWriter Writer, uint ArrayIndex) s_ChunkSizes = p_EbxWriter.GetArrayWriter(ChunkSizes.GetType(), ChunkSizes.Count);
			p_Writer.Write(s_ChunkSizes.ArrayIndex);
			foreach (var s_Entry in ChunkSizes)
			{
				s_ChunkSizes.Writer.Write(s_Entry);
			}
		}
	}
}
