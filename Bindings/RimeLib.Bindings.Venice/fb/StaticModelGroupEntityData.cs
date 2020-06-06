///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class StaticModelGroupEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public List<StaticModelGroupMemberData> MemberDatas { get; set; } = new List<StaticModelGroupMemberData>(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public GUID HackToSolveRealTimeTweakingIssue { get; set; } // 0x74 (116)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public uint NetworkIdCount { get; set; } // 0x84 (132)
		
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
