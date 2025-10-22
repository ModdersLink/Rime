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

using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 296)]
public class AntAnimatableEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_ClientAndServer;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public SubRealm SubRealm { get; set; } = fb.Entity.SubRealm.SubRealm_All;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AntAnimationHandlerData AnimationData { get; set; } = new();
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public AnimationControlModeEnum InitialAnimationControlMode { get; set; } = AnimationControlModeEnum.AnimationControlModeEnum_DisconnectTrajectoryAndObject;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public JointOutputModeEnum JointOutputMode { get; set; } = JointOutputModeEnum.JointOutputModeEnum_GameplayBones;
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public List<int> JointOutputPropertyIds { get; set; } = new();
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public bool AutoActivate { get; set; } = false;
	
	[ContainerField(0x121), LayoutImmutable, Blittable, JsonProperty(Order = 289)]
	public bool InitialForceDisableCulling { get; set; } = false;
	
	[ContainerField(0x122), LayoutImmutable, Blittable, JsonProperty(Order = 290)]
	public bool DisableAutoDistanceCulling { get; set; } = false;
	
	[ContainerField(0x123), LayoutImmutable, Blittable, JsonProperty(Order = 291)]
	public bool Interpolation { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write((int) SubRealm);
		AnimationData.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) InitialAnimationControlMode);
		p_Writer.Write((int) JointOutputMode);
		(RimeWriter Writer, uint ArrayIndex) s_JointOutputPropertyIds = p_EbxWriter.GetArrayWriter(JointOutputPropertyIds.GetType(), JointOutputPropertyIds.Count);
		p_Writer.Write(s_JointOutputPropertyIds.ArrayIndex);
		foreach (var s_Entry in JointOutputPropertyIds)
		{
			s_JointOutputPropertyIds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AutoActivate);
		p_Writer.Write(InitialForceDisableCulling);
		p_Writer.Write(DisableAutoDistanceCulling);
		p_Writer.Write(Interpolation);
		p_Writer.WriteNullBytes(4);
	}
}

