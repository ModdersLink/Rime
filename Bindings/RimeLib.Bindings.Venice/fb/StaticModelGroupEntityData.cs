///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 144)]
	public class StaticModelGroupEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public List<StaticModelGroupMemberData> MemberDatas { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public GUID HackToSolveRealTimeTweakingIssue { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public uint NetworkIdCount { get; set; }

		public static void Deserialize(StaticModelGroupEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MemberDatas.Clear();
			(RimeReader Reader, uint Count) s_MemberDatas = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MemberDatas.Count; ++i)
			{
				var s_Value = new StaticModelGroupMemberData();
				fb.StaticModelGroupMemberData.Deserialize(s_Value, s_MemberDatas.Reader, p_Parser);
				p_Instance.MemberDatas.Add(s_Value);
			}
			
			s_MemberDatas.Reader.Dispose();
			p_Instance.HackToSolveRealTimeTweakingIssue = new GUID(p_Reader);
			p_Instance.NetworkIdCount = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
