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

namespace fb.Terrain;

[ContainerType(8, 88)]
public class TerrainFillDecalData
	: fb.Terrain.VisualVectorShapeData
{
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<SurfaceShaderBaseAsset> Shader2d { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<SurfaceShaderBaseAsset> Shader2dMeshScatteringMask { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Shader2d));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Shader2dMeshScatteringMask));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Shader3dZOnly));
		p_Writer.WriteNullBytes(4);
	}
}

