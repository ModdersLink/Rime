///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class PathfindingBlob
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public GUID BlobId { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint BlobSize { get; set; }
		
		[ContainerField(20)]
		public List<uint> ChunkSizes { get; set; } = new();
		
		public static void Deserialize(PathfindingBlob p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BlobId = new GUID(p_Reader);
			p_Instance.BlobSize = p_Reader.ReadUInt32();
			p_Instance.ChunkSizes.Clear();
			(RimeReader Reader, uint Count) s_ChunkSizes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ChunkSizes.Count; ++i)
			{
				var s_Value = s_ChunkSizes.Reader.ReadUInt32();
				p_Instance.ChunkSizes.Add(s_Value);
			}
			
			s_ChunkSizes.Reader.Dispose();
		}
	}
}
