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
	public class PolynomialColorInterpData : 
		EvaluatorData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color0 { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color1 { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Coefficients { get; set; } = new Vec4(); // 0x30 (48)
		
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
