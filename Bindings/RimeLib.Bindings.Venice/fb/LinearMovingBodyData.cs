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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 80)]
	public class LinearMovingBodyData : 
		MovingBodyData
	{
		protected Vec3 m_Axis = new Vec3();
		[ContainerField(Name: "Axis", Offset: 16, NameHash: 2088662246, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Axis { get { return m_Axis; } set { if (OnPropertyChanging("LinearMovingBodyData." + nameof(Axis), this, m_Axis, value)) m_Axis = value; } } // 0x10 (16)
		
		protected EndPointData m_Start = new EndPointData();
		[ContainerField(Name: "Start", Offset: 32, NameHash: 230748069, Flags: 41)]
		public EndPointData Start { get { return m_Start; } set { if (OnPropertyChanging("LinearMovingBodyData." + nameof(Start), this, m_Start, value)) m_Start = value; } } // 0x20 (32)
		
		protected EndPointData m_End = new EndPointData();
		[ContainerField(Name: "End", Offset: 52, NameHash: 193438506, Flags: 41)]
		public EndPointData End { get { return m_End; } set { if (OnPropertyChanging("LinearMovingBodyData." + nameof(End), this, m_End, value)) m_End = value; } } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088662246:
					Axis = (Vec3) p_Value;
					break;

				case 230748069:
					Start = (EndPointData) p_Value;
					break;

				case 193438506:
					End = (EndPointData) p_Value;
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
				case 2088662246:
					return Axis;

				case 230748069:
					return Start;

				case 193438506:
					return End;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088662246:
					return typeof(LinearMovingBodyData).GetProperty(nameof(Axis));

				case 230748069:
					return typeof(LinearMovingBodyData).GetProperty(nameof(Start));

				case 193438506:
					return typeof(LinearMovingBodyData).GetProperty(nameof(End));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
