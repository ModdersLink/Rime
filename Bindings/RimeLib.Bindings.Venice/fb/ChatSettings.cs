///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ChatSettings : 
		Asset
	{
		[ContainerField(12)]
		public List<ChatChannelType> Channels { get; set; } = new List<ChatChannelType>(); // 0xC (12)
		
		[ContainerField(16)]
		public AntiSpamConfig AntiSpam { get; set; } = new AntiSpamConfig(); // 0x10 (16)
		
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
