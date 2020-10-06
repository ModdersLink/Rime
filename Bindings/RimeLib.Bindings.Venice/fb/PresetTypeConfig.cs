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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(24), ContainerStruct]
	public class PresetTypeConfig : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int PresetId { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string Key { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509)]
		public string NameSid { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16509)]
		public string DescSid { get; set; } // 0xC (12)
		
		[ContainerField(16), MemberInfoFlag(65), ContainerArray]
		public List<LockedSettingConfig> LockedSettings { get; set; } = new List<LockedSettingConfig>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool Predefined { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2625045485:
					PresetId = (int) p_Value;
					break;

				case 193457490:
					Key = (string) p_Value;
					break;

				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 4021143274:
					DescSid = (string) p_Value;
					break;

				case 3735643818:
					LockedSettings = (List<LockedSettingConfig>) p_Value;
					break;

				case 2934266467:
					Predefined = (bool) p_Value;
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
				case 2625045485:
					return PresetId;

				case 193457490:
					return Key;

				case 3153745340:
					return NameSid;

				case 4021143274:
					return DescSid;

				case 3735643818:
					return LockedSettings;

				case 2934266467:
					return Predefined;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2625045485:
					return typeof(PresetTypeConfig).GetProperty(nameof(PresetId));

				case 193457490:
					return typeof(PresetTypeConfig).GetProperty(nameof(Key));

				case 3153745340:
					return typeof(PresetTypeConfig).GetProperty(nameof(NameSid));

				case 4021143274:
					return typeof(PresetTypeConfig).GetProperty(nameof(DescSid));

				case 3735643818:
					return typeof(PresetTypeConfig).GetProperty(nameof(LockedSettings));

				case 2934266467:
					return typeof(PresetTypeConfig).GetProperty(nameof(Predefined));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
