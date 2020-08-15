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
	public class SettingConfig : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string Key { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable]
		public string NameSid { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable]
		public string DescSid { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint Max { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint Default { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint Min { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool Ranked { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193457490:
					Key = (string) p_Value;
					break;

				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 4021143274:
					DescSid = (string) p_Value;
					break;

				case 193446865:
					Max = (uint) p_Value;
					break;

				case 3998752238:
					Default = (uint) p_Value;
					break;

				case 193446607:
					Min = (uint) p_Value;
					break;

				case 3298743058:
					Ranked = (bool) p_Value;
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

				case 3153745340:
					return NameSid;

				case 4021143274:
					return DescSid;

				case 193446865:
					return Max;

				case 3998752238:
					return Default;

				case 193446607:
					return Min;

				case 3298743058:
					return Ranked;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193457490:
					return typeof(SettingConfig).GetProperty(nameof(Key));

				case 3153745340:
					return typeof(SettingConfig).GetProperty(nameof(NameSid));

				case 4021143274:
					return typeof(SettingConfig).GetProperty(nameof(DescSid));

				case 193446865:
					return typeof(SettingConfig).GetProperty(nameof(Max));

				case 3998752238:
					return typeof(SettingConfig).GetProperty(nameof(Default));

				case 193446607:
					return typeof(SettingConfig).GetProperty(nameof(Min));

				case 3298743058:
					return typeof(SettingConfig).GetProperty(nameof(Ranked));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
