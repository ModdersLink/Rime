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
	public class VoiceOverPronunciation : 
		DataContainer
	{
		protected string m_Name = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("VoiceOverPronunciation." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected CtrRef<AudioLanguage> m_PrimaryLanguage = new CtrRef<AudioLanguage>();
		[ContainerField(12), ContainerFieldNameHash(2775606523)]
		public CtrRef<AudioLanguage> PrimaryLanguage { get { return m_PrimaryLanguage; } set { if (OnPropertyChanging("VoiceOverPronunciation." + nameof(PrimaryLanguage), this, m_PrimaryLanguage, value)) m_PrimaryLanguage = value; } } // 0xC (12)
		
		protected CtrRef<AudioLanguage> m_SecondaryLanguage = new CtrRef<AudioLanguage>();
		[ContainerField(16), ContainerFieldNameHash(1020526989)]
		public CtrRef<AudioLanguage> SecondaryLanguage { get { return m_SecondaryLanguage; } set { if (OnPropertyChanging("VoiceOverPronunciation." + nameof(SecondaryLanguage), this, m_SecondaryLanguage, value)) m_SecondaryLanguage = value; } } // 0x10 (16)
		
		protected VoiceOverPronunciationFallback m_SecondaryFallback = new VoiceOverPronunciationFallback();
		[ContainerField(20), ContainerFieldNameHash(694512435)]
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
