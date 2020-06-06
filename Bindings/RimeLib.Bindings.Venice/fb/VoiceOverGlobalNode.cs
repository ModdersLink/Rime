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
	public class VoiceOverGlobalNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValue> Value { get; set; } = new CtrRef<VoiceOverValue>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<VoiceOverNamedValue> Field { get; set; } = new CtrRef<VoiceOverNamedValue>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<VoiceOverObject> Object { get; set; } = new CtrRef<VoiceOverObject>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 206678151:
					Field = (CtrRef<VoiceOverNamedValue>) p_Value;
					break;

				case 2866508144:
					Object = (CtrRef<VoiceOverObject>) p_Value;
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
				case 225375086:
					return Value;

				case 206678151:
					return Field;

				case 2866508144:
					return Object;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return typeof(VoiceOverGlobalNode).GetProperty(nameof(Value));

				case 206678151:
					return typeof(VoiceOverGlobalNode).GetProperty(nameof(Field));

				case 2866508144:
					return typeof(VoiceOverGlobalNode).GetProperty(nameof(Object));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
