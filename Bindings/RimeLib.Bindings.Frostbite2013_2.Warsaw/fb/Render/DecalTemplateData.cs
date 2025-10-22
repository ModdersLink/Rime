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

[ContainerType(8, 120)]
public class DecalTemplateData
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float Size { get; set; } = 1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float RandomSize { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float Rotation { get; set; } = 0.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float RandomRotation { get; set; } = 0.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float ClipAngle { get; set; } = 70.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float ProximityRadiusFactor { get; set; } = 0.500f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float NormalOffset { get; set; } = 0.001f;
	
	[ContainerField(0x34), JsonProperty(Order = 52)]
	public DecalAtlasTile AtlasTile { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public SurfaceShaderInstanceDataStruct Shader { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public int MeshUVIndex { get; set; } = -1;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public byte SortingPriority { get; set; } = 0;
	
	[ContainerField(0x75), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
	public bool Projected { get; set; } = true;
	
	[ContainerField(0x76), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
	public bool ProjectMultiple { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Size);
		p_Writer.Write(RandomSize);
		p_Writer.Write(Rotation);
		p_Writer.Write(RandomRotation);
		p_Writer.Write(ClipAngle);
		p_Writer.Write(ProximityRadiusFactor);
		p_Writer.Write(NormalOffset);
		AtlasTile.Serialize(p_Writer, p_EbxWriter);
		Shader.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MeshUVIndex);
		p_Writer.Write(SortingPriority);
		p_Writer.Write(Projected);
		p_Writer.Write(ProjectMultiple);
		p_Writer.WriteNullBytes(1);
	}
}

