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

using fb.GameShared;
using fb.Audio;

namespace fb.BFAI2Data;

[ContainerType(8, 64)]
public class BFAIProjectile
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public BFAIProjectileCurveType Curve { get; set; } = BFAIProjectileCurveType.BFAIProjectileType_Parabolic;
	
	[ContainerField(0x4), JsonProperty(Order = 4)]
	public LinearTime Minimum { get; set; } = new();
	
	[ContainerField(0xc), JsonProperty(Order = 12)]
	public LinearTime Maximum { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public Dispersion Dispersion { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<ProjectileBlueprint> Projectile { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<SoundAsset> Sound { get; set; } = new();
	
}

