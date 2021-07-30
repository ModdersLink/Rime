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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 48)]
	public class PolynomialData : 
		EvaluatorData
	{
		protected Vec4 m_Coefficients = new Vec4();
		[ContainerField(Name: "Coefficients", Offset: 16, NameHash: 2816855587, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Coefficients { get { return m_Coefficients; } set { if (OnPropertyChanging("PolynomialData." + nameof(Coefficients), this, m_Coefficients, value)) m_Coefficients = value; } } // 0x10 (16)
		
		protected float m_ScaleValue = new float();
		[ContainerField(Name: "ScaleValue", Offset: 32, NameHash: 1405926902, Flags: 49469), LayoutImmutable, Blittable]
		public float ScaleValue { get { return m_ScaleValue; } set { if (OnPropertyChanging("PolynomialData." + nameof(ScaleValue), this, m_ScaleValue, value)) m_ScaleValue = value; } } // 0x20 (32)
		
		protected float m_MinClamp = new float();
		[ContainerField(Name: "MinClamp", Offset: 36, NameHash: 3349357596, Flags: 49469), LayoutImmutable, Blittable]
		public float MinClamp { get { return m_MinClamp; } set { if (OnPropertyChanging("PolynomialData." + nameof(MinClamp), this, m_MinClamp, value)) m_MinClamp = value; } } // 0x24 (36)
		
		protected float m_MaxClamp = new float();
		[ContainerField(Name: "MaxClamp", Offset: 40, NameHash: 415055298, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxClamp { get { return m_MaxClamp; } set { if (OnPropertyChanging("PolynomialData." + nameof(MaxClamp), this, m_MaxClamp, value)) m_MaxClamp = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2816855587:
					Coefficients = (Vec4) p_Value;
					break;

				case 1405926902:
					ScaleValue = (float) p_Value;
					break;

				case 3349357596:
					MinClamp = (float) p_Value;
					break;

				case 415055298:
					MaxClamp = (float) p_Value;
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
				case 2816855587:
					return Coefficients;

				case 1405926902:
					return ScaleValue;

				case 3349357596:
					return MinClamp;

				case 415055298:
					return MaxClamp;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2816855587:
					return typeof(PolynomialData).GetProperty(nameof(Coefficients));

				case 1405926902:
					return typeof(PolynomialData).GetProperty(nameof(ScaleValue));

				case 3349357596:
					return typeof(PolynomialData).GetProperty(nameof(MinClamp));

				case 415055298:
					return typeof(PolynomialData).GetProperty(nameof(MaxClamp));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
