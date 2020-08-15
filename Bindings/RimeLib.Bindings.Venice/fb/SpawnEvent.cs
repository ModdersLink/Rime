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
	public class SpawnEvent : 
		MetricEvent
	{
		protected Vec3 m_Position = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(3402582524)]
		public Vec3 Position { get { return m_Position; } set { if (OnPropertyChanging("SpawnEvent." + nameof(Position), this, m_Position, value)) m_Position = value; } } // 0x10 (16)
		
		protected float m_Time = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(2089313744)]
		public float Time { get { return m_Time; } set { if (OnPropertyChanging("SpawnEvent." + nameof(Time), this, m_Time, value)) m_Time = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec3) p_Value;
					break;

				case 2089313744:
					Time = (float) p_Value;
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

				case 2089313744:
					return Time;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return typeof(SpawnEvent).GetProperty(nameof(Position));

				case 2089313744:
					return typeof(SpawnEvent).GetProperty(nameof(Time));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
