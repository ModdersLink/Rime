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
	public class MessageLineData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string MessageSid { get; set; } // 0x0 (0)
		
		[ContainerField(4)]
		public EntryInputActionEnum EntryInputAction { get; set; } = new EntryInputActionEnum(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2895326256:
					MessageSid = (string) p_Value;
					break;

				case 4156259417:
						EntryInputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
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

				case 4156259417:
					return EntryInputAction;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2895326256:
					return typeof(MessageLineData).GetProperty(nameof(MessageSid));

				case 4156259417:
					return typeof(MessageLineData).GetProperty(nameof(EntryInputAction));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
