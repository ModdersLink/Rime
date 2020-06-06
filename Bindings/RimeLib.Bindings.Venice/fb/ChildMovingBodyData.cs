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
    [ContainerType(16)]
	public class ChildMovingBodyData : 
		LinearMovingBodyData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public float InputDelay { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float Speed { get; set; } // 0x54 (84)
		
		[ContainerField(88)]
		public EntryInputActionEnum InputAction { get; set; } = new EntryInputActionEnum(); // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float TriggerImpulse { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool IsOneShotInput { get; set; } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1617181990:
					InputDelay = (float) p_Value;
					break;

				case 230887042:
					Speed = (float) p_Value;
					break;

				case 1407707693:
					InputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 2705515430:
					TriggerImpulse = (float) p_Value;
					break;

				case 1020834765:
					IsOneShotInput = (bool) p_Value;
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
				case 1617181990:
					return InputDelay;

				case 230887042:
					return Speed;

				case 1407707693:
					return InputAction;

				case 2705515430:
					return TriggerImpulse;

				case 1020834765:
					return IsOneShotInput;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1617181990:
					return typeof(ChildMovingBodyData).GetProperty(nameof(InputDelay));

				case 230887042:
					return typeof(ChildMovingBodyData).GetProperty(nameof(Speed));

				case 1407707693:
					return typeof(ChildMovingBodyData).GetProperty(nameof(InputAction));

				case 2705515430:
					return typeof(ChildMovingBodyData).GetProperty(nameof(TriggerImpulse));

				case 1020834765:
					return typeof(ChildMovingBodyData).GetProperty(nameof(IsOneShotInput));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
