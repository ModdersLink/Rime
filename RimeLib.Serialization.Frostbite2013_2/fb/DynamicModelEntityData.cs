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
using fb.Physics;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 176)]
public class DynamicModelEntityData
	: fb.GameShared.DynamicGamePhysicsEntityData
{
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float TimeToLive { get; set; } = 0.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public uint DestructiblePartCount { get; set; } = 0;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool ClientSideOnly { get; set; } = false;
	
	[ContainerField(0xa1), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
	public bool NoCollision { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TimeToLive);
		p_Writer.Write(DestructiblePartCount);
		p_Writer.Write(ClientSideOnly);
		p_Writer.Write(NoCollision);
		p_Writer.WriteNullBytes(14);
	}
}

