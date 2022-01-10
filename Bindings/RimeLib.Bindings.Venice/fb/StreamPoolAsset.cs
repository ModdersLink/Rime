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
	[ContainerType(4, 56)]
	public class StreamPoolAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint StreamPoolId { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint StreamBufferSizeXenon { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint StreamBufferSizePs3 { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint StreamBufferSizeWin32 { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint StreamCountXenon { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint StreamCountPs3 { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint StreamCountWin32 { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint StreamReadBlockSizeXenon { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public uint StreamReadBlockSizePs3 { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public uint StreamReadBlockSizeWin32 { get; set; }

		[ContainerField(52)]
		public StreamStarveMode StreamStarveMode { get; set; } = new();

		public static void Deserialize(StreamPoolAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.StreamPoolId = p_Reader.ReadUInt32();
			p_Instance.StreamBufferSizeXenon = p_Reader.ReadUInt32();
			p_Instance.StreamBufferSizePs3 = p_Reader.ReadUInt32();
			p_Instance.StreamBufferSizeWin32 = p_Reader.ReadUInt32();
			p_Instance.StreamCountXenon = p_Reader.ReadUInt32();
			p_Instance.StreamCountPs3 = p_Reader.ReadUInt32();
			p_Instance.StreamCountWin32 = p_Reader.ReadUInt32();
			p_Instance.StreamReadBlockSizeXenon = p_Reader.ReadUInt32();
			p_Instance.StreamReadBlockSizePs3 = p_Reader.ReadUInt32();
			p_Instance.StreamReadBlockSizeWin32 = p_Reader.ReadUInt32();
			p_Instance.StreamStarveMode = (StreamStarveMode) p_Reader.ReadInt32();
		}

	}
}
