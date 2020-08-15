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
	[ContainerType(4)]
	public class RotateVectorData : 
		EvaluatorData
	{
		protected float m_Angle = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(205597860)]
		public float Angle { get { return m_Angle; } set { if (OnPropertyChanging("RotateVectorData." + nameof(Angle), this, m_Angle, value)) m_Angle = value; } } // 0xC (12)
		
		protected bool m_RotateWithinPlane = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(658584111)]
		public bool RotateWithinPlane { get { return m_RotateWithinPlane; } set { if (OnPropertyChanging("RotateVectorData." + nameof(RotateWithinPlane), this, m_RotateWithinPlane, value)) m_RotateWithinPlane = value; } } // 0x10 (16)
		
		protected bool m_InputAffectsPhi = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, ContainerFieldNameHash(2136254690)]
		public bool InputAffectsPhi { get { return m_InputAffectsPhi; } set { if (OnPropertyChanging("RotateVectorData." + nameof(InputAffectsPhi), this, m_InputAffectsPhi, value)) m_InputAffectsPhi = value; } } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 205597860:
					Angle = (float) p_Value;
					break;

				case 658584111:
					RotateWithinPlane = (bool) p_Value;
					break;

				case 2136254690:
					InputAffectsPhi = (bool) p_Value;
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
				case 205597860:
					return Angle;

				case 658584111:
					return RotateWithinPlane;

				case 2136254690:
					return InputAffectsPhi;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 205597860:
					return typeof(RotateVectorData).GetProperty(nameof(Angle));

				case 658584111:
					return typeof(RotateVectorData).GetProperty(nameof(RotateWithinPlane));

				case 2136254690:
					return typeof(RotateVectorData).GetProperty(nameof(InputAffectsPhi));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
