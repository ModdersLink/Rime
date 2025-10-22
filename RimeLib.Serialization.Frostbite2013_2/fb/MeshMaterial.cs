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

[ContainerType(8, 112)]
public class MeshMaterial
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<SurfaceShaderInstanceData> ShaderInstance { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public SurfaceShaderInstanceDataStruct Shader { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public ShaderTessellationType TessellationType { get; set; } = ShaderTessellationType.ShaderTessellationType_None;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float TessellationTriangleSize { get; set; } = 12.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float TessellationMaxDistance { get; set; } = 20.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float BackFaceCullEpsilon { get; set; } = 0.500f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float ShapeFactor { get; set; } = 0.750f;
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<TextureAsset> DisplacementMap { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float DisplacementScale { get; set; } = 1.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float DisplacementBias { get; set; } = 0.500f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint DisplacementMapTexCoord { get; set; } = 0;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool SmoothEdgeVertices { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ShaderInstance));
		p_Writer.WriteNullBytes(4);
		Shader.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) TessellationType);
		p_Writer.Write(TessellationTriangleSize);
		p_Writer.Write(TessellationMaxDistance);
		p_Writer.Write(BackFaceCullEpsilon);
		p_Writer.Write(ShapeFactor);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DisplacementMap));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DisplacementScale);
		p_Writer.Write(DisplacementBias);
		p_Writer.Write(DisplacementMapTexCoord);
		p_Writer.Write(SmoothEdgeVertices);
		p_Writer.WriteNullBytes(3);
	}
}

