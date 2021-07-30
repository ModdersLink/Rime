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
	[ContainerType(Alignment: 8,  Flags: 53, Size: 80)]
	public class OperandLogicNode : 
		UINodeData
	{
		protected UIDataSourceInfo m_LeftDataSourceInfo = new UIDataSourceInfo();
		[ContainerField(Name: "LeftDataSourceInfo", Offset: 20, NameHash: 872142941, Flags: 41)]
		public UIDataSourceInfo LeftDataSourceInfo { get { return m_LeftDataSourceInfo; } set { if (OnPropertyChanging("OperandLogicNode." + nameof(LeftDataSourceInfo), this, m_LeftDataSourceInfo, value)) m_LeftDataSourceInfo = value; } } // 0x14 (20)
		
		protected UILogicOperator m_Operator = new UILogicOperator();
		[ContainerField(Name: "Operator", Offset: 36, NameHash: 2153507813, Flags: 137)]
		public UILogicOperator Operator { get { return m_Operator; } set { if (OnPropertyChanging("OperandLogicNode." + nameof(Operator), this, m_Operator, value)) m_Operator = value; } } // 0x24 (36)
		
		protected UIDataSourceInfo m_RightDataSourceInfo = new UIDataSourceInfo();
		[ContainerField(Name: "RightDataSourceInfo", Offset: 40, NameHash: 3559826726, Flags: 41)]
		public UIDataSourceInfo RightDataSourceInfo { get { return m_RightDataSourceInfo; } set { if (OnPropertyChanging("OperandLogicNode." + nameof(RightDataSourceInfo), this, m_RightDataSourceInfo, value)) m_RightDataSourceInfo = value; } } // 0x28 (40)
		
		protected double m_RightLiteralOperand = new double();
		[ContainerField(Name: "RightLiteralOperand", Offset: 56, NameHash: 2434142605, Flags: 49485), LayoutImmutable, Blittable]
		public double RightLiteralOperand { get { return m_RightLiteralOperand; } set { if (OnPropertyChanging("OperandLogicNode." + nameof(RightLiteralOperand), this, m_RightLiteralOperand, value)) m_RightLiteralOperand = value; } } // 0x38 (56)
		
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(Name: "In", Offset: 64, NameHash: 5862146, Flags: 53)]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("OperandLogicNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x40 (64)
		
		protected CtrRef<UINodePort> m_True = new CtrRef<UINodePort>();
		[ContainerField(Name: "True", Offset: 68, NameHash: 2089293587, Flags: 53)]
		public CtrRef<UINodePort> True { get { return m_True; } set { if (OnPropertyChanging("OperandLogicNode." + nameof(True), this, m_True, value)) m_True = value; } } // 0x44 (68)
		
		protected CtrRef<UINodePort> m_False = new CtrRef<UINodePort>();
		[ContainerField(Name: "False", Offset: 72, NameHash: 206401336, Flags: 53)]
		public CtrRef<UINodePort> False { get { return m_False; } set { if (OnPropertyChanging("OperandLogicNode." + nameof(False), this, m_False, value)) m_False = value; } } // 0x48 (72)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 872142941:
					LeftDataSourceInfo = (UIDataSourceInfo) p_Value;
					break;

				case 2153507813:
					Operator = (UILogicOperator) Enum.ToObject(typeof(UILogicOperator), p_Value);
					break;

				case 3559826726:
					RightDataSourceInfo = (UIDataSourceInfo) p_Value;
					break;

				case 2434142605:
					RightLiteralOperand = (double) p_Value;
					break;

				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 2089293587:
					True = (CtrRef<UINodePort>) p_Value;
					break;

				case 206401336:
					False = (CtrRef<UINodePort>) p_Value;
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
				case 872142941:
					return LeftDataSourceInfo;

				case 2153507813:
					return Operator;

				case 3559826726:
					return RightDataSourceInfo;

				case 2434142605:
					return RightLiteralOperand;

				case 5862146:
					return In;

				case 2089293587:
					return True;

				case 206401336:
					return False;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 872142941:
					return typeof(OperandLogicNode).GetProperty(nameof(LeftDataSourceInfo));

				case 2153507813:
					return typeof(OperandLogicNode).GetProperty(nameof(Operator));

				case 3559826726:
					return typeof(OperandLogicNode).GetProperty(nameof(RightDataSourceInfo));

				case 2434142605:
					return typeof(OperandLogicNode).GetProperty(nameof(RightLiteralOperand));

				case 5862146:
					return typeof(OperandLogicNode).GetProperty(nameof(In));

				case 2089293587:
					return typeof(OperandLogicNode).GetProperty(nameof(True));

				case 206401336:
					return typeof(OperandLogicNode).GetProperty(nameof(False));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
