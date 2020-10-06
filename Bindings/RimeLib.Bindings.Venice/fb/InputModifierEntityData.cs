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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class InputModifierEntityData : 
		EntityData
	{
		protected EntryInputActionEnum m_Action = new EntryInputActionEnum();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(2484178491)]
		public EntryInputActionEnum Action { get { return m_Action; } set { if (OnPropertyChanging("InputModifierEntityData." + nameof(Action), this, m_Action, value)) m_Action = value; } } // 0xC (12)
		
		protected float m_Scale = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(231223453)]
		public float Scale { get { return m_Scale; } set { if (OnPropertyChanging("InputModifierEntityData." + nameof(Scale), this, m_Scale, value)) m_Scale = value; } } // 0x10 (16)
		
		protected float m_Offset = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2871410728)]
		public float Offset { get { return m_Offset; } set { if (OnPropertyChanging("InputModifierEntityData." + nameof(Offset), this, m_Offset, value)) m_Offset = value; } } // 0x14 (20)
		
		protected bool m_Enabled = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("InputModifierEntityData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x18 (24)
		
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
