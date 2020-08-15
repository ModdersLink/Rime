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
	[ContainerType(16)]
	public class ChildMovingBodyData : 
		LinearMovingBodyData
	{
		protected float m_InputDelay = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(1617181990)]
		public float InputDelay { get { return m_InputDelay; } set { if (OnPropertyChanging("ChildMovingBodyData." + nameof(InputDelay), this, m_InputDelay, value)) m_InputDelay = value; } } // 0x50 (80)
		
		protected float m_Speed = new float();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(230887042)]
		public float Speed { get { return m_Speed; } set { if (OnPropertyChanging("ChildMovingBodyData." + nameof(Speed), this, m_Speed, value)) m_Speed = value; } } // 0x54 (84)
		
		protected EntryInputActionEnum m_InputAction = new EntryInputActionEnum();
		[ContainerField(88), ContainerFieldNameHash(1407707693)]
		public EntryInputActionEnum InputAction { get { return m_InputAction; } set { if (OnPropertyChanging("ChildMovingBodyData." + nameof(InputAction), this, m_InputAction, value)) m_InputAction = value; } } // 0x58 (88)
		
		protected float m_TriggerImpulse = new float();
		[ContainerField(92), LayoutImmutable, Blittable, ContainerFieldNameHash(2705515430)]
		public float TriggerImpulse { get { return m_TriggerImpulse; } set { if (OnPropertyChanging("ChildMovingBodyData." + nameof(TriggerImpulse), this, m_TriggerImpulse, value)) m_TriggerImpulse = value; } } // 0x5C (92)
		
		protected bool m_IsOneShotInput = new bool();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(1020834765)]
		public bool IsOneShotInput { get { return m_IsOneShotInput; } set { if (OnPropertyChanging("ChildMovingBodyData." + nameof(IsOneShotInput), this, m_IsOneShotInput, value)) m_IsOneShotInput = value; } } // 0x60 (96)
		
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
