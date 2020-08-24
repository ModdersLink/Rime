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
	public class UILevelSpecificPageHeader : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string LevelNameSID { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string Header { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509)]
		public string SubHeader { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3852928010:
					LevelNameSID = (string) p_Value;
					break;

				case 3054345338:
					Header = (string) p_Value;
					break;

				case 1300890558:
					SubHeader = (string) p_Value;
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
				case 3852928010:
					return LevelNameSID;

				case 3054345338:
					return Header;

				case 1300890558:
					return SubHeader;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3852928010:
					return typeof(UILevelSpecificPageHeader).GetProperty(nameof(LevelNameSID));

				case 3054345338:
					return typeof(UILevelSpecificPageHeader).GetProperty(nameof(Header));

				case 1300890558:
					return typeof(UILevelSpecificPageHeader).GetProperty(nameof(SubHeader));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
