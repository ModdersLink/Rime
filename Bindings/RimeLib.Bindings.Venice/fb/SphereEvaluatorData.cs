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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(64), ContainerClass]
	public class SphereEvaluatorData : 
		EvaluatorData
	{
		protected Vec3 m_Scale = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(231223453)]
		public Vec3 Scale { get { return m_Scale; } set { if (OnPropertyChanging("SphereEvaluatorData." + nameof(Scale), this, m_Scale, value)) m_Scale = value; } } // 0x10 (16)
		
		protected Vec3 m_Pivot = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(232602033)]
		public Vec3 Pivot { get { return m_Pivot; } set { if (OnPropertyChanging("SphereEvaluatorData." + nameof(Pivot), this, m_Pivot, value)) m_Pivot = value; } } // 0x20 (32)
		
		protected float m_Radius = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3298407133)]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("SphereEvaluatorData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231223453:
					Scale = (Vec3) p_Value;
					break;

				case 232602033:
					Pivot = (Vec3) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
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
				case 231223453:
					return Scale;

				case 232602033:
					return Pivot;

				case 3298407133:
					return Radius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231223453:
					return typeof(SphereEvaluatorData).GetProperty(nameof(Scale));

				case 232602033:
					return typeof(SphereEvaluatorData).GetProperty(nameof(Pivot));

				case 3298407133:
					return typeof(SphereEvaluatorData).GetProperty(nameof(Radius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
