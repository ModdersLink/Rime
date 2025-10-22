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
using fb.Physics;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 176)]
public class StaticModelGroupEntityData
	: fb.Physics.GamePhysicsEntityData
{
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public List<StaticModelGroupMemberData> MemberDatas { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public uint NetworkIdCount { get; set; } = 0;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public GUID HackToSolveRealTimeTweakingIssue { get; set; } = GUID.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_MemberDatas = p_EbxWriter.GetArrayWriter(MemberDatas.GetType(), MemberDatas.Count);
		p_Writer.Write(s_MemberDatas.ArrayIndex);
		foreach (var s_Entry in MemberDatas)
		{
			s_Entry.Serialize(s_MemberDatas.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(NetworkIdCount);
		HackToSolveRealTimeTweakingIssue.Serialize(p_Writer);
		p_Writer.WriteNullBytes(4);
	}
}

