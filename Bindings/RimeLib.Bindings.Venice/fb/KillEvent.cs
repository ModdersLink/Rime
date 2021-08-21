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
	public class KillEvent : 
		MetricEvent
	{
		protected Vec3 m_Position = new Vec3();
		[ContainerField(Name: "Position", Offset: 16, NameHash: 3402582524, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get { return m_Position; } set { if (OnPropertyChanging("KillEvent." + nameof(Position), this, m_Position, value)) m_Position = value; } } // 0x10 (16)
		
		protected Vec3 m_VictimPosition = new Vec3();
		[ContainerField(Name: "VictimPosition", Offset: 32, NameHash: 558744976, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 VictimPosition { get { return m_VictimPosition; } set { if (OnPropertyChanging("KillEvent." + nameof(VictimPosition), this, m_VictimPosition, value)) m_VictimPosition = value; } } // 0x20 (32)
		
		protected ulong m_VictimId = new ulong();
		[ContainerField(Name: "VictimId", Offset: 48, NameHash: 306175396, Flags: 49453), LayoutImmutable, Blittable]
		public ulong VictimId { get { return m_VictimId; } set { if (OnPropertyChanging("KillEvent." + nameof(VictimId), this, m_VictimId, value)) m_VictimId = value; } } // 0x30 (48)
		
		protected float m_Time = new float();
		[ContainerField(Name: "Time", Offset: 56, NameHash: 2089313744, Flags: 49469), LayoutImmutable, Blittable]
		public float Time { get { return m_Time; } set { if (OnPropertyChanging("KillEvent." + nameof(Time), this, m_Time, value)) m_Time = value; } } // 0x38 (56)
		
		protected string m_Weapon = string.Empty;
		[ContainerField(Name: "Weapon", Offset: 60, NameHash: 3190562823, Flags: 16509), LayoutImmutable]
		public string Weapon { get { return m_Weapon; } set { if (OnPropertyChanging("KillEvent." + nameof(Weapon), this, m_Weapon, value)) m_Weapon = value; } } // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec3) p_Value;
					break;

				case 558744976:
					VictimPosition = (Vec3) p_Value;
					break;

				case 306175396:
					VictimId = (ulong) p_Value;
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

				case 558744976:
					return VictimPosition;

				case 306175396:
					return VictimId;

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
					return typeof(KillEvent).GetProperty(nameof(Position));

				case 558744976:
					return typeof(KillEvent).GetProperty(nameof(VictimPosition));

				case 306175396:
					return typeof(KillEvent).GetProperty(nameof(VictimId));

				case 2089313744:
					return typeof(KillEvent).GetProperty(nameof(Time));

				case 3190562823:
					return typeof(KillEvent).GetProperty(nameof(Weapon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
