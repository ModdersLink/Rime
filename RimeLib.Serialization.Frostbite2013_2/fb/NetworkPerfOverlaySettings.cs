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

[ContainerType(8, 40)]
public class NetworkPerfOverlaySettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint LegendDisplayFormat { get; set; } = 1;
	
	[ContainerField(0x14), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public Vec2 GraphPos { get; set; } = new()
	{
		y = -1.000f,
		x = -1.000f,
	};
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x1d), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
	public bool DrawGraph { get; set; } = false;
	
	[ContainerField(0x1e), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
	public bool DrawNetworkDelayGraph { get; set; } = true;
	
	[ContainerField(0x1f), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
	public bool DrawNetworkVariationGraph { get; set; } = true;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool DrawPacketLossGraph { get; set; } = true;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool DrawFreqGraph { get; set; } = true;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public bool DrawDownStreamGraph { get; set; } = true;
	
	[ContainerField(0x23), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
	public bool DrawProjectileGraph { get; set; } = true;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool DrawServerFps { get; set; } = true;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool DrawBehindServerTime { get; set; } = true;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool DrawReceiveRateGraph { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LegendDisplayFormat);
		GraphPos.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Enable);
		p_Writer.Write(DrawGraph);
		p_Writer.Write(DrawNetworkDelayGraph);
		p_Writer.Write(DrawNetworkVariationGraph);
		p_Writer.Write(DrawPacketLossGraph);
		p_Writer.Write(DrawFreqGraph);
		p_Writer.Write(DrawDownStreamGraph);
		p_Writer.Write(DrawProjectileGraph);
		p_Writer.Write(DrawServerFps);
		p_Writer.Write(DrawBehindServerTime);
		p_Writer.Write(DrawReceiveRateGraph);
		p_Writer.WriteNullBytes(1);
	}
}

