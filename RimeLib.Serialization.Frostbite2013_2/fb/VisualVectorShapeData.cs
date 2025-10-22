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

namespace fb.Terrain;

[ContainerType(8, 64)]
public class VisualVectorShapeData
	: fb.Entity.VectorShapeData
{
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float ErrorTolerance { get; set; } = 0.100f;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<SurfaceShaderBaseAsset> Shader3d { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint DrawOrderIndex { get; set; } = 100;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float TessellationTriangleSize { get; set; } = 4.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ErrorTolerance);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Shader3d));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DrawOrderIndex);
		p_Writer.Write(TessellationTriangleSize);
	}
}

