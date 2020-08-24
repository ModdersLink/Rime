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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class BoxEvaluatorData : 
		EvaluatorData
	{
		protected Vec3 m_Dimensions = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2541621734)]
		public Vec3 Dimensions { get { return m_Dimensions; } set { if (OnPropertyChanging("BoxEvaluatorData." + nameof(Dimensions), this, m_Dimensions, value)) m_Dimensions = value; } } // 0x10 (16)
		
		protected Vec3 m_Pivot = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(232602033)]
		public Vec3 Pivot { get { return m_Pivot; } set { if (OnPropertyChanging("BoxEvaluatorData." + nameof(Pivot), this, m_Pivot, value)) m_Pivot = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2541621734:
					Dimensions = (Vec3) p_Value;
					break;

				case 232602033:
					Pivot = (Vec3) p_Value;
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
				case 2541621734:
					return Dimensions;

				case 232602033:
					return Pivot;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2541621734:
					return typeof(BoxEvaluatorData).GetProperty(nameof(Dimensions));

				case 232602033:
					return typeof(BoxEvaluatorData).GetProperty(nameof(Pivot));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
