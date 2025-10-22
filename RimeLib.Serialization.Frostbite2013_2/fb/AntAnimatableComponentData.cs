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

[ContainerType(16, 384)]
public class AntAnimatableComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_ClientAndServer;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public SubRealm SubRealm { get; set; } = fb.Entity.SubRealm.SubRealm_All;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AntAnimationHandlerData AnimationData { get; set; } = new();
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public List<AntAnimatableComponentMeshData> MeshDatas { get; set; } = new();
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public JointOutputModeEnum JointOutputMode { get; set; } = JointOutputModeEnum.JointOutputModeEnum_GameplayBones;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public bool AutoActivate { get; set; } = false;
	
	[ContainerField(0x175), LayoutImmutable, Blittable, JsonProperty(Order = 373)]
	public bool AnimationControlledFromStart { get; set; } = false;
	
	[ContainerField(0x176), LayoutImmutable, Blittable, JsonProperty(Order = 374)]
	public bool ForceDisableCulling { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write((int) SubRealm);
		AnimationData.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_MeshDatas = p_EbxWriter.GetArrayWriter(MeshDatas.GetType(), MeshDatas.Count);
		p_Writer.Write(s_MeshDatas.ArrayIndex);
		foreach (var s_Entry in MeshDatas)
		{
			s_Entry.Serialize(s_MeshDatas.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) JointOutputMode);
		p_Writer.Write(AutoActivate);
		p_Writer.Write(AnimationControlledFromStart);
		p_Writer.Write(ForceDisableCulling);
		p_Writer.WriteNullBytes(9);
	}
}

