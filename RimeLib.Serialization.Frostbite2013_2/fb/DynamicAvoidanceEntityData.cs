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

namespace fb.GameShared;

[ContainerType(8, 128)]
public class DynamicAvoidanceEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public DynamicAvoidanceMode RepelOthers { get; set; } = DynamicAvoidanceMode.DynamicAvoidanceMode_Always;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public DynamicAvoidanceMode ReportPredictedCollision { get; set; } = DynamicAvoidanceMode.DynamicAvoidanceMode_Always;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float CollisionRadius { get; set; } = 0.250f;
	
	[ContainerField(0x24), JsonProperty(Order = 36)]
	public AntDynamicAvoidanceBinding AntBinding { get; set; } = new();
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_ClientAndServer;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public bool AffectedByRepellingForce { get; set; } = false;
	
	[ContainerField(0x79), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
	public bool PredictedByOthers { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) RepelOthers);
		p_Writer.Write((int) ReportPredictedCollision);
		p_Writer.Write(CollisionRadius);
		AntBinding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(AffectedByRepellingForce);
		p_Writer.Write(PredictedByOthers);
		p_Writer.WriteNullBytes(6);
	}
}

