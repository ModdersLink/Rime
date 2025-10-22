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

using fb.VeniceShared;
using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 272)]
public class ClimbLadderComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public int ClimbPhase { get; set; } = 30;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public int ConnectPhase { get; set; } = 1200;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float ConnectJointDisplacement { get; set; } = 52.800f;
	
	[ContainerField(0x7c), JsonProperty(Order = 124)]
	public AimingConstraintsData FreeLookAimingConstraints { get; set; } = new();
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public ClimbLadderBinding Binding { get; set; } = new();
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public bool FreeLook { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ClimbPhase);
		p_Writer.Write(ConnectPhase);
		p_Writer.Write(ConnectJointDisplacement);
		FreeLookAimingConstraints.Serialize(p_Writer, p_EbxWriter);
		Binding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FreeLook);
		p_Writer.WriteNullBytes(11);
	}
}

