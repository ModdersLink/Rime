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
    [ContainerType(8)]
	public class OperandLogicNode : 
		UINodeData
	{
		[ContainerField(20)]
		public UIDataSourceInfo LeftDataSourceInfo { get; set; } = new UIDataSourceInfo(); // 0x14 (20)
		
		[ContainerField(36)]
		public UILogicOperator Operator { get; set; } = new UILogicOperator(); // 0x24 (36)
		
		[ContainerField(40)]
		public UIDataSourceInfo RightDataSourceInfo { get; set; } = new UIDataSourceInfo(); // 0x28 (40)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public double RightLiteralOperand { get; set; } // 0x38 (56)
		
		[ContainerField(64)]
		public CtrRef<UINodePort> In { get; set; } = new CtrRef<UINodePort>(); // 0x40 (64)
		
		[ContainerField(68)]
		public CtrRef<UINodePort> True { get; set; } = new CtrRef<UINodePort>(); // 0x44 (68)
		
		[ContainerField(72)]
		public CtrRef<UINodePort> False { get; set; } = new CtrRef<UINodePort>(); // 0x48 (72)
		
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
