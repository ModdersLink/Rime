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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class UIAudioEventAsset : 
		Asset
	{
		protected List<UIAudioEventMapping> m_AudioEventMappings = new List<UIAudioEventMapping>();
		[ContainerField(Name: "AudioEventMappings", Offset: 12, NameHash: 3437982272, Flags: 65)]
		public List<UIAudioEventMapping> AudioEventMappings { get { return m_AudioEventMappings; } set { if (OnPropertyChanging("UIAudioEventAsset." + nameof(AudioEventMappings), this, m_AudioEventMappings, value)) m_AudioEventMappings = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3437982272:
					AudioEventMappings = (List<UIAudioEventMapping>) p_Value;
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
				case 3437982272:
					return AudioEventMappings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3437982272:
					return typeof(UIAudioEventAsset).GetProperty(nameof(AudioEventMappings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
