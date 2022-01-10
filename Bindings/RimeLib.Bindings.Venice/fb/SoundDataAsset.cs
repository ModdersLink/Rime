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
	[ContainerType(4, 20)]
	public class SoundDataAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint NameHash { get; set; }

		[ContainerField(16)]
		public List<SoundDataChunk> Chunks { get; set; } = new();

		public static void Deserialize(SoundDataAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.NameHash = p_Reader.ReadUInt32();
			p_Instance.Chunks.Clear();
			(RimeReader Reader, uint Count) s_Chunks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Chunks.Count; ++i)
			{
				var s_Value = new SoundDataChunk();
				fb.SoundDataChunk.Deserialize(s_Value, s_Chunks.Reader, p_Parser);
				p_Instance.Chunks.Add(s_Value);
			}
			
			s_Chunks.Reader.Dispose();
		}

	}
}
