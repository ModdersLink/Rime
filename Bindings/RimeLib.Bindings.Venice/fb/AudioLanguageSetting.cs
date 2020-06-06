///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AudioLanguageSetting : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint NameHash { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string DisplayName { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public List<AudioLanguageMapping> Mappings { get; set; } = new List<AudioLanguageMapping>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool IsDefault { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 994057744:
					NameHash = (uint) p_Value;
					break;

				case 1925224568:
					DisplayName = (string) p_Value;
					break;

				case 673881690:
					Mappings = (List<AudioLanguageMapping>) p_Value;
					break;

				case 2802724276:
					IsDefault = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 994057744:
					return NameHash;

				case 1925224568:
					return DisplayName;

				case 673881690:
					return Mappings;

				case 2802724276:
					return IsDefault;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(AudioLanguageSetting).GetProperty(nameof(Name));

				case 994057744:
					return typeof(AudioLanguageSetting).GetProperty(nameof(NameHash));

				case 1925224568:
					return typeof(AudioLanguageSetting).GetProperty(nameof(DisplayName));

				case 673881690:
					return typeof(AudioLanguageSetting).GetProperty(nameof(Mappings));

				case 2802724276:
					return typeof(AudioLanguageSetting).GetProperty(nameof(IsDefault));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
