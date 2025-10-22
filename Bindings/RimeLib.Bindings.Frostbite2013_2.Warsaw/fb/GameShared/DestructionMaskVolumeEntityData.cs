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

using fb.Render;
using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 176)]
public class DestructionMaskVolumeEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec4 DustAccumulationCurve { get; set; } = new()
	{
		w = 1.933f,
		z = -0.951f,
		y = 2.747f,
		x = -4.085f,
	};
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec4 ShaderUserMasks { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float Radius { get; set; } = 10.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float DustAccumulationLifeTime { get; set; } = 3.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public SurfaceShaderInstanceDataStruct Shader { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		DustAccumulationCurve.Serialize(p_Writer, p_EbxWriter);
		ShaderUserMasks.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Radius);
		p_Writer.Write(DustAccumulationLifeTime);
		Shader.Serialize(p_Writer, p_EbxWriter);
	}
}

