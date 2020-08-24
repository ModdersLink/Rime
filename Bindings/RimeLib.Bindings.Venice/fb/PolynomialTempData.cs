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
	[ContainerType(16), MemberInfoFlag(41), ContainerStruct]
	public class PolynomialTempData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec4 Coefficients { get; set; } = new Vec4(); // 0x0 (0)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ScaleValue { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinClamp { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxClamp { get; set; } // 0x18 (24)
		
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
					return typeof(PolynomialTempData).GetProperty(nameof(Coefficients));

				case 1405926902:
					return typeof(PolynomialTempData).GetProperty(nameof(ScaleValue));

				case 3349357596:
					return typeof(PolynomialTempData).GetProperty(nameof(MinClamp));

				case 415055298:
					return typeof(PolynomialTempData).GetProperty(nameof(MaxClamp));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
