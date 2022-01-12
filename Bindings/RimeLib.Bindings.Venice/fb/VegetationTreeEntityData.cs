///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 256)]
	public class VegetationTreeEntityData : 
		VegetationBaseEntityData
	{
		[ContainerField(128)]
		public CtrRef<EffectBlueprint> GroundImpactEffect { get; set; } = new();

		[ContainerField(132)]
		public CtrRef<EffectBlueprint> StemRipEffect { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public float StemPhysicsWidth { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float ColiPlaneDepth { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float StemHitpoints { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float BranchHitpoints { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float BranchL2Hitpoints { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float StemStiffness { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float StemStiffnessSpread { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float BranchStiffness { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float BranchStiffnessL2 { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public int StemBoneCount { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float WindStem { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float WindBranch { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float WindBranchL2 { get; set; }

		[ContainerField(188)]
		public CtrRef<EffectBlueprint> TreeFallEffect { get; set; } = new();

		[ContainerField(192), LayoutImmutable, Blittable]
		public float BreakableJointThreshold { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float FallDirectionEnd { get; set; }

		[ContainerField(200)]
		public CtrRef<EffectBlueprint> LocalWindEffect { get; set; } = new();

		[ContainerField(204), LayoutImmutable, Blittable]
		public float ImpactThreshold { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float CollisionImpactMultiplier { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float FallDirectionStart { get; set; }

		[ContainerField(216)]
		public CtrRef<EffectBlueprint> SplashDistantEffect { get; set; } = new();

		[ContainerField(220)]
		public CtrRef<EffectBlueprint> BulletImpactEffect { get; set; } = new();

		[ContainerField(224), LayoutImmutable, Blittable]
		public float PartsTimeToLive { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public uint ShadowLODOffset { get; set; }

		[ContainerField(232)]
		public CtrRef<EffectBlueprint> SplashNearEffect { get; set; } = new();

		[ContainerField(236)]
		public CtrRef<EffectBlueprint> CollisionEffect { get; set; } = new();

		[ContainerField(240), LayoutImmutable, Blittable]
		public bool ForceFullSim { get; set; }

		[ContainerField(241), LayoutImmutable, Blittable]
		public bool UseImpactThreshold { get; set; }

		[ContainerField(242), LayoutImmutable, Blittable]
		public bool UsePhysicsShapes { get; set; }

		[ContainerField(243), LayoutImmutable, Blittable]
		public bool ConstraintStemB1 { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public bool ConstraintStemB2 { get; set; }

		[ContainerField(245), LayoutImmutable, Blittable]
		public bool ClientSideOnly { get; set; }

	}
}
