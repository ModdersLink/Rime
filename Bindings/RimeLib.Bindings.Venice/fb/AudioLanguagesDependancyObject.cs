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
	public class AudioLanguagesDependancyObject : 
		DataContainer
	{
		protected RefArray<AudioLanguage> m_AudioLanguages = new RefArray<AudioLanguage>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(582937106), ContainerRefArray]
		public RefArray<AudioLanguage> AudioLanguages { get { return m_AudioLanguages; } set { if (OnPropertyChanging("AudioLanguagesDependancyObject." + nameof(AudioLanguages), this, m_AudioLanguages, value)) m_AudioLanguages = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 582937106:
					AudioLanguages = (RefArray<AudioLanguage>) p_Value;
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
				case 582937106:
					return AudioLanguages;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 582937106:
					return typeof(AudioLanguagesDependancyObject).GetProperty(nameof(AudioLanguages));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
