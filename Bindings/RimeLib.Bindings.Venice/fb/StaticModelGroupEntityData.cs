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
	public class StaticModelGroupEntityData : 
		GamePhysicsEntityData
	{
		protected List<StaticModelGroupMemberData> m_MemberDatas = new List<StaticModelGroupMemberData>();
		[ContainerField(Name: "MemberDatas", Offset: 112, NameHash: 1084657014, Flags: 65)]
		public List<StaticModelGroupMemberData> MemberDatas { get { return m_MemberDatas; } set { if (OnPropertyChanging("StaticModelGroupEntityData." + nameof(MemberDatas), this, m_MemberDatas, value)) m_MemberDatas = value; } } // 0x70 (112)
		
		protected GUID m_HackToSolveRealTimeTweakingIssue = new GUID();
		[ContainerField(Name: "HackToSolveRealTimeTweakingIssue", Offset: 116, NameHash: 1452521702, Flags: 49501), LayoutImmutable, Blittable]
		public GUID HackToSolveRealTimeTweakingIssue { get { return m_HackToSolveRealTimeTweakingIssue; } set { if (OnPropertyChanging("StaticModelGroupEntityData." + nameof(HackToSolveRealTimeTweakingIssue), this, m_HackToSolveRealTimeTweakingIssue, value)) m_HackToSolveRealTimeTweakingIssue = value; } } // 0x74 (116)
		
		protected uint m_NetworkIdCount = new uint();
		[ContainerField(Name: "NetworkIdCount", Offset: 132, NameHash: 1234693717, Flags: 49421), LayoutImmutable, Blittable]
		public uint NetworkIdCount { get { return m_NetworkIdCount; } set { if (OnPropertyChanging("StaticModelGroupEntityData." + nameof(NetworkIdCount), this, m_NetworkIdCount, value)) m_NetworkIdCount = value; } } // 0x84 (132)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1084657014:
					MemberDatas = (List<StaticModelGroupMemberData>) p_Value;
					break;

				case 1452521702:
					HackToSolveRealTimeTweakingIssue = (GUID) p_Value;
					break;

				case 1234693717:
					NetworkIdCount = (uint) p_Value;
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
				case 1084657014:
					return MemberDatas;

				case 1452521702:
					return HackToSolveRealTimeTweakingIssue;

				case 1234693717:
					return NetworkIdCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1084657014:
					return typeof(StaticModelGroupEntityData).GetProperty(nameof(MemberDatas));

				case 1452521702:
					return typeof(StaticModelGroupEntityData).GetProperty(nameof(HackToSolveRealTimeTweakingIssue));

				case 1234693717:
					return typeof(StaticModelGroupEntityData).GetProperty(nameof(NetworkIdCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
