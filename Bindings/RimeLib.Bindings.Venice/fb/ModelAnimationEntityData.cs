///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ModelAnimationEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AnimationEntitySpace { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80)]
		public GameplayBones BoneToPlace { get; set; } = new GameplayBones(); // 0x50 (80)
		
		[ContainerField(84)]
		public Realm Realm { get; set; } = new Realm(); // 0x54 (84)
		
		[ContainerField(88)]
		public ModelAnimationTransformType ModelAnimationTransformType { get; set; } = new ModelAnimationTransformType(); // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public int InstanceSeed { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable]
		public string DefaultAnimation { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public int AnimationIndex { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<AntAnimationSetAsset> AnimationSet { get; set; } = new CtrRef<AntAnimationSetAsset>(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable]
		public string RootMeshBoneName { get; set; } // 0x70 (112)
		
		[ContainerField(116)]
		public ModelAnimationUpdateOrder JointWorldTransformUpdateOrder { get; set; } = new ModelAnimationUpdateOrder(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable]
		public string ConnectBoneName { get; set; } // 0x78 (120)
		
		[ContainerField(124)]
		public List<int> JointOutputPropertyIds { get; set; } = new List<int>(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable]
		public string TrajectoryBoneName { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public bool AnimationEntitySpaceActive { get; set; } // 0x84 (132)
		
		[ContainerField(133), LayoutImmutable, Blittable]
		public bool PlayFirstFrame { get; set; } // 0x85 (133)
		
		[ContainerField(134), LayoutImmutable, Blittable]
		public bool Looping { get; set; } // 0x86 (134)
		
		[ContainerField(135), LayoutImmutable, Blittable]
		public bool EnableJointWorldTransformOutput { get; set; } // 0x87 (135)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public bool ResetAfterStop { get; set; } // 0x88 (136)
		
		[ContainerField(137), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; } // 0x89 (137)
		
		[ContainerField(138), LayoutImmutable, Blittable]
		public bool ShowDebugTransforms { get; set; } // 0x8A (138)
		
		[ContainerField(139), LayoutImmutable, Blittable]
		public bool ApplyRotationCompensation { get; set; } // 0x8B (139)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool ApplyPreTransformation { get; set; } // 0x8C (140)
		
		[ContainerField(141), LayoutImmutable, Blittable]
		public bool DisableCulling { get; set; } // 0x8D (141)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3836649996:
					AnimationEntitySpace = (LinearTransform) p_Value;
					break;

				case 893212963:
					BoneToPlace = (GameplayBones) Enum.ToObject(typeof(GameplayBones), p_Value);
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 503696712:
					ModelAnimationTransformType = (ModelAnimationTransformType) Enum.ToObject(typeof(ModelAnimationTransformType), p_Value);
					break;

				case 1188203099:
					InstanceSeed = (int) p_Value;
					break;

				case 1576290296:
					DefaultAnimation = (string) p_Value;
					break;

				case 3090730541:
					AnimationIndex = (int) p_Value;
					break;

				case 2168045937:
					AnimationSet = (CtrRef<AntAnimationSetAsset>) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 2494072593:
					RootMeshBoneName = (string) p_Value;
					break;

				case 3480116738:
					JointWorldTransformUpdateOrder = (ModelAnimationUpdateOrder) Enum.ToObject(typeof(ModelAnimationUpdateOrder), p_Value);
					break;

				case 1693705370:
					ConnectBoneName = (string) p_Value;
					break;

				case 2683361333:
					JointOutputPropertyIds = (List<int>) p_Value;
					break;

				case 4054639135:
					TrajectoryBoneName = (string) p_Value;
					break;

				case 3057023040:
					AnimationEntitySpaceActive = (bool) p_Value;
					break;

				case 2522640870:
					PlayFirstFrame = (bool) p_Value;
					break;

				case 1366646169:
					Looping = (bool) p_Value;
					break;

				case 3310194691:
					EnableJointWorldTransformOutput = (bool) p_Value;
					break;

				case 3668699372:
					ResetAfterStop = (bool) p_Value;
					break;

				case 792615882:
					AutoStart = (bool) p_Value;
					break;

				case 431328136:
					ShowDebugTransforms = (bool) p_Value;
					break;

				case 3033753969:
					ApplyRotationCompensation = (bool) p_Value;
					break;

				case 3130194119:
					ApplyPreTransformation = (bool) p_Value;
					break;

				case 900615207:
					DisableCulling = (bool) p_Value;
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
				case 3836649996:
					return AnimationEntitySpace;

				case 893212963:
					return BoneToPlace;

				case 229961746:
					return Realm;

				case 503696712:
					return ModelAnimationTransformType;

				case 1188203099:
					return InstanceSeed;

				case 1576290296:
					return DefaultAnimation;

				case 3090730541:
					return AnimationIndex;

				case 2168045937:
					return AnimationSet;

				case 2162678253:
					return ExternalTime;

				case 2494072593:
					return RootMeshBoneName;

				case 3480116738:
					return JointWorldTransformUpdateOrder;

				case 1693705370:
					return ConnectBoneName;

				case 2683361333:
					return JointOutputPropertyIds;

				case 4054639135:
					return TrajectoryBoneName;

				case 3057023040:
					return AnimationEntitySpaceActive;

				case 2522640870:
					return PlayFirstFrame;

				case 1366646169:
					return Looping;

				case 3310194691:
					return EnableJointWorldTransformOutput;

				case 3668699372:
					return ResetAfterStop;

				case 792615882:
					return AutoStart;

				case 431328136:
					return ShowDebugTransforms;

				case 3033753969:
					return ApplyRotationCompensation;

				case 3130194119:
					return ApplyPreTransformation;

				case 900615207:
					return DisableCulling;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3836649996:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(AnimationEntitySpace));

				case 893212963:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(BoneToPlace));

				case 229961746:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(Realm));

				case 503696712:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(ModelAnimationTransformType));

				case 1188203099:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(InstanceSeed));

				case 1576290296:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(DefaultAnimation));

				case 3090730541:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(AnimationIndex));

				case 2168045937:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(AnimationSet));

				case 2162678253:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(ExternalTime));

				case 2494072593:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(RootMeshBoneName));

				case 3480116738:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(JointWorldTransformUpdateOrder));

				case 1693705370:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(ConnectBoneName));

				case 2683361333:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(JointOutputPropertyIds));

				case 4054639135:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(TrajectoryBoneName));

				case 3057023040:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(AnimationEntitySpaceActive));

				case 2522640870:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(PlayFirstFrame));

				case 1366646169:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(Looping));

				case 3310194691:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(EnableJointWorldTransformOutput));

				case 3668699372:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(ResetAfterStop));

				case 792615882:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(AutoStart));

				case 431328136:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(ShowDebugTransforms));

				case 3033753969:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(ApplyRotationCompensation));

				case 3130194119:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(ApplyPreTransformation));

				case 900615207:
					return typeof(ModelAnimationEntityData).GetProperty(nameof(DisableCulling));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
