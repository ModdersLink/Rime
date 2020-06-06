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
	public class VoiceOverConversationQueueGroup : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public VoiceOverConversationQueueGroupPolyphony PolyphonyMode { get; set; } = new VoiceOverConversationQueueGroupPolyphony(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint Polyphony { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1898569388:
					PolyphonyMode = (VoiceOverConversationQueueGroupPolyphony) Enum.ToObject(typeof(VoiceOverConversationQueueGroupPolyphony), p_Value);
					break;

				case 3372275311:
					Polyphony = (uint) p_Value;
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

				case 1898569388:
					return PolyphonyMode;

				case 3372275311:
					return Polyphony;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(VoiceOverConversationQueueGroup).GetProperty(nameof(Name));

				case 1898569388:
					return typeof(VoiceOverConversationQueueGroup).GetProperty(nameof(PolyphonyMode));

				case 3372275311:
					return typeof(VoiceOverConversationQueueGroup).GetProperty(nameof(Polyphony));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
