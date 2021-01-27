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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class PolynomialOperatorData : 
		EvaluatorData
	{
		protected PolynomialTempData m_FirstOperand = new PolynomialTempData();
		[ContainerField(Name: "FirstOperand", Offset: 16, NameHash: 3787784796, Flags: 41)]
		public PolynomialTempData FirstOperand { get { return m_FirstOperand; } set { if (OnPropertyChanging("PolynomialOperatorData." + nameof(FirstOperand), this, m_FirstOperand, value)) m_FirstOperand = value; } } // 0x10 (16)
		
		protected PolynomialTempData m_SecondOperand = new PolynomialTempData();
		[ContainerField(Name: "SecondOperand", Offset: 48, NameHash: 46362454, Flags: 41)]
		public PolynomialTempData SecondOperand { get { return m_SecondOperand; } set { if (OnPropertyChanging("PolynomialOperatorData." + nameof(SecondOperand), this, m_SecondOperand, value)) m_SecondOperand = value; } } // 0x30 (48)
		
		protected PolynomialOperation m_Operation = new PolynomialOperation();
		[ContainerField(Name: "Operation", Offset: 80, NameHash: 2346271248, Flags: 137)]
		public PolynomialOperation Operation { get { return m_Operation; } set { if (OnPropertyChanging("PolynomialOperatorData." + nameof(Operation), this, m_Operation, value)) m_Operation = value; } } // 0x50 (80)
		
		protected float m_MinClampResult = new float();
		[ContainerField(Name: "MinClampResult", Offset: 84, NameHash: 3438772181, Flags: 49469), LayoutImmutable, Blittable]
		public float MinClampResult { get { return m_MinClampResult; } set { if (OnPropertyChanging("PolynomialOperatorData." + nameof(MinClampResult), this, m_MinClampResult, value)) m_MinClampResult = value; } } // 0x54 (84)
		
		protected float m_MaxClampResult = new float();
		[ContainerField(Name: "MaxClampResult", Offset: 88, NameHash: 2626134155, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxClampResult { get { return m_MaxClampResult; } set { if (OnPropertyChanging("PolynomialOperatorData." + nameof(MaxClampResult), this, m_MaxClampResult, value)) m_MaxClampResult = value; } } // 0x58 (88)
		
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
