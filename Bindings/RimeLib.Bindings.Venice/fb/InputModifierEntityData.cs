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
	public class InputModifierEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public EntryInputActionEnum Action { get; set; } = new EntryInputActionEnum(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Scale { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Offset { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2484178491:
					Action = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 231223453:
					Scale = (float) p_Value;
					break;

				case 2871410728:
					Offset = (float) p_Value;
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
				case 2484178491:
					return Action;

				case 231223453:
					return Scale;

				case 2871410728:
					return Offset;

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
				case 2484178491:
					return typeof(InputModifierEntityData).GetProperty(nameof(Action));

				case 231223453:
					return typeof(InputModifierEntityData).GetProperty(nameof(Scale));

				case 2871410728:
					return typeof(InputModifierEntityData).GetProperty(nameof(Offset));

				case 2662400:
					return typeof(InputModifierEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
