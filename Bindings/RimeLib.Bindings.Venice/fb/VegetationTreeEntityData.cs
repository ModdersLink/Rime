///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class VegetationTreeEntityData : 
		VegetationBaseEntityData
	{
		protected CtrRef<EffectBlueprint> m_GroundImpactEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(128), ContainerFieldNameHash(1595516597)]
		public CtrRef<EffectBlueprint> GroundImpactEffect { get { return m_GroundImpactEffect; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(GroundImpactEffect), this, m_GroundImpactEffect, value)) m_GroundImpactEffect = value; } } // 0x80 (128)
		
		protected CtrRef<EffectBlueprint> m_StemRipEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(132), ContainerFieldNameHash(935864630)]
		public CtrRef<EffectBlueprint> StemRipEffect { get { return m_StemRipEffect; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(StemRipEffect), this, m_StemRipEffect, value)) m_StemRipEffect = value; } } // 0x84 (132)
		
		protected float m_StemPhysicsWidth = new float();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(3773105703)]
		public float StemPhysicsWidth { get { return m_StemPhysicsWidth; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(StemPhysicsWidth), this, m_StemPhysicsWidth, value)) m_StemPhysicsWidth = value; } } // 0x88 (136)
		
		protected float m_ColiPlaneDepth = new float();
		[ContainerField(140), LayoutImmutable, Blittable, ContainerFieldNameHash(119595447)]
		public float ColiPlaneDepth { get { return m_ColiPlaneDepth; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(ColiPlaneDepth), this, m_ColiPlaneDepth, value)) m_ColiPlaneDepth = value; } } // 0x8C (140)
		
		protected float m_StemHitpoints = new float();
		[ContainerField(144), LayoutImmutable, Blittable, ContainerFieldNameHash(156129888)]
		public float StemHitpoints { get { return m_StemHitpoints; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(StemHitpoints), this, m_StemHitpoints, value)) m_StemHitpoints = value; } } // 0x90 (144)
		
		protected float m_BranchHitpoints = new float();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(3684887323)]
		public float BranchHitpoints { get { return m_BranchHitpoints; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(BranchHitpoints), this, m_BranchHitpoints, value)) m_BranchHitpoints = value; } } // 0x94 (148)
		
		protected float m_BranchL2Hitpoints = new float();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(204675493)]
		public float BranchL2Hitpoints { get { return m_BranchL2Hitpoints; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(BranchL2Hitpoints), this, m_BranchL2Hitpoints, value)) m_BranchL2Hitpoints = value; } } // 0x98 (152)
		
		protected float m_StemStiffness = new float();
		[ContainerField(156), LayoutImmutable, Blittable, ContainerFieldNameHash(257375119)]
		public float StemStiffness { get { return m_StemStiffness; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(StemStiffness), this, m_StemStiffness, value)) m_StemStiffness = value; } } // 0x9C (156)
		
		protected float m_StemStiffnessSpread = new float();
		[ContainerField(160), LayoutImmutable, Blittable, ContainerFieldNameHash(713063358)]
		public float StemStiffnessSpread { get { return m_StemStiffnessSpread; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(StemStiffnessSpread), this, m_StemStiffnessSpread, value)) m_StemStiffnessSpread = value; } } // 0xA0 (160)
		
		protected float m_BranchStiffness = new float();
		[ContainerField(164), LayoutImmutable, Blittable, ContainerFieldNameHash(1421593844)]
		public float BranchStiffness { get { return m_BranchStiffness; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(BranchStiffness), this, m_BranchStiffness, value)) m_BranchStiffness = value; } } // 0xA4 (164)
		
		protected float m_BranchStiffnessL2 = new float();
		[ContainerField(168), LayoutImmutable, Blittable, ContainerFieldNameHash(1927467530)]
		public float BranchStiffnessL2 { get { return m_BranchStiffnessL2; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(BranchStiffnessL2), this, m_BranchStiffnessL2, value)) m_BranchStiffnessL2 = value; } } // 0xA8 (168)
		
		protected int m_StemBoneCount = new int();
		[ContainerField(172), LayoutImmutable, Blittable, ContainerFieldNameHash(4140582895)]
		public int StemBoneCount { get { return m_StemBoneCount; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(StemBoneCount), this, m_StemBoneCount, value)) m_StemBoneCount = value; } } // 0xAC (172)
		
		protected float m_WindStem = new float();
		[ContainerField(176), LayoutImmutable, Blittable, ContainerFieldNameHash(356803134)]
		public float WindStem { get { return m_WindStem; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(WindStem), this, m_WindStem, value)) m_WindStem = value; } } // 0xB0 (176)
		
		protected float m_WindBranch = new float();
		[ContainerField(180), LayoutImmutable, Blittable, ContainerFieldNameHash(2551442149)]
		public float WindBranch { get { return m_WindBranch; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(WindBranch), this, m_WindBranch, value)) m_WindBranch = value; } } // 0xB4 (180)
		
		protected float m_WindBranchL2 = new float();
		[ContainerField(184), LayoutImmutable, Blittable, ContainerFieldNameHash(3971629275)]
		public float WindBranchL2 { get { return m_WindBranchL2; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(WindBranchL2), this, m_WindBranchL2, value)) m_WindBranchL2 = value; } } // 0xB8 (184)
		
		protected CtrRef<EffectBlueprint> m_TreeFallEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(188), ContainerFieldNameHash(3999221459)]
		public CtrRef<EffectBlueprint> TreeFallEffect { get { return m_TreeFallEffect; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(TreeFallEffect), this, m_TreeFallEffect, value)) m_TreeFallEffect = value; } } // 0xBC (188)
		
		protected float m_BreakableJointThreshold = new float();
		[ContainerField(192), LayoutImmutable, Blittable, ContainerFieldNameHash(2951351665)]
		public float BreakableJointThreshold { get { return m_BreakableJointThreshold; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(BreakableJointThreshold), this, m_BreakableJointThreshold, value)) m_BreakableJointThreshold = value; } } // 0xC0 (192)
		
		protected float m_FallDirectionEnd = new float();
		[ContainerField(196), LayoutImmutable, Blittable, ContainerFieldNameHash(3686844968)]
		public float FallDirectionEnd { get { return m_FallDirectionEnd; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(FallDirectionEnd), this, m_FallDirectionEnd, value)) m_FallDirectionEnd = value; } } // 0xC4 (196)
		
		protected CtrRef<EffectBlueprint> m_LocalWindEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(200), ContainerFieldNameHash(576309707)]
		public CtrRef<EffectBlueprint> LocalWindEffect { get { return m_LocalWindEffect; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(LocalWindEffect), this, m_LocalWindEffect, value)) m_LocalWindEffect = value; } } // 0xC8 (200)
		
		protected float m_ImpactThreshold = new float();
		[ContainerField(204), LayoutImmutable, Blittable, ContainerFieldNameHash(952638448)]
		public float ImpactThreshold { get { return m_ImpactThreshold; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(ImpactThreshold), this, m_ImpactThreshold, value)) m_ImpactThreshold = value; } } // 0xCC (204)
		
		protected float m_CollisionImpactMultiplier = new float();
		[ContainerField(208), LayoutImmutable, Blittable, ContainerFieldNameHash(2929818610)]
		public float CollisionImpactMultiplier { get { return m_CollisionImpactMultiplier; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(CollisionImpactMultiplier), this, m_CollisionImpactMultiplier, value)) m_CollisionImpactMultiplier = value; } } // 0xD0 (208)
		
		protected float m_FallDirectionStart = new float();
		[ContainerField(212), LayoutImmutable, Blittable, ContainerFieldNameHash(3490532775)]
		public float FallDirectionStart { get { return m_FallDirectionStart; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(FallDirectionStart), this, m_FallDirectionStart, value)) m_FallDirectionStart = value; } } // 0xD4 (212)
		
		protected CtrRef<EffectBlueprint> m_SplashDistantEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(216), ContainerFieldNameHash(609468470)]
		public CtrRef<EffectBlueprint> SplashDistantEffect { get { return m_SplashDistantEffect; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(SplashDistantEffect), this, m_SplashDistantEffect, value)) m_SplashDistantEffect = value; } } // 0xD8 (216)
		
		protected CtrRef<EffectBlueprint> m_BulletImpactEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(220), ContainerFieldNameHash(494798614)]
		public CtrRef<EffectBlueprint> BulletImpactEffect { get { return m_BulletImpactEffect; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(BulletImpactEffect), this, m_BulletImpactEffect, value)) m_BulletImpactEffect = value; } } // 0xDC (220)
		
		protected float m_PartsTimeToLive = new float();
		[ContainerField(224), LayoutImmutable, Blittable, ContainerFieldNameHash(209652569)]
		public float PartsTimeToLive { get { return m_PartsTimeToLive; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(PartsTimeToLive), this, m_PartsTimeToLive, value)) m_PartsTimeToLive = value; } } // 0xE0 (224)
		
		protected uint m_ShadowLODOffset = new uint();
		[ContainerField(228), LayoutImmutable, Blittable, ContainerFieldNameHash(1990024297)]
		public uint ShadowLODOffset { get { return m_ShadowLODOffset; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(ShadowLODOffset), this, m_ShadowLODOffset, value)) m_ShadowLODOffset = value; } } // 0xE4 (228)
		
		protected CtrRef<EffectBlueprint> m_SplashNearEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(232), ContainerFieldNameHash(3849130143)]
		public CtrRef<EffectBlueprint> SplashNearEffect { get { return m_SplashNearEffect; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(SplashNearEffect), this, m_SplashNearEffect, value)) m_SplashNearEffect = value; } } // 0xE8 (232)
		
		protected CtrRef<EffectBlueprint> m_CollisionEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(236), ContainerFieldNameHash(2616680812)]
		public CtrRef<EffectBlueprint> CollisionEffect { get { return m_CollisionEffect; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(CollisionEffect), this, m_CollisionEffect, value)) m_CollisionEffect = value; } } // 0xEC (236)
		
		protected bool m_ForceFullSim = new bool();
		[ContainerField(240), LayoutImmutable, Blittable, ContainerFieldNameHash(3014405532)]
		public bool ForceFullSim { get { return m_ForceFullSim; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(ForceFullSim), this, m_ForceFullSim, value)) m_ForceFullSim = value; } } // 0xF0 (240)
		
		protected bool m_UseImpactThreshold = new bool();
		[ContainerField(241), LayoutImmutable, Blittable, ContainerFieldNameHash(215104275)]
		public bool UseImpactThreshold { get { return m_UseImpactThreshold; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(UseImpactThreshold), this, m_UseImpactThreshold, value)) m_UseImpactThreshold = value; } } // 0xF1 (241)
		
		protected bool m_UsePhysicsShapes = new bool();
		[ContainerField(242), LayoutImmutable, Blittable, ContainerFieldNameHash(3641740433)]
		public bool UsePhysicsShapes { get { return m_UsePhysicsShapes; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(UsePhysicsShapes), this, m_UsePhysicsShapes, value)) m_UsePhysicsShapes = value; } } // 0xF2 (242)
		
		protected bool m_ConstraintStemB1 = new bool();
		[ContainerField(243), LayoutImmutable, Blittable, ContainerFieldNameHash(553666876)]
		public bool ConstraintStemB1 { get { return m_ConstraintStemB1; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(ConstraintStemB1), this, m_ConstraintStemB1, value)) m_ConstraintStemB1 = value; } } // 0xF3 (243)
		
		protected bool m_ConstraintStemB2 = new bool();
		[ContainerField(244), LayoutImmutable, Blittable, ContainerFieldNameHash(553666879)]
		public bool ConstraintStemB2 { get { return m_ConstraintStemB2; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(ConstraintStemB2), this, m_ConstraintStemB2, value)) m_ConstraintStemB2 = value; } } // 0xF4 (244)
		
		protected bool m_ClientSideOnly = new bool();
		[ContainerField(245), LayoutImmutable, Blittable, ContainerFieldNameHash(3628043763)]
		public bool ClientSideOnly { get { return m_ClientSideOnly; } set { if (OnPropertyChanging("VegetationTreeEntityData." + nameof(ClientSideOnly), this, m_ClientSideOnly, value)) m_ClientSideOnly = value; } } // 0xF5 (245)
		
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
