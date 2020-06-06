///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class PolynomialData : 
		EvaluatorData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Coefficients { get; set; } = new Vec4(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ScaleValue { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float MinClamp { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxClamp { get; set; } // 0x28 (40)
		
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
