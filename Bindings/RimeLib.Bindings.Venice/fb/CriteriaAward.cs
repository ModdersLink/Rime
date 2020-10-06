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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(12), ContainerStruct]
	public class CriteriaAward : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<AwardData> Award { get; set; } = new CtrRef<AwardData>(); // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint Count { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509)]
		public string Sid { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 205847108:
					Award = (CtrRef<AwardData>) p_Value;
					break;

				case 212413894:
					Count = (uint) p_Value;
					break;

				case 193466587:
					Sid = (string) p_Value;
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
				case 205847108:
					return Award;

				case 212413894:
					return Count;

				case 193466587:
					return Sid;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 205847108:
					return typeof(CriteriaAward).GetProperty(nameof(Award));

				case 212413894:
					return typeof(CriteriaAward).GetProperty(nameof(Count));

				case 193466587:
					return typeof(CriteriaAward).GetProperty(nameof(Sid));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
