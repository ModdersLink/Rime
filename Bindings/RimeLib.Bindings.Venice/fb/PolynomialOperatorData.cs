///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class PolynomialOperatorData : 
		EvaluatorData
	{
		[ContainerField(16)]
		public PolynomialTempData FirstOperand { get; set; } = new PolynomialTempData(); // 0x10 (16)
		
		[ContainerField(48)]
		public PolynomialTempData SecondOperand { get; set; } = new PolynomialTempData(); // 0x30 (48)
		
		[ContainerField(80)]
		public PolynomialOperation Operation { get; set; } = new PolynomialOperation(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float MinClampResult { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float MaxClampResult { get; set; } // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3787784796:
					FirstOperand = (PolynomialTempData) p_Value;
					break;

				case 46362454:
					SecondOperand = (PolynomialTempData) p_Value;
					break;

				case 2346271248:
					Operation = (PolynomialOperation) Enum.ToObject(typeof(PolynomialOperation), p_Value);
					break;

				case 3438772181:
					MinClampResult = (float) p_Value;
					break;

				case 2626134155:
					MaxClampResult = (float) p_Value;
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
				case 3787784796:
					return FirstOperand;

				case 46362454:
					return SecondOperand;

				case 2346271248:
					return Operation;

				case 3438772181:
					return MinClampResult;

				case 2626134155:
					return MaxClampResult;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3787784796:
					return typeof(PolynomialOperatorData).GetProperty(nameof(FirstOperand));

				case 46362454:
					return typeof(PolynomialOperatorData).GetProperty(nameof(SecondOperand));

				case 2346271248:
					return typeof(PolynomialOperatorData).GetProperty(nameof(Operation));

				case 3438772181:
					return typeof(PolynomialOperatorData).GetProperty(nameof(MinClampResult));

				case 2626134155:
					return typeof(PolynomialOperatorData).GetProperty(nameof(MaxClampResult));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
