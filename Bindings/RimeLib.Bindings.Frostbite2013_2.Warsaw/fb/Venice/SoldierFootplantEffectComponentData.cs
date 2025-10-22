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

namespace fb.Venice;

[ContainerType(16, 144)]
public class SoldierFootplantEffectComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public MaterialDecl FootMaterialPair { get; set; } = new();
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float HeightOverGroundThreshold { get; set; } = 0.060f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float FootVelocityThreshold { get; set; } = 1.100f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float LodDistance { get; set; } = 20.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public bool FullFootplantingEnabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		FootMaterialPair.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(HeightOverGroundThreshold);
		p_Writer.Write(FootVelocityThreshold);
		p_Writer.Write(LodDistance);
		p_Writer.Write(FullFootplantingEnabled);
		p_Writer.WriteNullBytes(15);
	}
}

