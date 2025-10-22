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

using fb.Entity;
using fb.Core;
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 176)]
public class ControllableEntityData
	: fb.Physics.GamePhysicsEntityData
{
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public TeamId DefaultTeam { get; set; } = TeamId.TeamNeutral;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float LowHealthThreshold { get; set; } = 50.000f;
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public MaterialDecl MaterialPair { get; set; } = new();
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public bool UsePrediction { get; set; } = true;
	
	[ContainerField(0x9d), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
	public bool ResetTeamOnLastPlayerExits { get; set; } = true;
	
	[ContainerField(0x9e), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
	public bool Immortal { get; set; } = false;
	
	[ContainerField(0x9f), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
	public bool FakeImmortal { get; set; } = false;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool ForceForegroundRendering { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) DefaultTeam);
		p_Writer.Write(LowHealthThreshold);
		MaterialPair.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UsePrediction);
		p_Writer.Write(ResetTeamOnLastPlayerExits);
		p_Writer.Write(Immortal);
		p_Writer.Write(FakeImmortal);
		p_Writer.Write(ForceForegroundRendering);
		p_Writer.WriteNullBytes(15);
	}
}

