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
	public class MotionDampingData : 
		DataContainer
	{
		protected Vec3 m_LinearModifier = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2104370415)]
		public Vec3 LinearModifier { get { return m_LinearModifier; } set { if (OnPropertyChanging("MotionDampingData." + nameof(LinearModifier), this, m_LinearModifier, value)) m_LinearModifier = value; } } // 0x10 (16)
		
		protected float m_Pitch = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(232604323)]
		public float Pitch { get { return m_Pitch; } set { if (OnPropertyChanging("MotionDampingData." + nameof(Pitch), this, m_Pitch, value)) m_Pitch = value; } } // 0x20 (32)
		
		protected float m_Yaw = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(193468618)]
		public float Yaw { get { return m_Yaw; } set { if (OnPropertyChanging("MotionDampingData." + nameof(Yaw), this, m_Yaw, value)) m_Yaw = value; } } // 0x24 (36)
		
		protected float m_Roll = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(2089387576)]
		public float Roll { get { return m_Roll; } set { if (OnPropertyChanging("MotionDampingData." + nameof(Roll), this, m_Roll, value)) m_Roll = value; } } // 0x28 (40)
		
		protected float m_Linear = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2893456344)]
		public float Linear { get { return m_Linear; } set { if (OnPropertyChanging("MotionDampingData." + nameof(Linear), this, m_Linear, value)) m_Linear = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2104370415:
					LinearModifier = (Vec3) p_Value;
					break;

				case 232604323:
					Pitch = (float) p_Value;
					break;

				case 193468618:
					Yaw = (float) p_Value;
					break;

				case 2089387576:
					Roll = (float) p_Value;
					break;

				case 2893456344:
					Linear = (float) p_Value;
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
				case 2104370415:
					return LinearModifier;

				case 232604323:
					return Pitch;

				case 193468618:
					return Yaw;

				case 2089387576:
					return Roll;

				case 2893456344:
					return Linear;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2104370415:
					return typeof(MotionDampingData).GetProperty(nameof(LinearModifier));

				case 232604323:
					return typeof(MotionDampingData).GetProperty(nameof(Pitch));

				case 193468618:
					return typeof(MotionDampingData).GetProperty(nameof(Yaw));

				case 2089387576:
					return typeof(MotionDampingData).GetProperty(nameof(Roll));

				case 2893456344:
					return typeof(MotionDampingData).GetProperty(nameof(Linear));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
