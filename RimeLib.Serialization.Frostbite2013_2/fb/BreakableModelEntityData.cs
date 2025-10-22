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

using fb.Physics;
using fb.Core;
using fb.Render;
using fb.Entity;

namespace fb.Destruction;

[ContainerType(16, 192)]
public class BreakableModelEntityData
	: fb.Physics.GamePhysicsEntityData
{
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<SurfaceShaderBaseAsset> DecalVolumeShader { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float DecalVolumeScaleFactor { get; set; } = 2.000f;
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public uint BoneCount { get; set; } = 0;
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<EdgeModelLightMapData> EdgeModelLightMapData { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(DecalVolumeShader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DecalVolumeScaleFactor);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(BoneCount);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EdgeModelLightMapData));
		p_Writer.WriteNullBytes(12);
	}
}

