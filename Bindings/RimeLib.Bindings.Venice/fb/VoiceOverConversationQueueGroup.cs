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
	public class VoiceOverConversationQueueGroup : 
		DataContainer
	{
		protected string m_Name = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("VoiceOverConversationQueueGroup." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected VoiceOverConversationQueueGroupPolyphony m_PolyphonyMode = new VoiceOverConversationQueueGroupPolyphony();
		[ContainerField(12), ContainerFieldNameHash(1898569388)]
		public VoiceOverConversationQueueGroupPolyphony PolyphonyMode { get { return m_PolyphonyMode; } set { if (OnPropertyChanging("VoiceOverConversationQueueGroup." + nameof(PolyphonyMode), this, m_PolyphonyMode, value)) m_PolyphonyMode = value; } } // 0xC (12)
		
		protected uint m_Polyphony = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3372275311)]
		public uint Polyphony { get { return m_Polyphony; } set { if (OnPropertyChanging("VoiceOverConversationQueueGroup." + nameof(Polyphony), this, m_Polyphony, value)) m_Polyphony = value; } } // 0x10 (16)
		
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
