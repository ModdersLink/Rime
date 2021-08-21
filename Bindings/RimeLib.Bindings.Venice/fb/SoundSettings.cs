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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class SoundSettings : 
		SystemSettings
	{
		protected string m_VOEnglish = string.Empty;
		[ContainerField(Name: "VOEnglish", Offset: 12, NameHash: 433771118, Flags: 16509), LayoutImmutable]
		public string VOEnglish { get { return m_VOEnglish; } set { if (OnPropertyChanging("SoundSettings." + nameof(VOEnglish), this, m_VOEnglish, value)) m_VOEnglish = value; } } // 0xC (12)
		
		protected string m_AudioSystemUri = string.Empty;
		[ContainerField(Name: "AudioSystemUri", Offset: 16, NameHash: 2343912184, Flags: 16509), LayoutImmutable]
		public string AudioSystemUri { get { return m_AudioSystemUri; } set { if (OnPropertyChanging("SoundSettings." + nameof(AudioSystemUri), this, m_AudioSystemUri, value)) m_AudioSystemUri = value; } } // 0x10 (16)
		
		protected string m_VOCommon = string.Empty;
		[ContainerField(Name: "VOCommon", Offset: 20, NameHash: 2339452753, Flags: 16509), LayoutImmutable]
		public string VOCommon { get { return m_VOCommon; } set { if (OnPropertyChanging("SoundSettings." + nameof(VOCommon), this, m_VOCommon, value)) m_VOCommon = value; } } // 0x14 (20)
		
		protected string m_VOItalian = string.Empty;
		[ContainerField(Name: "VOItalian", Offset: 24, NameHash: 3307845866, Flags: 16509), LayoutImmutable]
		public string VOItalian { get { return m_VOItalian; } set { if (OnPropertyChanging("SoundSettings." + nameof(VOItalian), this, m_VOItalian, value)) m_VOItalian = value; } } // 0x18 (24)
		
		protected string m_VOSpanish = string.Empty;
		[ContainerField(Name: "VOSpanish", Offset: 28, NameHash: 1980789858, Flags: 16509), LayoutImmutable]
		public string VOSpanish { get { return m_VOSpanish; } set { if (OnPropertyChanging("SoundSettings." + nameof(VOSpanish), this, m_VOSpanish, value)) m_VOSpanish = value; } } // 0x1C (28)
		
		protected string m_VOFrench = string.Empty;
		[ContainerField(Name: "VOFrench", Offset: 32, NameHash: 2213601832, Flags: 16509), LayoutImmutable]
		public string VOFrench { get { return m_VOFrench; } set { if (OnPropertyChanging("SoundSettings." + nameof(VOFrench), this, m_VOFrench, value)) m_VOFrench = value; } } // 0x20 (32)
		
		protected string m_VOGerman = string.Empty;
		[ContainerField(Name: "VOGerman", Offset: 36, NameHash: 2207675566, Flags: 16509), LayoutImmutable]
		public string VOGerman { get { return m_VOGerman; } set { if (OnPropertyChanging("SoundSettings." + nameof(VOGerman), this, m_VOGerman, value)) m_VOGerman = value; } } // 0x24 (36)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 40, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("SoundSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 433771118:
					VOEnglish = (string) p_Value;
					break;

				case 2343912184:
					AudioSystemUri = (string) p_Value;
					break;

				case 2339452753:
					VOCommon = (string) p_Value;
					break;

				case 3307845866:
					VOItalian = (string) p_Value;
					break;

				case 1980789858:
					VOSpanish = (string) p_Value;
					break;

				case 2213601832:
					VOFrench = (string) p_Value;
					break;

				case 2207675566:
					VOGerman = (string) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 433771118:
					return VOEnglish;

				case 2343912184:
					return AudioSystemUri;

				case 2339452753:
					return VOCommon;

				case 3307845866:
					return VOItalian;

				case 1980789858:
					return VOSpanish;

				case 2213601832:
					return VOFrench;

				case 2207675566:
					return VOGerman;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 433771118:
					return typeof(SoundSettings).GetProperty(nameof(VOEnglish));

				case 2343912184:
					return typeof(SoundSettings).GetProperty(nameof(AudioSystemUri));

				case 2339452753:
					return typeof(SoundSettings).GetProperty(nameof(VOCommon));

				case 3307845866:
					return typeof(SoundSettings).GetProperty(nameof(VOItalian));

				case 1980789858:
					return typeof(SoundSettings).GetProperty(nameof(VOSpanish));

				case 2213601832:
					return typeof(SoundSettings).GetProperty(nameof(VOFrench));

				case 2207675566:
					return typeof(SoundSettings).GetProperty(nameof(VOGerman));

				case 2342790116:
					return typeof(SoundSettings).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
