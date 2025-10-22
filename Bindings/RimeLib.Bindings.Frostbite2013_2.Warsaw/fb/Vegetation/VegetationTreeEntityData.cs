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
using fb.Render;
using fb.Physics;

namespace fb.Vegetation;

[ContainerType(16, 608)]
public class VegetationTreeEntityData
	: fb.Vegetation.VegetationBaseEntityData
{
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec3 InertiaModifier { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xf0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public Vec3 TranslucencyVolumeCenter { get; set; } = new()
	{
		z = 0.000f,
		y = 10.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float Stiffness { get; set; } = 200.000f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float Damping { get; set; } = 100.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float StemMass { get; set; } = 40.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float StiffnessSpread { get; set; } = 1.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float DampingSpread { get; set; } = 1.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float MassSpread { get; set; } = 1.000f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float StemLockedUpTo { get; set; } = 0.000f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public int StemBoneCount { get; set; } = 1;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float BreakableJointThreshold { get; set; } = 0.450f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float BoundingBoxScaleFactor { get; set; } = 1.300f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float PartsTimeToLive { get; set; } = 10000.000f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float LinearVelocityDamping { get; set; } = 1.000f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float AngularVelocityDamping { get; set; } = 1.000f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float Friction { get; set; } = 15.000f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float Restitution { get; set; } = 0.600f;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public float StemPhysicsWidth { get; set; } = 0.200f;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public float StemPhysicsHeightScale { get; set; } = 1.000f;
	
	[ContainerField(0x144), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
	public float BranchPhysicsWidth { get; set; } = 0.100f;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public float BranchPhysicsHeightScale { get; set; } = 1.000f;
	
	[ContainerField(0x14c), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
	public float DestructionMassScale { get; set; } = 1.000f;
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public float CenterOfMassVerticalScale { get; set; } = 0.500f;
	
	[ContainerField(0x158), JsonProperty(Order = 344)]
	public VegetationEffectSlot StemBreakEffect { get; set; } = new();
	
	[ContainerField(0x170), JsonProperty(Order = 368)]
	public VegetationEffectSlot BranchBreakEffect { get; set; } = new();
	
	[ContainerField(0x188), JsonProperty(Order = 392)]
	public VegetationEffectSlot ImpactEffect { get; set; } = new();
	
	[ContainerField(0x1a0), JsonProperty(Order = 416)]
	public CtrRef<EffectBlueprint> WindEffect { get; set; } = new();
	
	[ContainerField(0x1a8), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
	public float MinRespawnTime { get; set; } = 1.000f;
	
	[ContainerField(0x1ac), LayoutImmutable, Blittable, JsonProperty(Order = 428)]
	public uint StemEffectNodeThreshold { get; set; } = 1000;
	
	[ContainerField(0x1b0), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
	public uint ShadowLODOffset { get; set; } = 4;
	
	[ContainerField(0x1b4), LayoutImmutable, Blittable, JsonProperty(Order = 436)]
	public float ColiPlaneDepth { get; set; } = 0.000f;
	
	[ContainerField(0x1b8), LayoutImmutable, Blittable, JsonProperty(Order = 440)]
	public float StemHitpoints { get; set; } = 100.000f;
	
	[ContainerField(0x1bc), LayoutImmutable, Blittable, JsonProperty(Order = 444)]
	public float BranchHitpoints { get; set; } = 50.000f;
	
	[ContainerField(0x1c0), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
	public float BranchL2Hitpoints { get; set; } = 20.000f;
	
	[ContainerField(0x1c4), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
	public float StemStiffness { get; set; } = 1.000f;
	
	[ContainerField(0x1c8), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
	public float StemStiffnessSpread { get; set; } = 0.500f;
	
	[ContainerField(0x1cc), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
	public float StemStiffnessInherit { get; set; } = 1.000f;
	
	[ContainerField(0x1d0), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
	public float BranchStiffness { get; set; } = 1.000f;
	
	[ContainerField(0x1d4), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
	public float BranchStiffnessInherit { get; set; } = 1.000f;
	
	[ContainerField(0x1d8), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
	public float BranchStiffnessL2 { get; set; } = 1.000f;
	
	[ContainerField(0x1dc), LayoutImmutable, Blittable, JsonProperty(Order = 476)]
	public float BranchStiffnessL2Inherit { get; set; } = 1.000f;
	
	[ContainerField(0x1e0), JsonProperty(Order = 480)]
	public CtrRef<EffectBlueprint> BulletImpactEffect { get; set; } = new();
	
	[ContainerField(0x1e8), JsonProperty(Order = 488)]
	public CtrRef<EffectBlueprint> CollisionEffect { get; set; } = new();
	
	[ContainerField(0x1f0), JsonProperty(Order = 496)]
	public CtrRef<EffectBlueprint> SplashNearEffect { get; set; } = new();
	
	[ContainerField(0x1f8), JsonProperty(Order = 504)]
	public CtrRef<EffectBlueprint> SplashDistantEffect { get; set; } = new();
	
	[ContainerField(0x200), JsonProperty(Order = 512)]
	public CtrRef<EffectBlueprint> LocalWindEffect { get; set; } = new();
	
	[ContainerField(0x208), JsonProperty(Order = 520)]
	public CtrRef<EffectBlueprint> StemRipEffect { get; set; } = new();
	
	[ContainerField(0x210), JsonProperty(Order = 528)]
	public CtrRef<EffectBlueprint> TreeFallEffect { get; set; } = new();
	
	[ContainerField(0x218), JsonProperty(Order = 536)]
	public CtrRef<EffectBlueprint> GroundImpactEffect { get; set; } = new();
	
	[ContainerField(0x220), LayoutImmutable, Blittable, JsonProperty(Order = 544)]
	public float WindStem { get; set; } = 0.800f;
	
	[ContainerField(0x224), LayoutImmutable, Blittable, JsonProperty(Order = 548)]
	public float WindBranch { get; set; } = 2.000f;
	
	[ContainerField(0x228), LayoutImmutable, Blittable, JsonProperty(Order = 552)]
	public float WindBranchL2 { get; set; } = 3.500f;
	
	[ContainerField(0x22c), LayoutImmutable, Blittable, JsonProperty(Order = 556)]
	public float WindEndPoints { get; set; } = 1.000f;
	
	[ContainerField(0x230), LayoutImmutable, Blittable, JsonProperty(Order = 560)]
	public float InheritParentEndPoints { get; set; } = 0.000f;
	
	[ContainerField(0x234), LayoutImmutable, Blittable, JsonProperty(Order = 564)]
	public float ImpactThreshold { get; set; } = 50.000f;
	
	[ContainerField(0x238), LayoutImmutable, Blittable, JsonProperty(Order = 568)]
	public float CollisionImpactMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x23c), LayoutImmutable, Blittable, JsonProperty(Order = 572)]
	public float WindMicroVariationMultiplier { get; set; } = 0.000f;
	
	[ContainerField(0x240), LayoutImmutable, Blittable, JsonProperty(Order = 576)]
	public float WindEPMicroVariationMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x244), LayoutImmutable, Blittable, JsonProperty(Order = 580)]
	public float FallDirectionStart { get; set; } = 0.000f;
	
	[ContainerField(0x248), LayoutImmutable, Blittable, JsonProperty(Order = 584)]
	public float FallDirectionEnd { get; set; } = 360.000f;
	
	[ContainerField(0x24c), LayoutImmutable, Blittable, JsonProperty(Order = 588)]
	public bool ConstantFalloff { get; set; } = false;
	
	[ContainerField(0x24d), LayoutImmutable, Blittable, JsonProperty(Order = 589)]
	public bool Indestructable { get; set; } = false;
	
	[ContainerField(0x24e), LayoutImmutable, Blittable, JsonProperty(Order = 590)]
	public bool TranslucencyEnabled { get; set; } = true;
	
	[ContainerField(0x24f), LayoutImmutable, Blittable, JsonProperty(Order = 591)]
	public bool ClientSideOnly { get; set; } = false;
	
	[ContainerField(0x250), LayoutImmutable, Blittable, JsonProperty(Order = 592)]
	public bool UsePhysicsShapes { get; set; } = false;
	
	[ContainerField(0x251), LayoutImmutable, Blittable, JsonProperty(Order = 593)]
	public bool ConstraintStemB1 { get; set; } = false;
	
	[ContainerField(0x252), LayoutImmutable, Blittable, JsonProperty(Order = 594)]
	public bool ConstraintStemB2 { get; set; } = false;
	
	[ContainerField(0x253), LayoutImmutable, Blittable, JsonProperty(Order = 595)]
	public bool ForceFullSim { get; set; } = false;
	
	[ContainerField(0x254), LayoutImmutable, Blittable, JsonProperty(Order = 596)]
	public bool UseImpactThreshold { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		InertiaModifier.Serialize(p_Writer, p_EbxWriter);
		TranslucencyVolumeCenter.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Stiffness);
		p_Writer.Write(Damping);
		p_Writer.Write(StemMass);
		p_Writer.Write(StiffnessSpread);
		p_Writer.Write(DampingSpread);
		p_Writer.Write(MassSpread);
		p_Writer.Write(StemLockedUpTo);
		p_Writer.Write(StemBoneCount);
		p_Writer.Write(BreakableJointThreshold);
		p_Writer.Write(BoundingBoxScaleFactor);
		p_Writer.Write(PartsTimeToLive);
		p_Writer.Write(LinearVelocityDamping);
		p_Writer.Write(AngularVelocityDamping);
		p_Writer.Write(Friction);
		p_Writer.Write(Restitution);
		p_Writer.Write(StemPhysicsWidth);
		p_Writer.Write(StemPhysicsHeightScale);
		p_Writer.Write(BranchPhysicsWidth);
		p_Writer.Write(BranchPhysicsHeightScale);
		p_Writer.Write(DestructionMassScale);
		p_Writer.Write(CenterOfMassVerticalScale);
		p_Writer.WriteNullBytes(4);
		StemBreakEffect.Serialize(p_Writer, p_EbxWriter);
		BranchBreakEffect.Serialize(p_Writer, p_EbxWriter);
		ImpactEffect.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(WindEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MinRespawnTime);
		p_Writer.Write(StemEffectNodeThreshold);
		p_Writer.Write(ShadowLODOffset);
		p_Writer.Write(ColiPlaneDepth);
		p_Writer.Write(StemHitpoints);
		p_Writer.Write(BranchHitpoints);
		p_Writer.Write(BranchL2Hitpoints);
		p_Writer.Write(StemStiffness);
		p_Writer.Write(StemStiffnessSpread);
		p_Writer.Write(StemStiffnessInherit);
		p_Writer.Write(BranchStiffness);
		p_Writer.Write(BranchStiffnessInherit);
		p_Writer.Write(BranchStiffnessL2);
		p_Writer.Write(BranchStiffnessL2Inherit);
		p_Writer.Write(p_EbxWriter.WriteImport(BulletImpactEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CollisionEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SplashNearEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SplashDistantEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LocalWindEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StemRipEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TreeFallEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(GroundImpactEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(WindStem);
		p_Writer.Write(WindBranch);
		p_Writer.Write(WindBranchL2);
		p_Writer.Write(WindEndPoints);
		p_Writer.Write(InheritParentEndPoints);
		p_Writer.Write(ImpactThreshold);
		p_Writer.Write(CollisionImpactMultiplier);
		p_Writer.Write(WindMicroVariationMultiplier);
		p_Writer.Write(WindEPMicroVariationMultiplier);
		p_Writer.Write(FallDirectionStart);
		p_Writer.Write(FallDirectionEnd);
		p_Writer.Write(ConstantFalloff);
		p_Writer.Write(Indestructable);
		p_Writer.Write(TranslucencyEnabled);
		p_Writer.Write(ClientSideOnly);
		p_Writer.Write(UsePhysicsShapes);
		p_Writer.Write(ConstraintStemB1);
		p_Writer.Write(ConstraintStemB2);
		p_Writer.Write(ForceFullSim);
		p_Writer.Write(UseImpactThreshold);
		p_Writer.WriteNullBytes(11);
	}
}

