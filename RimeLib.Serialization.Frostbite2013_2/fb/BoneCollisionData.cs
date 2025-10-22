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

[ContainerType(16, 144)]
public class BoneCollisionData
	: EbxSerializable
{
	[ContainerField(0x0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public Vec4 DebugDrawColor { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x10), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public Vec3 CapsuleOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public PitchModifier MaxPitch { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public PitchModifier MinPitch { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string BoneName { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public HitReactionType AnimationHitReactionType { get; set; } = HitReactionType.HRT_Body;
	
	[ContainerField(0x6c), JsonProperty(Order = 108)]
	public MaterialDecl MaterialPair { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public int BoneAxis { get; set; } = 0;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float CapsuleLength { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float CapsuleRadius { get; set; } = 0.000f;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<AimAssistCollisionBoneData> AimAssistTarget { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public bool ValidInHiLod { get; set; } = true;
	
	[ContainerField(0x89), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
	public bool ValidInLowLod { get; set; } = false;
	
	[ContainerField(0x8a), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
	public bool DeactivateIfBehindWall { get; set; } = false;
	
	[ContainerField(0x8b), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
	public bool UsePhysicsRotation { get; set; } = false;
	
}

