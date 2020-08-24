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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class EntitlementData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string License { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string EntitlementTag { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509)]
		public string GroupName { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16509)]
		public string ProductId { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509)]
		public string ProjectId { get; set; } // 0x10 (16)
		
		[ContainerField(20), MemberInfoFlag(137)]
		public EntitlementType UsageType { get; set; } = new EntitlementType(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool VerifyOwnership { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 979513438:
					License = (string) p_Value;
					break;

				case 1654763342:
					EntitlementTag = (string) p_Value;
					break;

				case 3178263901:
					GroupName = (string) p_Value;
					break;

				case 106414083:
					ProductId = (string) p_Value;
					break;

				case 4152360413:
					ProjectId = (string) p_Value;
					break;

				case 161626008:
						UsageType = (EntitlementType) Enum.ToObject(typeof(EntitlementType), p_Value);
					break;

				case 4151436721:
					VerifyOwnership = (bool) p_Value;
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
				case 979513438:
					return License;

				case 1654763342:
					return EntitlementTag;

				case 3178263901:
					return GroupName;

				case 106414083:
					return ProductId;

				case 4152360413:
					return ProjectId;

				case 161626008:
					return UsageType;

				case 4151436721:
					return VerifyOwnership;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 979513438:
					return typeof(EntitlementData).GetProperty(nameof(License));

				case 1654763342:
					return typeof(EntitlementData).GetProperty(nameof(EntitlementTag));

				case 3178263901:
					return typeof(EntitlementData).GetProperty(nameof(GroupName));

				case 106414083:
					return typeof(EntitlementData).GetProperty(nameof(ProductId));

				case 4152360413:
					return typeof(EntitlementData).GetProperty(nameof(ProjectId));

				case 161626008:
					return typeof(EntitlementData).GetProperty(nameof(UsageType));

				case 4151436721:
					return typeof(EntitlementData).GetProperty(nameof(VerifyOwnership));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
