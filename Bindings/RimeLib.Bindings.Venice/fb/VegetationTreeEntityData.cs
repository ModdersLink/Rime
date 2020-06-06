///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class VegetationTreeEntityData : 
		VegetationBaseEntityData
	{
		[ContainerField(128)]
		public CtrRef<EffectBlueprint> GroundImpactEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x80 (128)
		
		[ContainerField(132)]
		public CtrRef<EffectBlueprint> StemRipEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float StemPhysicsWidth { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float ColiPlaneDepth { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float StemHitpoints { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float BranchHitpoints { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float BranchL2Hitpoints { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float StemStiffness { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float StemStiffnessSpread { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float BranchStiffness { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float BranchStiffnessL2 { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public int StemBoneCount { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float WindStem { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float WindBranch { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float WindBranchL2 { get; set; } // 0xB8 (184)
		
		[ContainerField(188)]
		public CtrRef<EffectBlueprint> TreeFallEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float BreakableJointThreshold { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float FallDirectionEnd { get; set; } // 0xC4 (196)
		
		[ContainerField(200)]
		public CtrRef<EffectBlueprint> LocalWindEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float ImpactThreshold { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float CollisionImpactMultiplier { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float FallDirectionStart { get; set; } // 0xD4 (212)
		
		[ContainerField(216)]
		public CtrRef<EffectBlueprint> SplashDistantEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xD8 (216)
		
		[ContainerField(220)]
		public CtrRef<EffectBlueprint> BulletImpactEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float PartsTimeToLive { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public uint ShadowLODOffset { get; set; } // 0xE4 (228)
		
		[ContainerField(232)]
		public CtrRef<EffectBlueprint> SplashNearEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xE8 (232)
		
		[ContainerField(236)]
		public CtrRef<EffectBlueprint> CollisionEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public bool ForceFullSim { get; set; } // 0xF0 (240)
		
		[ContainerField(241), LayoutImmutable, Blittable]
		public bool UseImpactThreshold { get; set; } // 0xF1 (241)
		
		[ContainerField(242), LayoutImmutable, Blittable]
		public bool UsePhysicsShapes { get; set; } // 0xF2 (242)
		
		[ContainerField(243), LayoutImmutable, Blittable]
		public bool ConstraintStemB1 { get; set; } // 0xF3 (243)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public bool ConstraintStemB2 { get; set; } // 0xF4 (244)
		
		[ContainerField(245), LayoutImmutable, Blittable]
		public bool ClientSideOnly { get; set; } // 0xF5 (245)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1595516597:
					GroundImpactEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 935864630:
					StemRipEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 3773105703:
					StemPhysicsWidth = (float) p_Value;
					break;

				case 119595447:
					ColiPlaneDepth = (float) p_Value;
					break;

				case 156129888:
					StemHitpoints = (float) p_Value;
					break;

				case 3684887323:
					BranchHitpoints = (float) p_Value;
					break;

				case 204675493:
					BranchL2Hitpoints = (float) p_Value;
					break;

				case 257375119:
					StemStiffness = (float) p_Value;
					break;

				case 713063358:
					StemStiffnessSpread = (float) p_Value;
					break;

				case 1421593844:
					BranchStiffness = (float) p_Value;
					break;

				case 1927467530:
					BranchStiffnessL2 = (float) p_Value;
					break;

				case 4140582895:
					StemBoneCount = (int) p_Value;
					break;

				case 356803134:
					WindStem = (float) p_Value;
					break;

				case 2551442149:
					WindBranch = (float) p_Value;
					break;

				case 3971629275:
					WindBranchL2 = (float) p_Value;
					break;

				case 3999221459:
					TreeFallEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 2951351665:
					BreakableJointThreshold = (float) p_Value;
					break;

				case 3686844968:
					FallDirectionEnd = (float) p_Value;
					break;

				case 576309707:
					LocalWindEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 952638448:
					ImpactThreshold = (float) p_Value;
					break;

				case 2929818610:
					CollisionImpactMultiplier = (float) p_Value;
					break;

				case 3490532775:
					FallDirectionStart = (float) p_Value;
					break;

				case 609468470:
					SplashDistantEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 494798614:
					BulletImpactEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 209652569:
					PartsTimeToLive = (float) p_Value;
					break;

				case 1990024297:
					ShadowLODOffset = (uint) p_Value;
					break;

				case 3849130143:
					SplashNearEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 2616680812:
					CollisionEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 3014405532:
					ForceFullSim = (bool) p_Value;
					break;

				case 215104275:
					UseImpactThreshold = (bool) p_Value;
					break;

				case 3641740433:
					UsePhysicsShapes = (bool) p_Value;
					break;

				case 553666876:
					ConstraintStemB1 = (bool) p_Value;
					break;

				case 553666879:
					ConstraintStemB2 = (bool) p_Value;
					break;

				case 3628043763:
					ClientSideOnly = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1595516597:
					return GroundImpactEffect;

				case 935864630:
					return StemRipEffect;

				case 3773105703:
					return StemPhysicsWidth;

				case 119595447:
					return ColiPlaneDepth;

				case 156129888:
					return StemHitpoints;

				case 3684887323:
					return BranchHitpoints;

				case 204675493:
					return BranchL2Hitpoints;

				case 257375119:
					return StemStiffness;

				case 713063358:
					return StemStiffnessSpread;

				case 1421593844:
					return BranchStiffness;

				case 1927467530:
					return BranchStiffnessL2;

				case 4140582895:
					return StemBoneCount;

				case 356803134:
					return WindStem;

				case 2551442149:
					return WindBranch;

				case 3971629275:
					return WindBranchL2;

				case 3999221459:
					return TreeFallEffect;

				case 2951351665:
					return BreakableJointThreshold;

				case 3686844968:
					return FallDirectionEnd;

				case 576309707:
					return LocalWindEffect;

				case 952638448:
					return ImpactThreshold;

				case 2929818610:
					return CollisionImpactMultiplier;

				case 3490532775:
					return FallDirectionStart;

				case 609468470:
					return SplashDistantEffect;

				case 494798614:
					return BulletImpactEffect;

				case 209652569:
					return PartsTimeToLive;

				case 1990024297:
					return ShadowLODOffset;

				case 3849130143:
					return SplashNearEffect;

				case 2616680812:
					return CollisionEffect;

				case 3014405532:
					return ForceFullSim;

				case 215104275:
					return UseImpactThreshold;

				case 3641740433:
					return UsePhysicsShapes;

				case 553666876:
					return ConstraintStemB1;

				case 553666879:
					return ConstraintStemB2;

				case 3628043763:
					return ClientSideOnly;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1595516597:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(GroundImpactEffect));

				case 935864630:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(StemRipEffect));

				case 3773105703:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(StemPhysicsWidth));

				case 119595447:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(ColiPlaneDepth));

				case 156129888:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(StemHitpoints));

				case 3684887323:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(BranchHitpoints));

				case 204675493:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(BranchL2Hitpoints));

				case 257375119:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(StemStiffness));

				case 713063358:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(StemStiffnessSpread));

				case 1421593844:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(BranchStiffness));

				case 1927467530:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(BranchStiffnessL2));

				case 4140582895:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(StemBoneCount));

				case 356803134:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(WindStem));

				case 2551442149:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(WindBranch));

				case 3971629275:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(WindBranchL2));

				case 3999221459:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(TreeFallEffect));

				case 2951351665:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(BreakableJointThreshold));

				case 3686844968:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(FallDirectionEnd));

				case 576309707:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(LocalWindEffect));

				case 952638448:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(ImpactThreshold));

				case 2929818610:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(CollisionImpactMultiplier));

				case 3490532775:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(FallDirectionStart));

				case 609468470:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(SplashDistantEffect));

				case 494798614:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(BulletImpactEffect));

				case 209652569:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(PartsTimeToLive));

				case 1990024297:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(ShadowLODOffset));

				case 3849130143:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(SplashNearEffect));

				case 2616680812:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(CollisionEffect));

				case 3014405532:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(ForceFullSim));

				case 215104275:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(UseImpactThreshold));

				case 3641740433:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(UsePhysicsShapes));

				case 553666876:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(ConstraintStemB1));

				case 553666879:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(ConstraintStemB2));

				case 3628043763:
					return typeof(VegetationTreeEntityData).GetProperty(nameof(ClientSideOnly));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
