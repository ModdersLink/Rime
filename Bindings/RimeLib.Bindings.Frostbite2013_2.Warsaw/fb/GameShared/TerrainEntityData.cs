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
using fb.Terrain;
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 176)]
public class TerrainEntityData
	: fb.Physics.GamePhysicsEntityData
{
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public ResourceRef DecalsResource { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<TerrainData> TerrainAsset { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public MaterialDecl WaterMaterial { get; set; } = new();
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public bool Visible { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		DecalsResource.Serialize(p_Writer);
		p_Writer.Write(p_EbxWriter.WriteImport(TerrainAsset));
		p_Writer.WriteNullBytes(4);
		WaterMaterial.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Visible);
		p_Writer.WriteNullBytes(11);
	}
}

