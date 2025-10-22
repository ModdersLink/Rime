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

namespace fb.Terrain;

[ContainerType(8, 80)]
public class TerrainMeshScatteringType
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint Identifier { get; set; } = 9999999;
	
	[ContainerField(0x14), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public Vec2 MinScale { get; set; } = new()
	{
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x1c), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public Vec2 MaxScale { get; set; } = new()
	{
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float ScaleRandomness { get; set; } = 1.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public QualityScalableFloat Density { get; set; } = new()
	{
		Ultra = 1.000f,
		High = 1.000f,
		Medium = 1.000f,
		Low = 1.000f,
	};
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint FirstSpawnLevel { get; set; } = 0;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float WindScale { get; set; } = 0.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float Stiffness { get; set; } = 8.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float Damping { get; set; } = 1.600f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float Mass { get; set; } = 4.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float WindWiggle { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Identifier);
		MinScale.Serialize(p_Writer, p_EbxWriter);
		MaxScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ScaleRandomness);
		Density.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FirstSpawnLevel);
		p_Writer.Write(WindScale);
		p_Writer.Write(Stiffness);
		p_Writer.Write(Damping);
		p_Writer.Write(Mass);
		p_Writer.Write(WindWiggle);
	}
}

