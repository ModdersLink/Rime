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
	public class Ps3SkuSettings : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string TitleId { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string SpId { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool GrantsOnlinePass { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3335995016:
					TitleId = (string) p_Value;
					break;

				case 2089404363:
					SpId = (string) p_Value;
					break;

				case 2999853990:
					GrantsOnlinePass = (bool) p_Value;
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
				case 3335995016:
					return TitleId;

				case 2089404363:
					return SpId;

				case 2999853990:
					return GrantsOnlinePass;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3335995016:
					return typeof(Ps3SkuSettings).GetProperty(nameof(TitleId));

				case 2089404363:
					return typeof(Ps3SkuSettings).GetProperty(nameof(SpId));

				case 2999853990:
					return typeof(Ps3SkuSettings).GetProperty(nameof(GrantsOnlinePass));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
