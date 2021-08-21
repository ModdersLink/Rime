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
	public class Ps3SkuSettings : FrostbiteContainer
	{
		[ContainerField(Name: "TitleId", Offset: 0, NameHash: 3335995016, Flags: 16509), LayoutImmutable]
		public string TitleId { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "SpId", Offset: 4, NameHash: 2089404363, Flags: 16509), LayoutImmutable]
		public string SpId { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "GrantsOnlinePass", Offset: 8, NameHash: 2999853990, Flags: 49325), LayoutImmutable, Blittable]
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
