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
using fb.Entity;

namespace fb.RailRideHeli;

[ContainerType(16, 96)]
public class RailRideHeliSegmentData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int StartIndex { get; set; } = 0;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec4 EditorColor { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int EndIndex { get; set; } = -1;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int NodeIndex1 { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int NodeIndex2 { get; set; } = 0;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int NodeIndex3 { get; set; } = 0;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float ExternalTime { get; set; } = 0.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float StartDelay { get; set; } = 0.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float WaypointsSpeedScale { get; set; } = 1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool Looping { get; set; } = false;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool TeleportOnActivate { get; set; } = false;
	
	[ContainerField(0x4e), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
	public bool ForceSpeedOnActivate { get; set; } = false;
	
	[ContainerField(0x4f), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
	public bool ForceDirectionOnActivate { get; set; } = false;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool TeleportOnLoop { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool OldRailCompatibility { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(StartIndex);
		p_Writer.WriteNullBytes(4);
		EditorColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(EndIndex);
		p_Writer.Write(NodeIndex1);
		p_Writer.Write(NodeIndex2);
		p_Writer.Write(NodeIndex3);
		p_Writer.Write(ExternalTime);
		p_Writer.Write(StartDelay);
		p_Writer.Write(WaypointsSpeedScale);
		p_Writer.Write(Looping);
		p_Writer.Write(TeleportOnActivate);
		p_Writer.Write(ForceSpeedOnActivate);
		p_Writer.Write(ForceDirectionOnActivate);
		p_Writer.Write(TeleportOnLoop);
		p_Writer.Write(OldRailCompatibility);
		p_Writer.WriteNullBytes(14);
	}
}

