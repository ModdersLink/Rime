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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class VoiceOverConversationQueueGroup : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 8, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("VoiceOverConversationQueueGroup." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected VoiceOverConversationQueueGroupPolyphony m_PolyphonyMode = new VoiceOverConversationQueueGroupPolyphony();
		[ContainerField(Name: "PolyphonyMode", Offset: 12, NameHash: 1898569388, Flags: 137)]
		public VoiceOverConversationQueueGroupPolyphony PolyphonyMode { get { return m_PolyphonyMode; } set { if (OnPropertyChanging("VoiceOverConversationQueueGroup." + nameof(PolyphonyMode), this, m_PolyphonyMode, value)) m_PolyphonyMode = value; } } // 0xC (12)
		
		protected uint m_Polyphony = new uint();
		[ContainerField(Name: "Polyphony", Offset: 16, NameHash: 3372275311, Flags: 49421), LayoutImmutable, Blittable]
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
