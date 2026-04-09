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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 256)]
	public partial class VegetationTreeEntityData :
		VegetationBaseEntityData
	{
		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private CtrRef<EffectBlueprint> _GroundImpactEffect = new();

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private CtrRef<EffectBlueprint> _StemRipEffect = new();

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _StemPhysicsWidth;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _ColiPlaneDepth;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _StemHitpoints;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _BranchHitpoints;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _BranchL2Hitpoints;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _StemStiffness;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _StemStiffnessSpread;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _BranchStiffness;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _BranchStiffnessL2;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private int _StemBoneCount;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _WindStem;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _WindBranch;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _WindBranchL2;

		[ObservableProperty]
		[property: ContainerField(188), JsonProperty(Order = 188)]
		private CtrRef<EffectBlueprint> _TreeFallEffect = new();

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _BreakableJointThreshold;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private float _FallDirectionEnd;

		[ObservableProperty]
		[property: ContainerField(200), JsonProperty(Order = 200)]
		private CtrRef<EffectBlueprint> _LocalWindEffect = new();

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _ImpactThreshold;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _CollisionImpactMultiplier;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _FallDirectionStart;

		[ObservableProperty]
		[property: ContainerField(216), JsonProperty(Order = 216)]
		private CtrRef<EffectBlueprint> _SplashDistantEffect = new();

		[ObservableProperty]
		[property: ContainerField(220), JsonProperty(Order = 220)]
		private CtrRef<EffectBlueprint> _BulletImpactEffect = new();

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private float _PartsTimeToLive;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private uint _ShadowLODOffset;

		[ObservableProperty]
		[property: ContainerField(232), JsonProperty(Order = 232)]
		private CtrRef<EffectBlueprint> _SplashNearEffect = new();

		[ObservableProperty]
		[property: ContainerField(236), JsonProperty(Order = 236)]
		private CtrRef<EffectBlueprint> _CollisionEffect = new();

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private bool _ForceFullSim;

		[ObservableProperty]
		[property: ContainerField(241), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
		private bool _UseImpactThreshold;

		[ObservableProperty]
		[property: ContainerField(242), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
		private bool _UsePhysicsShapes;

		[ObservableProperty]
		[property: ContainerField(243), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
		private bool _ConstraintStemB1;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private bool _ConstraintStemB2;

		[ObservableProperty]
		[property: ContainerField(245), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
		private bool _ClientSideOnly;

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
