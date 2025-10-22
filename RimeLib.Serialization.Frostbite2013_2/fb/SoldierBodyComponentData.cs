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

namespace fb.SoldierShared;

[ContainerType(16, 128)]
public class SoldierBodyComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float OverrideGravityValue { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float OverrideVelocityY { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float SprintMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool OverrideGravity { get; set; } = false;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool OverrideVelocity { get; set; } = false;
	
	[ContainerField(0x7e), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
	public bool DisableParachute { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(OverrideGravityValue);
		p_Writer.Write(OverrideVelocityY);
		p_Writer.Write(SprintMultiplier);
		p_Writer.Write(OverrideGravity);
		p_Writer.Write(OverrideVelocity);
		p_Writer.Write(DisableParachute);
		p_Writer.WriteNullBytes(1);
	}
}

