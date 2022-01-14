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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 144)]
	public class ModelAnimationEntityData :
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public LinearTransform AnimationEntitySpace { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public GameplayBones BoneToPlace { get; set; } = new();

		[ContainerField(84), JsonProperty(Order = 84)]
		public Realm Realm { get; set; } = new();

		[ContainerField(88), JsonProperty(Order = 88)]
		public ModelAnimationTransformType ModelAnimationTransformType { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public int InstanceSeed { get; set; }

		[ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		public string DefaultAnimation { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public int AnimationIndex { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<AntAnimationSetAsset> AnimationSet { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float ExternalTime { get; set; }

		[ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		public string RootMeshBoneName { get; set; } = string.Empty;

		[ContainerField(116), JsonProperty(Order = 116)]
		public ModelAnimationUpdateOrder JointWorldTransformUpdateOrder { get; set; } = new();

		[ContainerField(120), LayoutImmutable, JsonProperty(Order = 120)]
		public string ConnectBoneName { get; set; } = string.Empty;

		[ContainerField(124), JsonProperty(Order = 124)]
		public List<int> JointOutputPropertyIds { get; set; } = new();

		[ContainerField(128), LayoutImmutable, JsonProperty(Order = 128)]
		public string TrajectoryBoneName { get; set; } = string.Empty;

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public bool AnimationEntitySpaceActive { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		public bool PlayFirstFrame { get; set; }

		[ContainerField(134), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
		public bool Looping { get; set; }

		[ContainerField(135), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
		public bool EnableJointWorldTransformOutput { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public bool ResetAfterStop { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		public bool AutoStart { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		public bool ShowDebugTransforms { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
		public bool ApplyRotationCompensation { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public bool ApplyPreTransformation { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		public bool DisableCulling { get; set; }

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
