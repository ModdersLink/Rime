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
	public class ServerInfoSetting : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string Key { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable]
		public string Name { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool IsBool { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193457490:
					Key = (string) p_Value;
					break;

				case 2088949890:
					Name = (string) p_Value;
					break;

				case 2816931793:
					IsBool = (bool) p_Value;
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
				case 193457490:
					return Key;

				case 2088949890:
					return Name;

				case 2816931793:
					return IsBool;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193457490:
					return typeof(ServerInfoSetting).GetProperty(nameof(Key));

				case 2088949890:
					return typeof(ServerInfoSetting).GetProperty(nameof(Name));

				case 2816931793:
					return typeof(ServerInfoSetting).GetProperty(nameof(IsBool));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
