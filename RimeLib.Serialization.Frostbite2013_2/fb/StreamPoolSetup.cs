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

using fb.Core;

namespace fb.Audio;

[ContainerType(8, 96)]
public class StreamPoolSetup
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint StreamBufferSizeXenon { get; set; } = 131072;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint StreamBufferSizePs3 { get; set; } = 32768;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint StreamBufferSizeWin32 { get; set; } = 32768;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint StreamBufferSizeGen4a { get; set; } = 32768;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint StreamBufferSizeGen4b { get; set; } = 32768;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint StreamBufferSizeMobile { get; set; } = 131072;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint StreamCountXenon { get; set; } = 1;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint StreamCountPs3 { get; set; } = 1;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint StreamCountWin32 { get; set; } = 1;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint StreamCountGen4a { get; set; } = 1;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint StreamCountGen4b { get; set; } = 1;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint StreamCountMobile { get; set; } = 1;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint StreamReadBlockSizeXenon { get; set; } = 0;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint StreamReadBlockSizePs3 { get; set; } = 0;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public uint StreamReadBlockSizeWin32 { get; set; } = 0;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint StreamReadBlockSizeGen4a { get; set; } = 0;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint StreamReadBlockSizeGen4b { get; set; } = 0;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public uint StreamReadBlockSizeMobile { get; set; } = 0;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public StreamStarveMode StreamStarveMode { get; set; } = fb.Audio.StreamStarveMode.StreamStarveMode_Off;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(StreamBufferSizeXenon);
		p_Writer.Write(StreamBufferSizePs3);
		p_Writer.Write(StreamBufferSizeWin32);
		p_Writer.Write(StreamBufferSizeGen4a);
		p_Writer.Write(StreamBufferSizeGen4b);
		p_Writer.Write(StreamBufferSizeMobile);
		p_Writer.Write(StreamCountXenon);
		p_Writer.Write(StreamCountPs3);
		p_Writer.Write(StreamCountWin32);
		p_Writer.Write(StreamCountGen4a);
		p_Writer.Write(StreamCountGen4b);
		p_Writer.Write(StreamCountMobile);
		p_Writer.Write(StreamReadBlockSizeXenon);
		p_Writer.Write(StreamReadBlockSizePs3);
		p_Writer.Write(StreamReadBlockSizeWin32);
		p_Writer.Write(StreamReadBlockSizeGen4a);
		p_Writer.Write(StreamReadBlockSizeGen4b);
		p_Writer.Write(StreamReadBlockSizeMobile);
		p_Writer.Write((int) StreamStarveMode);
		p_Writer.WriteNullBytes(4);
	}
}

