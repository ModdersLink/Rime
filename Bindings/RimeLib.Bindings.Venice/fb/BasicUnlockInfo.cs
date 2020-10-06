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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(36), ContainerStruct]
	public class BasicUnlockInfo : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49501)]
		public GUID UnlockGuid { get; set; } // 0x0 (0)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint Identifier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint UnlockScore { get; set; } // 0x14 (20)
		
		[ContainerField(24), MemberInfoFlag(65), ContainerArray]
		public List<string> Licenses { get; set; } = new List<string>(); // 0x18 (24)
		
		[ContainerField(28), MemberInfoFlag(65), ContainerArray]
		public List<string> AdditionalLicenses { get; set; } = new List<string>(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, MemberInfoFlag(16509)]
		public string StringId { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1036441738:
					UnlockGuid = (GUID) p_Value;
					break;

				case 3512790342:
					Identifier = (uint) p_Value;
					break;

				case 4124076605:
					UnlockScore = (uint) p_Value;
					break;

				case 2259172461:
					Licenses = (List<string>) p_Value;
					break;

				case 2557362420:
					AdditionalLicenses = (List<string>) p_Value;
					break;

				case 3536090717:
					StringId = (string) p_Value;
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
				case 1036441738:
					return UnlockGuid;

				case 3512790342:
					return Identifier;

				case 4124076605:
					return UnlockScore;

				case 2259172461:
					return Licenses;

				case 2557362420:
					return AdditionalLicenses;

				case 3536090717:
					return StringId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1036441738:
					return typeof(BasicUnlockInfo).GetProperty(nameof(UnlockGuid));

				case 3512790342:
					return typeof(BasicUnlockInfo).GetProperty(nameof(Identifier));

				case 4124076605:
					return typeof(BasicUnlockInfo).GetProperty(nameof(UnlockScore));

				case 2259172461:
					return typeof(BasicUnlockInfo).GetProperty(nameof(Licenses));

				case 2557362420:
					return typeof(BasicUnlockInfo).GetProperty(nameof(AdditionalLicenses));

				case 3536090717:
					return typeof(BasicUnlockInfo).GetProperty(nameof(StringId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
