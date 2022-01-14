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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 256)]
	public class VegetationTreeEntityData :
		VegetationBaseEntityData
	{
		[ContainerField(128), JsonProperty(Order = 128)]
		public CtrRef<EffectBlueprint> GroundImpactEffect { get; set; } = new();

		[ContainerField(132), JsonProperty(Order = 132)]
		public CtrRef<EffectBlueprint> StemRipEffect { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float StemPhysicsWidth { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float ColiPlaneDepth { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float StemHitpoints { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float BranchHitpoints { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float BranchL2Hitpoints { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float StemStiffness { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float StemStiffnessSpread { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float BranchStiffness { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float BranchStiffnessL2 { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public int StemBoneCount { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float WindStem { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float WindBranch { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float WindBranchL2 { get; set; }

		[ContainerField(188), JsonProperty(Order = 188)]
		public CtrRef<EffectBlueprint> TreeFallEffect { get; set; } = new();

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float BreakableJointThreshold { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public float FallDirectionEnd { get; set; }

		[ContainerField(200), JsonProperty(Order = 200)]
		public CtrRef<EffectBlueprint> LocalWindEffect { get; set; } = new();

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float ImpactThreshold { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float CollisionImpactMultiplier { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float FallDirectionStart { get; set; }

		[ContainerField(216), JsonProperty(Order = 216)]
		public CtrRef<EffectBlueprint> SplashDistantEffect { get; set; } = new();

		[ContainerField(220), JsonProperty(Order = 220)]
		public CtrRef<EffectBlueprint> BulletImpactEffect { get; set; } = new();

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public float PartsTimeToLive { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public uint ShadowLODOffset { get; set; }

		[ContainerField(232), JsonProperty(Order = 232)]
		public CtrRef<EffectBlueprint> SplashNearEffect { get; set; } = new();

		[ContainerField(236), JsonProperty(Order = 236)]
		public CtrRef<EffectBlueprint> CollisionEffect { get; set; } = new();

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public bool ForceFullSim { get; set; }

		[ContainerField(241), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
		public bool UseImpactThreshold { get; set; }

		[ContainerField(242), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
		public bool UsePhysicsShapes { get; set; }

		[ContainerField(243), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
		public bool ConstraintStemB1 { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public bool ConstraintStemB2 { get; set; }

		[ContainerField(245), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
		public bool ClientSideOnly { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(GroundImpactEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(StemRipEffect));
			p_Writer.Write(StemPhysicsWidth);
			p_Writer.Write(ColiPlaneDepth);
			p_Writer.Write(StemHitpoints);
			p_Writer.Write(BranchHitpoints);
			p_Writer.Write(BranchL2Hitpoints);
			p_Writer.Write(StemStiffness);
			p_Writer.Write(StemStiffnessSpread);
			p_Writer.Write(BranchStiffness);
			p_Writer.Write(BranchStiffnessL2);
			p_Writer.Write(StemBoneCount);
			p_Writer.Write(WindStem);
			p_Writer.Write(WindBranch);
			p_Writer.Write(WindBranchL2);
			p_Writer.Write(p_EbxWriter.WriteImport(TreeFallEffect));
			p_Writer.Write(BreakableJointThreshold);
			p_Writer.Write(FallDirectionEnd);
			p_Writer.Write(p_EbxWriter.WriteImport(LocalWindEffect));
			p_Writer.Write(ImpactThreshold);
			p_Writer.Write(CollisionImpactMultiplier);
			p_Writer.Write(FallDirectionStart);
			p_Writer.Write(p_EbxWriter.WriteImport(SplashDistantEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(BulletImpactEffect));
			p_Writer.Write(PartsTimeToLive);
			p_Writer.Write(ShadowLODOffset);
			p_Writer.Write(p_EbxWriter.WriteImport(SplashNearEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(CollisionEffect));
			p_Writer.Write(ForceFullSim);
			p_Writer.Write(UseImpactThreshold);
			p_Writer.Write(UsePhysicsShapes);
			p_Writer.Write(ConstraintStemB1);
			p_Writer.Write(ConstraintStemB2);
			p_Writer.Write(ClientSideOnly);
			p_Writer.WriteNullBytes(10);
		}
	}
}
