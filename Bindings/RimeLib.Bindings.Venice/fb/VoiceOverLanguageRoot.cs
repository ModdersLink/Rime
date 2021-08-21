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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class VoiceOverLanguageRoot : 
		DataContainer
	{
		protected CtrRef<AudioLanguage> m_Language = new CtrRef<AudioLanguage>();
		[ContainerField(Name: "Language", Offset: 8, NameHash: 3872303031, Flags: 53)]
		public CtrRef<AudioLanguage> Language { get { return m_Language; } set { if (OnPropertyChanging("VoiceOverLanguageRoot." + nameof(Language), this, m_Language, value)) m_Language = value; } } // 0x8 (8)
		
		protected string m_Path = string.Empty;
		[ContainerField(Name: "Path", Offset: 12, NameHash: 2089448296, Flags: 16509), LayoutImmutable]
		public string Path { get { return m_Path; } set { if (OnPropertyChanging("VoiceOverLanguageRoot." + nameof(Path), this, m_Path, value)) m_Path = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3872303031:
					Language = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 2089448296:
					Path = (string) p_Value;
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
				case 3872303031:
					return Language;

				case 2089448296:
					return Path;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3872303031:
					return typeof(VoiceOverLanguageRoot).GetProperty(nameof(Language));

				case 2089448296:
					return typeof(VoiceOverLanguageRoot).GetProperty(nameof(Path));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
