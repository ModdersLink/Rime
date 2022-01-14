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

namespace fb
{
	[ContainerType(4, 92)]
	public class WeaponStateData
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<uint> ReferencedAssetHashes { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<SkinnedMeshAsset> Mesh1p { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SkinnedMeshAsset> MeshZoom1p { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<SkinnedMeshAsset> Mesh3p { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef Weapon { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float ZoomMeshTransitionFactor { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ZoomScaleFactor { get; set; }
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public List<float> ZoomInOutMeshTransitionFactors { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<ScopeFilterData> ZoomedScopeFilter { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<ScopeFilterData> NonZoomedScopeFilter { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float KeepAimingTime { get; set; }
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public AnimationConfigurationData AnimationConfiguration { get; set; } = new();
		
		[ContainerField(60), JsonProperty(Order = 60)]
		public AnimatedFireEnum AnimatedFireType { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public AnimatedAimingEnum AnimatedAimingType { get; set; } = new();
		
		[ContainerField(68), JsonProperty(Order = 68)]
		public List<LinearTransform> Mesh3pTransforms { get; set; } = new();
		
		[ContainerField(72), JsonProperty(Order = 72)]
		public List<RigidMeshSocketTransform> Mesh3pRigidMeshSocketObjectTransforms { get; set; } = new();
		
		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float HideProjectileAfterFireTime { get; set; }
		
		[ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		public string ProjectileBoneName { get; set; } = string.Empty;
		
		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public bool IsOneHanded { get; set; }
		
		[ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		public bool PlayDeployAfterFire { get; set; }
		
		[ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		public bool SkipFireAnimation { get; set; }
		
		[ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		public bool SkipDeployAnimation { get; set; }
		
		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public bool SkipReloadAnimation { get; set; }
		
		[ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		public bool AlwaysAimHead { get; set; }
		
	}
}
