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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class AdvertisementZoneMember : FrostbiteContainer
	{
		[ContainerField(Name: "Identifier", Offset: 0, NameHash: 3512790342, Flags: 16509), LayoutImmutable]
		public string Identifier { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Filename", Offset: 4, NameHash: 1135826884, Flags: 16509), LayoutImmutable]
		public string Filename { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3512790342:
					Identifier = (string) p_Value;
					break;

				case 1135826884:
					Filename = (string) p_Value;
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
				case 3512790342:
					return Identifier;

				case 1135826884:
					return Filename;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3512790342:
					return typeof(AdvertisementZoneMember).GetProperty(nameof(Identifier));

				case 1135826884:
					return typeof(AdvertisementZoneMember).GetProperty(nameof(Filename));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
