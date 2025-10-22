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


namespace fb.Core;

[ContainerType(8, 48)]
public class DebugRenderSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float TextViewDistance { get; set; } = 100.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint TextQueueMaxLineCount { get; set; } = 10;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float TextQueueTimeVisible { get; set; } = 1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int ProcessJobCount { get; set; } = -1;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint Ps3SpuFrameBufferSize { get; set; } = 2097152;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint DxMaxVertexCount { get; set; } = 131072;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x29), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
	public bool DrawStatsEnable { get; set; } = false;
	
	[ContainerField(0x2a), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
	public bool TextQueueLocationTop { get; set; } = true;
	
	[ContainerField(0x2b), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
	public bool Ps3SpuEnable { get; set; } = false;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public bool DxLine2dAntialiasingEnable { get; set; } = false;
	
	[ContainerField(0x2d), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
	public bool DxLine3dAntialiasingEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TextViewDistance);
		p_Writer.Write(TextQueueMaxLineCount);
		p_Writer.Write(TextQueueTimeVisible);
		p_Writer.Write(ProcessJobCount);
		p_Writer.Write(Ps3SpuFrameBufferSize);
		p_Writer.Write(DxMaxVertexCount);
		p_Writer.Write(Enable);
		p_Writer.Write(DrawStatsEnable);
		p_Writer.Write(TextQueueLocationTop);
		p_Writer.Write(Ps3SpuEnable);
		p_Writer.Write(DxLine2dAntialiasingEnable);
		p_Writer.Write(DxLine3dAntialiasingEnable);
		p_Writer.WriteNullBytes(2);
	}
}

