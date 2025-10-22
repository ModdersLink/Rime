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
public class BangerEntityData
	: fb.GameShared.DynamicGamePhysicsEntityData
{
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<ExplosionEntityData> Explosion { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float TimeToLive { get; set; } = 0.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public uint DestructiblePartCount { get; set; } = 0;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public bool UseVariableNetworkFrequency { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Explosion));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TimeToLive);
		p_Writer.Write(DestructiblePartCount);
		p_Writer.Write(UseVariableNetworkFrequency);
		p_Writer.WriteNullBytes(7);
	}
}

