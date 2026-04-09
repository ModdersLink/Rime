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
	[ContainerType(16, 144)]
	public partial class ModelAnimationEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private LinearTransform _AnimationEntitySpace = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private GameplayBones _BoneToPlace = new();

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private ModelAnimationTransformType _ModelAnimationTransformType = new();

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private int _InstanceSeed;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		private string _DefaultAnimation = string.Empty;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private int _AnimationIndex;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private CtrRef<AntAnimationSetAsset> _AnimationSet = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _ExternalTime;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		private string _RootMeshBoneName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private ModelAnimationUpdateOrder _JointWorldTransformUpdateOrder = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, JsonProperty(Order = 120)]
		private string _ConnectBoneName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private List<int> _JointOutputPropertyIds = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, JsonProperty(Order = 128)]
		private string _TrajectoryBoneName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private bool _AnimationEntitySpaceActive;

		[ObservableProperty]
		[property: ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		private bool _PlayFirstFrame;

		[ObservableProperty]
		[property: ContainerField(134), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
		private bool _Looping;

		[ObservableProperty]
		[property: ContainerField(135), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
		private bool _EnableJointWorldTransformOutput;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private bool _ResetAfterStop;

		[ObservableProperty]
		[property: ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		private bool _AutoStart;

		[ObservableProperty]
		[property: ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		private bool _ShowDebugTransforms;

		[ObservableProperty]
		[property: ContainerField(139), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
		private bool _ApplyRotationCompensation;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private bool _ApplyPreTransformation;

		[ObservableProperty]
		[property: ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		private bool _DisableCulling;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			AnimationEntitySpace.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) BoneToPlace);
			p_Writer.Write((int) Realm);
			p_Writer.Write((int) ModelAnimationTransformType);
			p_Writer.Write(InstanceSeed);
			p_Writer.Write(p_EbxWriter.WriteString(DefaultAnimation));
			p_Writer.Write(AnimationIndex);
			p_Writer.Write(p_EbxWriter.WriteImport(AnimationSet));
			p_Writer.Write(ExternalTime);
			p_Writer.Write(p_EbxWriter.WriteString(RootMeshBoneName));
			p_Writer.Write((int) JointWorldTransformUpdateOrder);
			p_Writer.Write(p_EbxWriter.WriteString(ConnectBoneName));
			(RimeWriter Writer, uint ArrayIndex) s_JointOutputPropertyIds = p_EbxWriter.GetArrayWriter(JointOutputPropertyIds.GetType(), JointOutputPropertyIds.Count);
			p_Writer.Write(s_JointOutputPropertyIds.ArrayIndex);
			foreach (var s_Entry in JointOutputPropertyIds)
			{
				s_JointOutputPropertyIds.Writer.Write(s_Entry);
			}
			p_Writer.Write(p_EbxWriter.WriteString(TrajectoryBoneName));
			p_Writer.Write(AnimationEntitySpaceActive);
			p_Writer.Write(PlayFirstFrame);
			p_Writer.Write(Looping);
			p_Writer.Write(EnableJointWorldTransformOutput);
			p_Writer.Write(ResetAfterStop);
			p_Writer.Write(AutoStart);
			p_Writer.Write(ShowDebugTransforms);
			p_Writer.Write(ApplyRotationCompensation);
			p_Writer.Write(ApplyPreTransformation);
			p_Writer.Write(DisableCulling);
			p_Writer.WriteNullBytes(2);
		}
	}
}
