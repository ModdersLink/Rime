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
using fb.GameShared;
using fb.Entity;

namespace fb.SoldierShared;

[ContainerType(16, 144)]
public class AimAssistNodeComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 StickyCenterOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public TeamId Team { get; set; } = TeamId.Team2;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x85), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
	public bool GetTeamFromOwner { get; set; } = true;
	
	[ContainerField(0x86), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
	public bool ColorPlayerReticle { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		StickyCenterOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Team);
		p_Writer.Write(Enabled);
		p_Writer.Write(GetTeamFromOwner);
		p_Writer.Write(ColorPlayerReticle);
		p_Writer.WriteNullBytes(9);
	}
}

