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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class CriteriaAward : FrostbiteContainer
	{
		[ContainerField(Name: "Award", Offset: 0, NameHash: 205847108, Flags: 53)]
		public CtrRef<AwardData> Award { get; set; } = new CtrRef<AwardData>(); // 0x0 (0)
		
		[ContainerField(Name: "Count", Offset: 4, NameHash: 212413894, Flags: 49421), LayoutImmutable, Blittable]
		public uint Count { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Sid", Offset: 8, NameHash: 193466587, Flags: 16509), LayoutImmutable]
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
