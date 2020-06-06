///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MessageEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable]
		public string MessageSid { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<MessageLineData> AdditionalMessages { get; set; } = new List<MessageLineData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public UIMessageEntityType MessageType { get; set; } = new UIMessageEntityType(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float DisplayTime { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public EntryInputActionEnum EntryInputAction { get; set; } = new EntryInputActionEnum(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x20 (32)
		
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
