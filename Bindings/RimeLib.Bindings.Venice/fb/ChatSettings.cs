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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 48)]
	public class ChatSettings : 
		Asset
	{
		protected List<ChatChannelType> m_Channels = new List<ChatChannelType>();
		[ContainerField(Name: "Channels", Offset: 12, NameHash: 1585412981, Flags: 65)]
		public List<ChatChannelType> Channels { get { return m_Channels; } set { if (OnPropertyChanging("ChatSettings." + nameof(Channels), this, m_Channels, value)) m_Channels = value; } } // 0xC (12)
		
		protected AntiSpamConfig m_AntiSpam = new AntiSpamConfig();
		[ContainerField(Name: "AntiSpam", Offset: 16, NameHash: 1819988664, Flags: 41)]
		public AntiSpamConfig AntiSpam { get { return m_AntiSpam; } set { if (OnPropertyChanging("ChatSettings." + nameof(AntiSpam), this, m_AntiSpam, value)) m_AntiSpam = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1585412981:
					if (p_Value.GetType() == typeof (List<uint>))
						Channels = ((List<uint>) p_Value).Select(x => (ChatChannelType) Enum.ToObject(typeof(ChatChannelType), x)).ToList();
					else
						Channels = (List<ChatChannelType>) p_Value;
					break;

				case 1819988664:
					AntiSpam = (AntiSpamConfig) p_Value;
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
				case 1585412981:
					return Channels;

				case 1819988664:
					return AntiSpam;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1585412981:
					return typeof(ChatSettings).GetProperty(nameof(Channels));

				case 1819988664:
					return typeof(ChatSettings).GetProperty(nameof(AntiSpam));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
