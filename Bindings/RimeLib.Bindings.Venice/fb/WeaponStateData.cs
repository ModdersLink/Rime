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
	[ContainerType(4, 92)]
	public class WeaponStateData
	{
		[ContainerField(0)]
		public List<uint> ReferencedAssetHashes { get; set; } = new();
		
		[ContainerField(4)]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new();
		
		[ContainerField(8)]
		public CtrRef<SkinnedMeshAsset> Mesh1p { get; set; } = new();
		
		[ContainerField(12)]
		public CtrRef<SkinnedMeshAsset> MeshZoom1p { get; set; } = new();
		
		[ContainerField(16)]
		public CtrRef<SkinnedMeshAsset> Mesh3p { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef Weapon { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ZoomMeshTransitionFactor { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ZoomScaleFactor { get; set; }
		
		[ContainerField(32)]
		public List<float> ZoomInOutMeshTransitionFactors { get; set; } = new();
		
		[ContainerField(36)]
		public CtrRef<ScopeFilterData> ZoomedScopeFilter { get; set; } = new();
		
		[ContainerField(40)]
		public CtrRef<ScopeFilterData> NonZoomedScopeFilter { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float KeepAimingTime { get; set; }
		
		[ContainerField(48)]
		public AnimationConfigurationData AnimationConfiguration { get; set; } = new();
		
		[ContainerField(60)]
		public AnimatedFireEnum AnimatedFireType { get; set; } = new();
		
		[ContainerField(64)]
		public AnimatedAimingEnum AnimatedAimingType { get; set; } = new();
		
		[ContainerField(68)]
		public List<LinearTransform> Mesh3pTransforms { get; set; } = new();
		
		[ContainerField(72)]
		public List<RigidMeshSocketTransform> Mesh3pRigidMeshSocketObjectTransforms { get; set; } = new();
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float HideProjectileAfterFireTime { get; set; }
		
		[ContainerField(80), LayoutImmutable]
		public string ProjectileBoneName { get; set; } = string.Empty;
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public bool IsOneHanded { get; set; }
		
		[ContainerField(85), LayoutImmutable, Blittable]
		public bool PlayDeployAfterFire { get; set; }
		
		[ContainerField(86), LayoutImmutable, Blittable]
		public bool SkipFireAnimation { get; set; }
		
		[ContainerField(87), LayoutImmutable, Blittable]
		public bool SkipDeployAnimation { get; set; }
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public bool SkipReloadAnimation { get; set; }
		
		[ContainerField(89), LayoutImmutable, Blittable]
		public bool AlwaysAimHead { get; set; }
		
	}
}
