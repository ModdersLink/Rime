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
	[ContainerType(16, 144)]
	public class ModelAnimationEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AnimationEntitySpace { get; set; } = new();

		[ContainerField(80)]
		public GameplayBones BoneToPlace { get; set; } = new();

		[ContainerField(84)]
		public Realm Realm { get; set; } = new();

		[ContainerField(88)]
		public ModelAnimationTransformType ModelAnimationTransformType { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable]
		public int InstanceSeed { get; set; }

		[ContainerField(96), LayoutImmutable]
		public string DefaultAnimation { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable, Blittable]
		public int AnimationIndex { get; set; }

		[ContainerField(104)]
		public CtrRef<AntAnimationSetAsset> AnimationSet { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; }

		[ContainerField(112), LayoutImmutable]
		public string RootMeshBoneName { get; set; } = string.Empty;

		[ContainerField(116)]
		public ModelAnimationUpdateOrder JointWorldTransformUpdateOrder { get; set; } = new();

		[ContainerField(120), LayoutImmutable]
		public string ConnectBoneName { get; set; } = string.Empty;

		[ContainerField(124)]
		public List<int> JointOutputPropertyIds { get; set; } = new();

		[ContainerField(128), LayoutImmutable]
		public string TrajectoryBoneName { get; set; } = string.Empty;

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool AnimationEntitySpaceActive { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable]
		public bool PlayFirstFrame { get; set; }

		[ContainerField(134), LayoutImmutable, Blittable]
		public bool Looping { get; set; }

		[ContainerField(135), LayoutImmutable, Blittable]
		public bool EnableJointWorldTransformOutput { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool ResetAfterStop { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable]
		public bool ShowDebugTransforms { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable]
		public bool ApplyRotationCompensation { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool ApplyPreTransformation { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable]
		public bool DisableCulling { get; set; }

	}
}
