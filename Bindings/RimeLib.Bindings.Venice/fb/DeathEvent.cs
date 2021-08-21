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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class DeathEvent : 
		MetricEvent
	{
		protected Vec3 m_Position = new Vec3();
		[ContainerField(Name: "Position", Offset: 16, NameHash: 3402582524, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get { return m_Position; } set { if (OnPropertyChanging("DeathEvent." + nameof(Position), this, m_Position, value)) m_Position = value; } } // 0x10 (16)
		
		protected Vec3 m_KillerPosition = new Vec3();
		[ContainerField(Name: "KillerPosition", Offset: 32, NameHash: 1483294665, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 KillerPosition { get { return m_KillerPosition; } set { if (OnPropertyChanging("DeathEvent." + nameof(KillerPosition), this, m_KillerPosition, value)) m_KillerPosition = value; } } // 0x20 (32)
		
		protected ulong m_KillerId = new ulong();
		[ContainerField(Name: "KillerId", Offset: 48, NameHash: 3035491517, Flags: 49453), LayoutImmutable, Blittable]
		public ulong KillerId { get { return m_KillerId; } set { if (OnPropertyChanging("DeathEvent." + nameof(KillerId), this, m_KillerId, value)) m_KillerId = value; } } // 0x30 (48)
		
		protected float m_Time = new float();
		[ContainerField(Name: "Time", Offset: 56, NameHash: 2089313744, Flags: 49469), LayoutImmutable, Blittable]
		public float Time { get { return m_Time; } set { if (OnPropertyChanging("DeathEvent." + nameof(Time), this, m_Time, value)) m_Time = value; } } // 0x38 (56)
		
		protected string m_Weapon = string.Empty;
		[ContainerField(Name: "Weapon", Offset: 60, NameHash: 3190562823, Flags: 16509), LayoutImmutable]
		public string Weapon { get { return m_Weapon; } set { if (OnPropertyChanging("DeathEvent." + nameof(Weapon), this, m_Weapon, value)) m_Weapon = value; } } // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec3) p_Value;
					break;

				case 1483294665:
					KillerPosition = (Vec3) p_Value;
					break;

				case 3035491517:
					KillerId = (ulong) p_Value;
					break;

				case 2089313744:
					Time = (float) p_Value;
					break;

				case 3190562823:
					Weapon = (string) p_Value;
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
				case 3402582524:
					return Position;

				case 1483294665:
					return KillerPosition;

				case 3035491517:
					return KillerId;

				case 2089313744:
					return Time;

				case 3190562823:
					return Weapon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return typeof(DeathEvent).GetProperty(nameof(Position));

				case 1483294665:
					return typeof(DeathEvent).GetProperty(nameof(KillerPosition));

				case 3035491517:
					return typeof(DeathEvent).GetProperty(nameof(KillerId));

				case 2089313744:
					return typeof(DeathEvent).GetProperty(nameof(Time));

				case 3190562823:
					return typeof(DeathEvent).GetProperty(nameof(Weapon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
