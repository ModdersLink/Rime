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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class WeaponStateData : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(65), ContainerArray]
		public List<uint> ReferencedAssetHashes { get; set; } = new List<uint>(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(65), ContainerRefArray]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new RefArray<BoneFakePhysicsData>(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<SkinnedMeshAsset> Mesh1p { get; set; } = new CtrRef<SkinnedMeshAsset>(); // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<SkinnedMeshAsset> MeshZoom1p { get; set; } = new CtrRef<SkinnedMeshAsset>(); // 0xC (12)
		
		[ContainerField(16), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<SkinnedMeshAsset> Mesh3p { get; set; } = new CtrRef<SkinnedMeshAsset>(); // 0x10 (16)
		
		[ContainerField(20), MemberInfoFlag(41)]
		public AntRef Weapon { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ZoomMeshTransitionFactor { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ZoomScaleFactor { get; set; } // 0x1C (28)
		
		[ContainerField(32), MemberInfoFlag(65), ContainerArray]
		public List<float> ZoomInOutMeshTransitionFactors { get; set; } = new List<float>(); // 0x20 (32)
		
		[ContainerField(36), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<ScopeFilterData> ZoomedScopeFilter { get; set; } = new CtrRef<ScopeFilterData>(); // 0x24 (36)
		
		[ContainerField(40), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<ScopeFilterData> NonZoomedScopeFilter { get; set; } = new CtrRef<ScopeFilterData>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float KeepAimingTime { get; set; } // 0x2C (44)
		
		[ContainerField(48), MemberInfoFlag(41)]
		public AnimationConfigurationData AnimationConfiguration { get; set; } = new AnimationConfigurationData(); // 0x30 (48)
		
		[ContainerField(60), MemberInfoFlag(137)]
		public AnimatedFireEnum AnimatedFireType { get; set; } = new AnimatedFireEnum(); // 0x3C (60)
		
		[ContainerField(64), MemberInfoFlag(137)]
		public AnimatedAimingEnum AnimatedAimingType { get; set; } = new AnimatedAimingEnum(); // 0x40 (64)
		
		[ContainerField(68), MemberInfoFlag(65), ContainerArray]
		public List<LinearTransform> Mesh3pTransforms { get; set; } = new List<LinearTransform>(); // 0x44 (68)
		
		[ContainerField(72), MemberInfoFlag(65), ContainerArray]
		public List<RigidMeshSocketTransform> Mesh3pRigidMeshSocketObjectTransforms { get; set; } = new List<RigidMeshSocketTransform>(); // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float HideProjectileAfterFireTime { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, MemberInfoFlag(16509)]
		public string ProjectileBoneName { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool IsOneHanded { get; set; } // 0x54 (84)
		
		[ContainerField(85), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool PlayDeployAfterFire { get; set; } // 0x55 (85)
		
		[ContainerField(86), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool SkipFireAnimation { get; set; } // 0x56 (86)
		
		[ContainerField(87), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool SkipDeployAnimation { get; set; } // 0x57 (87)
		
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool SkipReloadAnimation { get; set; } // 0x58 (88)
		
		[ContainerField(89), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool AlwaysAimHead { get; set; } // 0x59 (89)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3589205886:
					ReferencedAssetHashes = (List<uint>) p_Value;
					break;

				case 2227758113:
					BoneFakePhysics = (RefArray<BoneFakePhysicsData>) p_Value;
					break;

				case 2648063895:
					Mesh1p = (CtrRef<SkinnedMeshAsset>) p_Value;
					break;

				case 19960000:
					MeshZoom1p = (CtrRef<SkinnedMeshAsset>) p_Value;
					break;

				case 2648063957:
					Mesh3p = (CtrRef<SkinnedMeshAsset>) p_Value;
					break;

				case 3190562823:
					Weapon = (AntRef) p_Value;
					break;

				case 3770881859:
					ZoomMeshTransitionFactor = (float) p_Value;
					break;

				case 840793031:
					ZoomScaleFactor = (float) p_Value;
					break;

				case 1322171705:
					ZoomInOutMeshTransitionFactors = (List<float>) p_Value;
					break;

				case 852738745:
					ZoomedScopeFilter = (CtrRef<ScopeFilterData>) p_Value;
					break;

				case 2182858966:
					NonZoomedScopeFilter = (CtrRef<ScopeFilterData>) p_Value;
					break;

				case 2567043342:
					KeepAimingTime = (float) p_Value;
					break;

				case 711248867:
					AnimationConfiguration = (AnimationConfigurationData) p_Value;
					break;

				case 1066105722:
						AnimatedFireType = (AnimatedFireEnum) Enum.ToObject(typeof(AnimatedFireEnum), p_Value);
					break;

				case 2384119975:
						AnimatedAimingType = (AnimatedAimingEnum) Enum.ToObject(typeof(AnimatedAimingEnum), p_Value);
					break;

				case 1625436330:
					Mesh3pTransforms = (List<LinearTransform>) p_Value;
					break;

				case 2631945560:
					Mesh3pRigidMeshSocketObjectTransforms = (List<RigidMeshSocketTransform>) p_Value;
					break;

				case 905979417:
					HideProjectileAfterFireTime = (float) p_Value;
					break;

				case 1352166801:
					ProjectileBoneName = (string) p_Value;
					break;

				case 2053998137:
					IsOneHanded = (bool) p_Value;
					break;

				case 876103510:
					PlayDeployAfterFire = (bool) p_Value;
					break;

				case 1175954314:
					SkipFireAnimation = (bool) p_Value;
					break;

				case 2215837145:
					SkipDeployAnimation = (bool) p_Value;
					break;

				case 2233306307:
					SkipReloadAnimation = (bool) p_Value;
					break;

				case 3649734905:
					AlwaysAimHead = (bool) p_Value;
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
				case 3589205886:
					return ReferencedAssetHashes;

				case 2227758113:
					return BoneFakePhysics;

				case 2648063895:
					return Mesh1p;

				case 19960000:
					return MeshZoom1p;

				case 2648063957:
					return Mesh3p;

				case 3190562823:
					return Weapon;

				case 3770881859:
					return ZoomMeshTransitionFactor;

				case 840793031:
					return ZoomScaleFactor;

				case 1322171705:
					return ZoomInOutMeshTransitionFactors;

				case 852738745:
					return ZoomedScopeFilter;

				case 2182858966:
					return NonZoomedScopeFilter;

				case 2567043342:
					return KeepAimingTime;

				case 711248867:
					return AnimationConfiguration;

				case 1066105722:
					return AnimatedFireType;

				case 2384119975:
					return AnimatedAimingType;

				case 1625436330:
					return Mesh3pTransforms;

				case 2631945560:
					return Mesh3pRigidMeshSocketObjectTransforms;

				case 905979417:
					return HideProjectileAfterFireTime;

				case 1352166801:
					return ProjectileBoneName;

				case 2053998137:
					return IsOneHanded;

				case 876103510:
					return PlayDeployAfterFire;

				case 1175954314:
					return SkipFireAnimation;

				case 2215837145:
					return SkipDeployAnimation;

				case 2233306307:
					return SkipReloadAnimation;

				case 3649734905:
					return AlwaysAimHead;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3589205886:
					return typeof(WeaponStateData).GetProperty(nameof(ReferencedAssetHashes));

				case 2227758113:
					return typeof(WeaponStateData).GetProperty(nameof(BoneFakePhysics));

				case 2648063895:
					return typeof(WeaponStateData).GetProperty(nameof(Mesh1p));

				case 19960000:
					return typeof(WeaponStateData).GetProperty(nameof(MeshZoom1p));

				case 2648063957:
					return typeof(WeaponStateData).GetProperty(nameof(Mesh3p));

				case 3190562823:
					return typeof(WeaponStateData).GetProperty(nameof(Weapon));

				case 3770881859:
					return typeof(WeaponStateData).GetProperty(nameof(ZoomMeshTransitionFactor));

				case 840793031:
					return typeof(WeaponStateData).GetProperty(nameof(ZoomScaleFactor));

				case 1322171705:
					return typeof(WeaponStateData).GetProperty(nameof(ZoomInOutMeshTransitionFactors));

				case 852738745:
					return typeof(WeaponStateData).GetProperty(nameof(ZoomedScopeFilter));

				case 2182858966:
					return typeof(WeaponStateData).GetProperty(nameof(NonZoomedScopeFilter));

				case 2567043342:
					return typeof(WeaponStateData).GetProperty(nameof(KeepAimingTime));

				case 711248867:
					return typeof(WeaponStateData).GetProperty(nameof(AnimationConfiguration));

				case 1066105722:
					return typeof(WeaponStateData).GetProperty(nameof(AnimatedFireType));

				case 2384119975:
					return typeof(WeaponStateData).GetProperty(nameof(AnimatedAimingType));

				case 1625436330:
					return typeof(WeaponStateData).GetProperty(nameof(Mesh3pTransforms));

				case 2631945560:
					return typeof(WeaponStateData).GetProperty(nameof(Mesh3pRigidMeshSocketObjectTransforms));

				case 905979417:
					return typeof(WeaponStateData).GetProperty(nameof(HideProjectileAfterFireTime));

				case 1352166801:
					return typeof(WeaponStateData).GetProperty(nameof(ProjectileBoneName));

				case 2053998137:
					return typeof(WeaponStateData).GetProperty(nameof(IsOneHanded));

				case 876103510:
					return typeof(WeaponStateData).GetProperty(nameof(PlayDeployAfterFire));

				case 1175954314:
					return typeof(WeaponStateData).GetProperty(nameof(SkipFireAnimation));

				case 2215837145:
					return typeof(WeaponStateData).GetProperty(nameof(SkipDeployAnimation));

				case 2233306307:
					return typeof(WeaponStateData).GetProperty(nameof(SkipReloadAnimation));

				case 3649734905:
					return typeof(WeaponStateData).GetProperty(nameof(AlwaysAimHead));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
