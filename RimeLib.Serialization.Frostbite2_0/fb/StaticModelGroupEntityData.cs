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
	public class StaticModelGroupEntityData :
		GamePhysicsEntityData
	{
		[ContainerField(112), JsonProperty(Order = 112)]
		public List<StaticModelGroupMemberData> MemberDatas { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public GUID HackToSolveRealTimeTweakingIssue { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public uint NetworkIdCount { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_MemberDatas = p_EbxWriter.GetArrayWriter(MemberDatas.GetType(), MemberDatas.Count);
			p_Writer.Write(s_MemberDatas.ArrayIndex);
			foreach (var s_Entry in MemberDatas)
			{
				s_Entry.Serialize(s_MemberDatas.Writer, p_EbxWriter);
			}
			HackToSolveRealTimeTweakingIssue.Serialize(p_Writer);
			p_Writer.Write(NetworkIdCount);
			p_Writer.WriteNullBytes(8);
		}
	}
}
