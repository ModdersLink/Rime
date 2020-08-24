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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class AudioLanguageSetting : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("AudioLanguageSetting." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected uint m_NameHash = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(994057744)]
		public uint NameHash { get { return m_NameHash; } set { if (OnPropertyChanging("AudioLanguageSetting." + nameof(NameHash), this, m_NameHash, value)) m_NameHash = value; } } // 0xC (12)
		
		protected string m_DisplayName = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1925224568)]
		public string DisplayName { get { return m_DisplayName; } set { if (OnPropertyChanging("AudioLanguageSetting." + nameof(DisplayName), this, m_DisplayName, value)) m_DisplayName = value; } } // 0x10 (16)
		
		protected List<AudioLanguageMapping> m_Mappings = new List<AudioLanguageMapping>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(673881690), ContainerArray]
		public List<AudioLanguageMapping> Mappings { get { return m_Mappings; } set { if (OnPropertyChanging("AudioLanguageSetting." + nameof(Mappings), this, m_Mappings, value)) m_Mappings = value; } } // 0x14 (20)
		
		protected bool m_IsDefault = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2802724276)]
		public bool IsDefault { get { return m_IsDefault; } set { if (OnPropertyChanging("AudioLanguageSetting." + nameof(IsDefault), this, m_IsDefault, value)) m_IsDefault = value; } } // 0x18 (24)
		
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
