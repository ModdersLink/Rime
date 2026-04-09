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
	public partial class StaticModelGroupEntityData :
		GamePhysicsEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private List<StaticModelGroupMemberData> _MemberDatas = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private GUID _HackToSolveRealTimeTweakingIssue = GUID.Empty;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private uint _NetworkIdCount;

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
