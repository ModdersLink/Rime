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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 144)]
	public class ModelAnimationEntityData : 
		EntityData
	{
		protected LinearTransform m_AnimationEntitySpace = new LinearTransform();
		[ContainerField(Name: "AnimationEntitySpace", Offset: 16, NameHash: 3836649996, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AnimationEntitySpace { get { return m_AnimationEntitySpace; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(AnimationEntitySpace), this, m_AnimationEntitySpace, value)) m_AnimationEntitySpace = value; } } // 0x10 (16)
		
		protected GameplayBones m_BoneToPlace = new GameplayBones();
		[ContainerField(Name: "BoneToPlace", Offset: 80, NameHash: 893212963, Flags: 137)]
		public GameplayBones BoneToPlace { get { return m_BoneToPlace; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(BoneToPlace), this, m_BoneToPlace, value)) m_BoneToPlace = value; } } // 0x50 (80)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 84, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x54 (84)
		
		protected ModelAnimationTransformType m_ModelAnimationTransformType = new ModelAnimationTransformType();
		[ContainerField(Name: "ModelAnimationTransformType", Offset: 88, NameHash: 503696712, Flags: 137)]
		public ModelAnimationTransformType ModelAnimationTransformType { get { return m_ModelAnimationTransformType; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(ModelAnimationTransformType), this, m_ModelAnimationTransformType, value)) m_ModelAnimationTransformType = value; } } // 0x58 (88)
		
		protected int m_InstanceSeed = new int();
		[ContainerField(Name: "InstanceSeed", Offset: 92, NameHash: 1188203099, Flags: 49405), LayoutImmutable, Blittable]
		public int InstanceSeed { get { return m_InstanceSeed; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(InstanceSeed), this, m_InstanceSeed, value)) m_InstanceSeed = value; } } // 0x5C (92)
		
		protected string m_DefaultAnimation = string.Empty;
		[ContainerField(Name: "DefaultAnimation", Offset: 96, NameHash: 1576290296, Flags: 16509), LayoutImmutable]
		public string DefaultAnimation { get { return m_DefaultAnimation; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(DefaultAnimation), this, m_DefaultAnimation, value)) m_DefaultAnimation = value; } } // 0x60 (96)
		
		protected int m_AnimationIndex = new int();
		[ContainerField(Name: "AnimationIndex", Offset: 100, NameHash: 3090730541, Flags: 49405), LayoutImmutable, Blittable]
		public int AnimationIndex { get { return m_AnimationIndex; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(AnimationIndex), this, m_AnimationIndex, value)) m_AnimationIndex = value; } } // 0x64 (100)
		
		protected CtrRef<AntAnimationSetAsset> m_AnimationSet = new CtrRef<AntAnimationSetAsset>();
		[ContainerField(Name: "AnimationSet", Offset: 104, NameHash: 2168045937, Flags: 53)]
		public CtrRef<AntAnimationSetAsset> AnimationSet { get { return m_AnimationSet; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(AnimationSet), this, m_AnimationSet, value)) m_AnimationSet = value; } } // 0x68 (104)
		
		protected float m_ExternalTime = new float();
		[ContainerField(Name: "ExternalTime", Offset: 108, NameHash: 2162678253, Flags: 49469), LayoutImmutable, Blittable]
		public float ExternalTime { get { return m_ExternalTime; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(ExternalTime), this, m_ExternalTime, value)) m_ExternalTime = value; } } // 0x6C (108)
		
		protected string m_RootMeshBoneName = string.Empty;
		[ContainerField(Name: "RootMeshBoneName", Offset: 112, NameHash: 2494072593, Flags: 16509), LayoutImmutable]
		public string RootMeshBoneName { get { return m_RootMeshBoneName; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(RootMeshBoneName), this, m_RootMeshBoneName, value)) m_RootMeshBoneName = value; } } // 0x70 (112)
		
		protected ModelAnimationUpdateOrder m_JointWorldTransformUpdateOrder = new ModelAnimationUpdateOrder();
		[ContainerField(Name: "JointWorldTransformUpdateOrder", Offset: 116, NameHash: 3480116738, Flags: 137)]
		public ModelAnimationUpdateOrder JointWorldTransformUpdateOrder { get { return m_JointWorldTransformUpdateOrder; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(JointWorldTransformUpdateOrder), this, m_JointWorldTransformUpdateOrder, value)) m_JointWorldTransformUpdateOrder = value; } } // 0x74 (116)
		
		protected string m_ConnectBoneName = string.Empty;
		[ContainerField(Name: "ConnectBoneName", Offset: 120, NameHash: 1693705370, Flags: 16509), LayoutImmutable]
		public string ConnectBoneName { get { return m_ConnectBoneName; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(ConnectBoneName), this, m_ConnectBoneName, value)) m_ConnectBoneName = value; } } // 0x78 (120)
		
		protected List<int> m_JointOutputPropertyIds = new List<int>();
		[ContainerField(Name: "JointOutputPropertyIds", Offset: 124, NameHash: 2683361333, Flags: 65)]
		public List<int> JointOutputPropertyIds { get { return m_JointOutputPropertyIds; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(JointOutputPropertyIds), this, m_JointOutputPropertyIds, value)) m_JointOutputPropertyIds = value; } } // 0x7C (124)
		
		protected string m_TrajectoryBoneName = string.Empty;
		[ContainerField(Name: "TrajectoryBoneName", Offset: 128, NameHash: 4054639135, Flags: 16509), LayoutImmutable]
		public string TrajectoryBoneName { get { return m_TrajectoryBoneName; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(TrajectoryBoneName), this, m_TrajectoryBoneName, value)) m_TrajectoryBoneName = value; } } // 0x80 (128)
		
		protected bool m_AnimationEntitySpaceActive = new bool();
		[ContainerField(Name: "AnimationEntitySpaceActive", Offset: 132, NameHash: 3057023040, Flags: 49325), LayoutImmutable, Blittable]
		public bool AnimationEntitySpaceActive { get { return m_AnimationEntitySpaceActive; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(AnimationEntitySpaceActive), this, m_AnimationEntitySpaceActive, value)) m_AnimationEntitySpaceActive = value; } } // 0x84 (132)
		
		protected bool m_PlayFirstFrame = new bool();
		[ContainerField(Name: "PlayFirstFrame", Offset: 133, NameHash: 2522640870, Flags: 49325), LayoutImmutable, Blittable]
		public bool PlayFirstFrame { get { return m_PlayFirstFrame; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(PlayFirstFrame), this, m_PlayFirstFrame, value)) m_PlayFirstFrame = value; } } // 0x85 (133)
		
		protected bool m_Looping = new bool();
		[ContainerField(Name: "Looping", Offset: 134, NameHash: 1366646169, Flags: 49325), LayoutImmutable, Blittable]
		public bool Looping { get { return m_Looping; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(Looping), this, m_Looping, value)) m_Looping = value; } } // 0x86 (134)
		
		protected bool m_EnableJointWorldTransformOutput = new bool();
		[ContainerField(Name: "EnableJointWorldTransformOutput", Offset: 135, NameHash: 3310194691, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableJointWorldTransformOutput { get { return m_EnableJointWorldTransformOutput; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(EnableJointWorldTransformOutput), this, m_EnableJointWorldTransformOutput, value)) m_EnableJointWorldTransformOutput = value; } } // 0x87 (135)
		
		protected bool m_ResetAfterStop = new bool();
		[ContainerField(Name: "ResetAfterStop", Offset: 136, NameHash: 3668699372, Flags: 49325), LayoutImmutable, Blittable]
		public bool ResetAfterStop { get { return m_ResetAfterStop; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(ResetAfterStop), this, m_ResetAfterStop, value)) m_ResetAfterStop = value; } } // 0x88 (136)
		
		protected bool m_AutoStart = new bool();
		[ContainerField(Name: "AutoStart", Offset: 137, NameHash: 792615882, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoStart { get { return m_AutoStart; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(AutoStart), this, m_AutoStart, value)) m_AutoStart = value; } } // 0x89 (137)
		
		protected bool m_ShowDebugTransforms = new bool();
		[ContainerField(Name: "ShowDebugTransforms", Offset: 138, NameHash: 431328136, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowDebugTransforms { get { return m_ShowDebugTransforms; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(ShowDebugTransforms), this, m_ShowDebugTransforms, value)) m_ShowDebugTransforms = value; } } // 0x8A (138)
		
		protected bool m_ApplyRotationCompensation = new bool();
		[ContainerField(Name: "ApplyRotationCompensation", Offset: 139, NameHash: 3033753969, Flags: 49325), LayoutImmutable, Blittable]
		public bool ApplyRotationCompensation { get { return m_ApplyRotationCompensation; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(ApplyRotationCompensation), this, m_ApplyRotationCompensation, value)) m_ApplyRotationCompensation = value; } } // 0x8B (139)
		
		protected bool m_ApplyPreTransformation = new bool();
		[ContainerField(Name: "ApplyPreTransformation", Offset: 140, NameHash: 3130194119, Flags: 49325), LayoutImmutable, Blittable]
		public bool ApplyPreTransformation { get { return m_ApplyPreTransformation; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(ApplyPreTransformation), this, m_ApplyPreTransformation, value)) m_ApplyPreTransformation = value; } } // 0x8C (140)
		
		protected bool m_DisableCulling = new bool();
		[ContainerField(Name: "DisableCulling", Offset: 141, NameHash: 900615207, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisableCulling { get { return m_DisableCulling; } set { if (OnPropertyChanging("ModelAnimationEntityData." + nameof(DisableCulling), this, m_DisableCulling, value)) m_DisableCulling = value; } } // 0x8D (141)
		
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
