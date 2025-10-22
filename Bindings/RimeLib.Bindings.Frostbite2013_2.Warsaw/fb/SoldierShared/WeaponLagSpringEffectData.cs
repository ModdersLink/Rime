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

namespace fb.SoldierShared;

[ContainerType(16, 208)]
public class WeaponLagSpringEffectData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public WeaponLagEffectSpringVector OffsetSprings { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public WeaponLagEffectForceData JumpForces { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public WeaponLagEffectForceData LandForces { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public WeaponLagEffectForceData PoseUpForces { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public WeaponLagEffectForceData PoseDownForces { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public WeaponLagEffectSpringVector RotationSprings { get; set; } = new();
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float ZoomForceModifier { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		OffsetSprings.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(8);
		JumpForces.Serialize(p_Writer, p_EbxWriter);
		LandForces.Serialize(p_Writer, p_EbxWriter);
		PoseUpForces.Serialize(p_Writer, p_EbxWriter);
		PoseDownForces.Serialize(p_Writer, p_EbxWriter);
		RotationSprings.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ZoomForceModifier);
		p_Writer.WriteNullBytes(4);
	}
}

