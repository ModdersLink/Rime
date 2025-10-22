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

namespace fb.Venice;

[ContainerType(8, 96)]
public class AimingConstraintEntityCommonData
	: fb.Entity.DataContainerPolicyAsset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AimingConstraintEntityBinding AimingConstraintsBinding { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AimingConstraintsData AimingConstraints { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float DisableAimingConstraintsDelay { get; set; } = 0.200f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float ConstraintMoveSpeedMultiplier { get; set; } = 2.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float ShuffleAnimationThreshold { get; set; } = 0.900f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float ShuffleAnimationDelay { get; set; } = 0.400f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		AimingConstraintsBinding.Serialize(p_Writer, p_EbxWriter);
		AimingConstraints.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DisableAimingConstraintsDelay);
		p_Writer.Write(ConstraintMoveSpeedMultiplier);
		p_Writer.Write(ShuffleAnimationThreshold);
		p_Writer.Write(ShuffleAnimationDelay);
	}
}

