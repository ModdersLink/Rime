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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(40), ContainerClass]
	public class SimpleMovementActionData : 
		SimpleMovementActionBaseData
	{
		protected float m_Level = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(218262515)]
		public float Level { get { return m_Level; } set { if (OnPropertyChanging("SimpleMovementActionData." + nameof(Level), this, m_Level, value)) m_Level = value; } } // 0x18 (24)
		
		protected EntryInputActionEnum m_Action = new EntryInputActionEnum();
		[ContainerField(28), MemberInfoFlag(137), ContainerFieldNameHash(2484178491)]
		public EntryInputActionEnum Action { get { return m_Action; } set { if (OnPropertyChanging("SimpleMovementActionData." + nameof(Action), this, m_Action, value)) m_Action = value; } } // 0x1C (28)
		
		protected int m_SpecialAnimationIndex = new int();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(502517260)]
		public int SpecialAnimationIndex { get { return m_SpecialAnimationIndex; } set { if (OnPropertyChanging("SimpleMovementActionData." + nameof(SpecialAnimationIndex), this, m_SpecialAnimationIndex, value)) m_SpecialAnimationIndex = value; } } // 0x20 (32)
		
		protected bool m_Respawn = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1303651241)]
		public bool Respawn { get { return m_Respawn; } set { if (OnPropertyChanging("SimpleMovementActionData." + nameof(Respawn), this, m_Respawn, value)) m_Respawn = value; } } // 0x24 (36)
		
		protected bool m_Teleport = new bool();
		[ContainerField(37), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2495240740)]
		public bool Teleport { get { return m_Teleport; } set { if (OnPropertyChanging("SimpleMovementActionData." + nameof(Teleport), this, m_Teleport, value)) m_Teleport = value; } } // 0x25 (37)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 218262515:
					Level = (float) p_Value;
					break;

				case 2484178491:
					Action = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 502517260:
					SpecialAnimationIndex = (int) p_Value;
					break;

				case 1303651241:
					Respawn = (bool) p_Value;
					break;

				case 2495240740:
					Teleport = (bool) p_Value;
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
				case 218262515:
					return Level;

				case 2484178491:
					return Action;

				case 502517260:
					return SpecialAnimationIndex;

				case 1303651241:
					return Respawn;

				case 2495240740:
					return Teleport;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 218262515:
					return typeof(SimpleMovementActionData).GetProperty(nameof(Level));

				case 2484178491:
					return typeof(SimpleMovementActionData).GetProperty(nameof(Action));

				case 502517260:
					return typeof(SimpleMovementActionData).GetProperty(nameof(SpecialAnimationIndex));

				case 1303651241:
					return typeof(SimpleMovementActionData).GetProperty(nameof(Respawn));

				case 2495240740:
					return typeof(SimpleMovementActionData).GetProperty(nameof(Teleport));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
