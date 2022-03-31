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
	[ContainerType(4, 56)]
	public class StreamPoolAsset :
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint StreamPoolId { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint StreamBufferSizeXenon { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint StreamBufferSizePs3 { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint StreamBufferSizeWin32 { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint StreamCountXenon { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint StreamCountPs3 { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint StreamCountWin32 { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint StreamReadBlockSizeXenon { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public uint StreamReadBlockSizePs3 { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public uint StreamReadBlockSizeWin32 { get; set; }

		[ContainerField(52), JsonProperty(Order = 52)]
		public StreamStarveMode StreamStarveMode { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StreamPoolId);
			p_Writer.Write(StreamBufferSizeXenon);
			p_Writer.Write(StreamBufferSizePs3);
			p_Writer.Write(StreamBufferSizeWin32);
			p_Writer.Write(StreamCountXenon);
			p_Writer.Write(StreamCountPs3);
			p_Writer.Write(StreamCountWin32);
			p_Writer.Write(StreamReadBlockSizeXenon);
			p_Writer.Write(StreamReadBlockSizePs3);
			p_Writer.Write(StreamReadBlockSizeWin32);
			p_Writer.Write((int) StreamStarveMode);
		}
	}
}
