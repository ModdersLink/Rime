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

namespace fb.VeniceShared;

[ContainerType(16, 1024)]
public class AILocoComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 FacingTargetPosition { get; set; } = new()
	{
		z = -44444.000f,
		y = -44444.000f,
		x = -44444.000f,
	};
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public AILocoBinding Binding { get; set; } = new();
	
	[ContainerField(0x15c), JsonProperty(Order = 348)]
	public AILocoVaultBinding VaultBinding { get; set; } = new();
	
	[ContainerField(0x1e8), JsonProperty(Order = 488)]
	public AILocoCoverBinding CoverBinding { get; set; } = new();
	
	[ContainerField(0x3f0), LayoutImmutable, Blittable, JsonProperty(Order = 1008)]
	public int AnimationEntitySpacePriority { get; set; } = 0;
	
	[ContainerField(0x3f4), LayoutImmutable, Blittable, JsonProperty(Order = 1012)]
	public float WantedYaw { get; set; } = -44.000f;
	
	[ContainerField(0x3f8), LayoutImmutable, Blittable, JsonProperty(Order = 1016)]
	public float WantedPitch { get; set; } = -44.000f;
	
	[ContainerField(0x3fc), LayoutImmutable, Blittable, JsonProperty(Order = 1020)]
	public bool AimWithFifaLoco { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		FacingTargetPosition.Serialize(p_Writer, p_EbxWriter);
		Binding.Serialize(p_Writer, p_EbxWriter);
		VaultBinding.Serialize(p_Writer, p_EbxWriter);
		CoverBinding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AnimationEntitySpacePriority);
		p_Writer.Write(WantedYaw);
		p_Writer.Write(WantedPitch);
		p_Writer.Write(AimWithFifaLoco);
		p_Writer.WriteNullBytes(3);
	}
}

