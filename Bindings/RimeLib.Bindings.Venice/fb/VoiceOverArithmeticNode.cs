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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class VoiceOverArithmeticNode : 
		VoiceOverExpressionNode
	{
		protected CtrRef<VoiceOverValueConnection> m_A = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(Name: "A", Offset: 8, NameHash: 177636, Flags: 53)]
		public CtrRef<VoiceOverValueConnection> A { get { return m_A; } set { if (OnPropertyChanging("VoiceOverArithmeticNode." + nameof(A), this, m_A, value)) m_A = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValueConnection> m_B = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(Name: "B", Offset: 12, NameHash: 177639, Flags: 53)]
		public CtrRef<VoiceOverValueConnection> B { get { return m_B; } set { if (OnPropertyChanging("VoiceOverArithmeticNode." + nameof(B), this, m_B, value)) m_B = value; } } // 0xC (12)
		
		protected CtrRef<VoiceOverValue> m_Result = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "Result", Offset: 16, NameHash: 3293273164, Flags: 53)]
		public CtrRef<VoiceOverValue> Result { get { return m_Result; } set { if (OnPropertyChanging("VoiceOverArithmeticNode." + nameof(Result), this, m_Result, value)) m_Result = value; } } // 0x10 (16)
		
		protected VoiceOverArithmeticExpressionType m_Operation = new VoiceOverArithmeticExpressionType();
		[ContainerField(Name: "Operation", Offset: 20, NameHash: 2346271248, Flags: 137)]
		public VoiceOverArithmeticExpressionType Operation { get { return m_Operation; } set { if (OnPropertyChanging("VoiceOverArithmeticNode." + nameof(Operation), this, m_Operation, value)) m_Operation = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177636:
					A = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 177639:
					B = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 3293273164:
					Result = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 2346271248:
					Operation = (VoiceOverArithmeticExpressionType) Enum.ToObject(typeof(VoiceOverArithmeticExpressionType), p_Value);
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
				case 177636:
					return A;

				case 177639:
					return B;

				case 3293273164:
					return Result;

				case 2346271248:
					return Operation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177636:
					return typeof(VoiceOverArithmeticNode).GetProperty(nameof(A));

				case 177639:
					return typeof(VoiceOverArithmeticNode).GetProperty(nameof(B));

				case 3293273164:
					return typeof(VoiceOverArithmeticNode).GetProperty(nameof(Result));

				case 2346271248:
					return typeof(VoiceOverArithmeticNode).GetProperty(nameof(Operation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
