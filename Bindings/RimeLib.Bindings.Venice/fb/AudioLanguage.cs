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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class AudioLanguage : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("AudioLanguage." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected LanguageFormat m_LanguageMapping = new LanguageFormat();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(1284921467)]
		public LanguageFormat LanguageMapping { get { return m_LanguageMapping; } set { if (OnPropertyChanging("AudioLanguage." + nameof(LanguageMapping), this, m_LanguageMapping, value)) m_LanguageMapping = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1284921467:
					LanguageMapping = (LanguageFormat) Enum.ToObject(typeof(LanguageFormat), p_Value);
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

				case 1284921467:
					return LanguageMapping;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(AudioLanguage).GetProperty(nameof(Name));

				case 1284921467:
					return typeof(AudioLanguage).GetProperty(nameof(LanguageMapping));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
