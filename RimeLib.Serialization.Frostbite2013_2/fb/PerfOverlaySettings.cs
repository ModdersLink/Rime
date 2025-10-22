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

namespace fb.Render;

[ContainerType(8, 64)]
public class PerfOverlaySettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint DrawGraphMethod { get; set; } = 0;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint DrawFpsMethod { get; set; } = 0;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float FcatWidth { get; set; } = 20.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint LegendDisplayFormat { get; set; } = 0;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float FpsTimePeriod { get; set; } = 0.500f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint FrameTimeSource { get; set; } = 0;
	
	[ContainerField(0x28), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public Vec2 GraphPos { get; set; } = new()
	{
		y = -1.000f,
		x = -1.000f,
	};
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool DrawGraph { get; set; } = false;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool DrawCpuGraph { get; set; } = true;
	
	[ContainerField(0x33), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
	public bool DrawGpuGraph { get; set; } = true;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool DrawFrameGraph { get; set; } = false;
	
	[ContainerField(0x35), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
	public bool DrawFps { get; set; } = true;
	
	[ContainerField(0x36), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
	public bool DrawFcat { get; set; } = false;
	
	[ContainerField(0x37), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
	public bool TargetFpsIs60 { get; set; } = false;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool FrameFileLogEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DrawGraphMethod);
		p_Writer.Write(DrawFpsMethod);
		p_Writer.Write(FcatWidth);
		p_Writer.Write(LegendDisplayFormat);
		p_Writer.Write(FpsTimePeriod);
		p_Writer.Write(FrameTimeSource);
		GraphPos.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Enable);
		p_Writer.Write(DrawGraph);
		p_Writer.Write(DrawCpuGraph);
		p_Writer.Write(DrawGpuGraph);
		p_Writer.Write(DrawFrameGraph);
		p_Writer.Write(DrawFps);
		p_Writer.Write(DrawFcat);
		p_Writer.Write(TargetFpsIs60);
		p_Writer.Write(FrameFileLogEnable);
		p_Writer.WriteNullBytes(7);
	}
}

