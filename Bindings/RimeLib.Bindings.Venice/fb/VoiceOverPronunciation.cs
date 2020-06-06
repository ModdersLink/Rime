///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VoiceOverPronunciation : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<AudioLanguage> PrimaryLanguage { get; set; } = new CtrRef<AudioLanguage>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<AudioLanguage> SecondaryLanguage { get; set; } = new CtrRef<AudioLanguage>(); // 0x10 (16)
		
		[ContainerField(20)]
		public VoiceOverPronunciationFallback SecondaryFallback { get; set; } = new VoiceOverPronunciationFallback(); // 0x14 (20)
		
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
