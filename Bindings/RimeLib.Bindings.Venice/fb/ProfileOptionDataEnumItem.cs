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
	[ContainerType(4)]
	public class ProfileOptionDataEnumItem : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string DisplayName { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public bool Default { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1925224568:
					DisplayName = (string) p_Value;
					break;

				case 3998752238:
					Default = (bool) p_Value;
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
				case 1925224568:
					return DisplayName;

				case 3998752238:
					return Default;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1925224568:
					return typeof(ProfileOptionDataEnumItem).GetProperty(nameof(DisplayName));

				case 3998752238:
					return typeof(ProfileOptionDataEnumItem).GetProperty(nameof(Default));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
