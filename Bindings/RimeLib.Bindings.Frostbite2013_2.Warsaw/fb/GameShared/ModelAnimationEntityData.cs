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

using fb.Entity;
using fb.Core;
using fb.Ant;

namespace fb.GameShared;

[ContainerType(16, 160)]
public class ModelAnimationEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public LinearTransform AnimationEntitySpace { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string DefaultAnimation { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public int AnimationIndex { get; set; } = 0;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<AntAnimationSetAsset> AnimationSet { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float ExternalTime { get; set; } = -1.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float PlaybackSpeed { get; set; } = -1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public int InstanceSeed { get; set; } = 0;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public GameplayBones BoneToPlace { get; set; } = GameplayBones.GameplayBones_RootBone;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public ModelAnimationTransformType ModelAnimationTransformType { get; set; } = fb.GameShared.ModelAnimationTransformType.ModelAnimationTransformType_World;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public ModelAnimationUpdateOrder JointWorldTransformUpdateOrder { get; set; } = ModelAnimationUpdateOrder.ModelAnimationUpdateOrder_PostAnimation;
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public List<int> JointOutputFieldHashes { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool AutoStart { get; set; } = false;
	
	[ContainerField(0x99), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
	public bool Looping { get; set; } = false;
	
	[ContainerField(0x9a), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
	public bool ResetAfterStop { get; set; } = true;
	
	[ContainerField(0x9b), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
	public bool PlayFirstFrame { get; set; } = false;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public bool AnimationEntitySpaceActive { get; set; } = false;
	
	[ContainerField(0x9d), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
	public bool DisableCulling { get; set; } = false;
	
	[ContainerField(0x9e), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
	public bool EnableJointWorldTransformOutput { get; set; } = false;
	
	[ContainerField(0x9f), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
	public bool ShowDebugTransforms { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		AnimationEntitySpace.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(DefaultAnimation));
		p_Writer.Write(AnimationIndex);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AnimationSet));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ExternalTime);
		p_Writer.Write(PlaybackSpeed);
		p_Writer.Write(InstanceSeed);
		p_Writer.Write((int) BoneToPlace);
		p_Writer.Write((int) ModelAnimationTransformType);
		p_Writer.Write((int) JointWorldTransformUpdateOrder);
		(RimeWriter Writer, uint ArrayIndex) s_JointOutputFieldHashes = p_EbxWriter.GetArrayWriter(JointOutputFieldHashes.GetType(), JointOutputFieldHashes.Count);
		p_Writer.Write(s_JointOutputFieldHashes.ArrayIndex);
		foreach (var s_Entry in JointOutputFieldHashes)
		{
			s_JointOutputFieldHashes.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AutoStart);
		p_Writer.Write(Looping);
		p_Writer.Write(ResetAfterStop);
		p_Writer.Write(PlayFirstFrame);
		p_Writer.Write(AnimationEntitySpaceActive);
		p_Writer.Write(DisableCulling);
		p_Writer.Write(EnableJointWorldTransformOutput);
		p_Writer.Write(ShowDebugTransforms);
	}
}

