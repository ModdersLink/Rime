///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VoiceOverValueConnection : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverExpressionNode> TargetNode { get; set; } = new CtrRef<VoiceOverExpressionNode>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<VoiceOverValue> TargetValue { get; set; } = new CtrRef<VoiceOverValue>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 328873140:
					TargetNode = (CtrRef<VoiceOverExpressionNode>) p_Value;
					break;

				case 2234789535:
					TargetValue = (CtrRef<VoiceOverValue>) p_Value;
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
				case 328873140:
					return TargetNode;

				case 2234789535:
					return TargetValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 328873140:
					return typeof(VoiceOverValueConnection).GetProperty(nameof(TargetNode));

				case 2234789535:
					return typeof(VoiceOverValueConnection).GetProperty(nameof(TargetValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
