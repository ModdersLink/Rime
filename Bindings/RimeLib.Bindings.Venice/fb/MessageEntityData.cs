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
	public class MessageEntityData : 
		EntityData
	{
		protected string m_MessageSid = string.Empty;
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(2895326256)]
		public string MessageSid { get { return m_MessageSid; } set { if (OnPropertyChanging("MessageEntityData." + nameof(MessageSid), this, m_MessageSid, value)) m_MessageSid = value; } } // 0xC (12)
		
		protected List<MessageLineData> m_AdditionalMessages = new List<MessageLineData>();
		[ContainerField(16), ContainerFieldNameHash(836911268)]
		public List<MessageLineData> AdditionalMessages { get { return m_AdditionalMessages; } set { if (OnPropertyChanging("MessageEntityData." + nameof(AdditionalMessages), this, m_AdditionalMessages, value)) m_AdditionalMessages = value; } } // 0x10 (16)
		
		protected UIMessageEntityType m_MessageType = new UIMessageEntityType();
		[ContainerField(20), ContainerFieldNameHash(1056298038)]
		public UIMessageEntityType MessageType { get { return m_MessageType; } set { if (OnPropertyChanging("MessageEntityData." + nameof(MessageType), this, m_MessageType, value)) m_MessageType = value; } } // 0x14 (20)
		
		protected float m_DisplayTime = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1925139498)]
		public float DisplayTime { get { return m_DisplayTime; } set { if (OnPropertyChanging("MessageEntityData." + nameof(DisplayTime), this, m_DisplayTime, value)) m_DisplayTime = value; } } // 0x18 (24)
		
		protected EntryInputActionEnum m_EntryInputAction = new EntryInputActionEnum();
		[ContainerField(28), ContainerFieldNameHash(4156259417)]
		public EntryInputActionEnum EntryInputAction { get { return m_EntryInputAction; } set { if (OnPropertyChanging("MessageEntityData." + nameof(EntryInputAction), this, m_EntryInputAction, value)) m_EntryInputAction = value; } } // 0x1C (28)
		
		protected bool m_Enabled = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("MessageEntityData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2895326256:
					MessageSid = (string) p_Value;
					break;

				case 836911268:
					AdditionalMessages = (List<MessageLineData>) p_Value;
					break;

				case 1056298038:
					MessageType = (UIMessageEntityType) Enum.ToObject(typeof(UIMessageEntityType), p_Value);
					break;

				case 1925139498:
					DisplayTime = (float) p_Value;
					break;

				case 4156259417:
					EntryInputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 2895326256:
					return MessageSid;

				case 836911268:
					return AdditionalMessages;

				case 1056298038:
					return MessageType;

				case 1925139498:
					return DisplayTime;

				case 4156259417:
					return EntryInputAction;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2895326256:
					return typeof(MessageEntityData).GetProperty(nameof(MessageSid));

				case 836911268:
					return typeof(MessageEntityData).GetProperty(nameof(AdditionalMessages));

				case 1056298038:
					return typeof(MessageEntityData).GetProperty(nameof(MessageType));

				case 1925139498:
					return typeof(MessageEntityData).GetProperty(nameof(DisplayTime));

				case 4156259417:
					return typeof(MessageEntityData).GetProperty(nameof(EntryInputAction));

				case 2662400:
					return typeof(MessageEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
