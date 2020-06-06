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
    [ContainerType(4)]
	public class VoiceOverArithmeticNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValueConnection> A { get; set; } = new CtrRef<VoiceOverValueConnection>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<VoiceOverValueConnection> B { get; set; } = new CtrRef<VoiceOverValueConnection>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<VoiceOverValue> Result { get; set; } = new CtrRef<VoiceOverValue>(); // 0x10 (16)
		
		[ContainerField(20)]
		public VoiceOverArithmeticExpressionType Operation { get; set; } = new VoiceOverArithmeticExpressionType(); // 0x14 (20)
		
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
