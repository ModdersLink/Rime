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
	public class PolynomialColorInterpData : 
		EvaluatorData
	{
		protected Vec3 m_Color0 = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2713814216)]
		public Vec3 Color0 { get { return m_Color0; } set { if (OnPropertyChanging("PolynomialColorInterpData." + nameof(Color0), this, m_Color0, value)) m_Color0 = value; } } // 0x10 (16)
		
		protected Vec3 m_Color1 = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2713814217)]
		public Vec3 Color1 { get { return m_Color1; } set { if (OnPropertyChanging("PolynomialColorInterpData." + nameof(Color1), this, m_Color1, value)) m_Color1 = value; } } // 0x20 (32)
		
		protected Vec4 m_Coefficients = new Vec4();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2816855587)]
		public Vec4 Coefficients { get { return m_Coefficients; } set { if (OnPropertyChanging("PolynomialColorInterpData." + nameof(Coefficients), this, m_Coefficients, value)) m_Coefficients = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2713814216:
					Color0 = (Vec3) p_Value;
					break;

				case 2713814217:
					Color1 = (Vec3) p_Value;
					break;

				case 2816855587:
					Coefficients = (Vec4) p_Value;
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
				case 2713814216:
					return Color0;

				case 2713814217:
					return Color1;

				case 2816855587:
					return Coefficients;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2713814216:
					return typeof(PolynomialColorInterpData).GetProperty(nameof(Color0));

				case 2713814217:
					return typeof(PolynomialColorInterpData).GetProperty(nameof(Color1));

				case 2816855587:
					return typeof(PolynomialColorInterpData).GetProperty(nameof(Coefficients));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
