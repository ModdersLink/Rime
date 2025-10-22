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

[ContainerType(8, 104)]
public class RoadData
	: fb.Terrain.RibbonData
{
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<SurfaceShaderBaseAsset> Shader2d { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<SurfaceShaderBaseAsset> Shader2dMeshScatteringMask { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float UvTileFactor { get; set; } = 1.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public bool StickToTerrain { get; set; } = true;
	
	[ContainerField(0x65), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
	public bool TangentSpaceEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Shader2d));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Shader2dMeshScatteringMask));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Shader3dZOnly));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UvTileFactor);
		p_Writer.Write(StickToTerrain);
		p_Writer.Write(TangentSpaceEnable);
		p_Writer.WriteNullBytes(2);
	}
}

