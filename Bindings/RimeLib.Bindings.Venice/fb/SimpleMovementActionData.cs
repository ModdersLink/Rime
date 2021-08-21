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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class SimpleMovementActionData : 
		SimpleMovementActionBaseData
	{
		protected float m_Level = new float();
		[ContainerField(Name: "Level", Offset: 24, NameHash: 218262515, Flags: 49469), LayoutImmutable, Blittable]
		public float Level { get { return m_Level; } set { if (OnPropertyChanging("SimpleMovementActionData." + nameof(Level), this, m_Level, value)) m_Level = value; } } // 0x18 (24)
		
		protected EntryInputActionEnum m_Action = new EntryInputActionEnum();
		[ContainerField(Name: "Action", Offset: 28, NameHash: 2484178491, Flags: 137)]
		public EntryInputActionEnum Action { get { return m_Action; } set { if (OnPropertyChanging("SimpleMovementActionData." + nameof(Action), this, m_Action, value)) m_Action = value; } } // 0x1C (28)
		
		protected int m_SpecialAnimationIndex = new int();
		[ContainerField(Name: "SpecialAnimationIndex", Offset: 32, NameHash: 502517260, Flags: 49405), LayoutImmutable, Blittable]
		public int SpecialAnimationIndex { get { return m_SpecialAnimationIndex; } set { if (OnPropertyChanging("SimpleMovementActionData." + nameof(SpecialAnimationIndex), this, m_SpecialAnimationIndex, value)) m_SpecialAnimationIndex = value; } } // 0x20 (32)
		
		protected bool m_Respawn = new bool();
		[ContainerField(Name: "Respawn", Offset: 36, NameHash: 1303651241, Flags: 49325), LayoutImmutable, Blittable]
		public bool Respawn { get { return m_Respawn; } set { if (OnPropertyChanging("SimpleMovementActionData." + nameof(Respawn), this, m_Respawn, value)) m_Respawn = value; } } // 0x24 (36)
		
		protected bool m_Teleport = new bool();
		[ContainerField(Name: "Teleport", Offset: 37, NameHash: 2495240740, Flags: 49325), LayoutImmutable, Blittable]
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
