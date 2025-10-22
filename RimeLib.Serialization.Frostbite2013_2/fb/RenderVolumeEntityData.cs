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
using fb.Render;
using fb.Entity;

namespace fb.WorldRender;

[ContainerType(16, 160)]
public class RenderVolumeEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec4 UserMasks { get; set; } = new()
	{
		w = 1.000f,
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public SurfaceShaderInstanceDataStruct Shader { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public RenderVolumeTransformType TransformType { get; set; } = RenderVolumeTransformType.RenderVolumeTransformType_WorldSpaceInv;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public bool Enabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		UserMasks.Serialize(p_Writer, p_EbxWriter);
		Shader.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) TransformType);
		p_Writer.Write(Enabled);
		p_Writer.WriteNullBytes(3);
	}
}

