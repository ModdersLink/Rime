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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class VoiceOverPronunciation : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 8, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("VoiceOverPronunciation." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected CtrRef<AudioLanguage> m_PrimaryLanguage = new CtrRef<AudioLanguage>();
		[ContainerField(Name: "PrimaryLanguage", Offset: 12, NameHash: 2775606523, Flags: 53)]
		public CtrRef<AudioLanguage> PrimaryLanguage { get { return m_PrimaryLanguage; } set { if (OnPropertyChanging("VoiceOverPronunciation." + nameof(PrimaryLanguage), this, m_PrimaryLanguage, value)) m_PrimaryLanguage = value; } } // 0xC (12)
		
		protected CtrRef<AudioLanguage> m_SecondaryLanguage = new CtrRef<AudioLanguage>();
		[ContainerField(Name: "SecondaryLanguage", Offset: 16, NameHash: 1020526989, Flags: 53)]
		public CtrRef<AudioLanguage> SecondaryLanguage { get { return m_SecondaryLanguage; } set { if (OnPropertyChanging("VoiceOverPronunciation." + nameof(SecondaryLanguage), this, m_SecondaryLanguage, value)) m_SecondaryLanguage = value; } } // 0x10 (16)
		
		protected VoiceOverPronunciationFallback m_SecondaryFallback = new VoiceOverPronunciationFallback();
		[ContainerField(Name: "SecondaryFallback", Offset: 20, NameHash: 694512435, Flags: 137)]
		public VoiceOverPronunciationFallback SecondaryFallback { get { return m_SecondaryFallback; } set { if (OnPropertyChanging("VoiceOverPronunciation." + nameof(SecondaryFallback), this, m_SecondaryFallback, value)) m_SecondaryFallback = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 2775606523:
					PrimaryLanguage = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 1020526989:
					SecondaryLanguage = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 694512435:
					SecondaryFallback = (VoiceOverPronunciationFallback) Enum.ToObject(typeof(VoiceOverPronunciationFallback), p_Value);
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

				case 2775606523:
					return PrimaryLanguage;

				case 1020526989:
					return SecondaryLanguage;

				case 694512435:
					return SecondaryFallback;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(VoiceOverPronunciation).GetProperty(nameof(Name));

				case 2775606523:
					return typeof(VoiceOverPronunciation).GetProperty(nameof(PrimaryLanguage));

				case 1020526989:
					return typeof(VoiceOverPronunciation).GetProperty(nameof(SecondaryLanguage));

				case 694512435:
					return typeof(VoiceOverPronunciation).GetProperty(nameof(SecondaryFallback));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
