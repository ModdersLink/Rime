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
	public class EntityVoiceOverInfo : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverObject> VoiceOverType { get; set; } = new CtrRef<VoiceOverObject>(); // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<VoiceOverLabel> Labels { get; set; } = new RefArray<VoiceOverLabel>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1260359781:
					VoiceOverType = (CtrRef<VoiceOverObject>) p_Value;
					break;

				case 2902520752:
					Labels = (RefArray<VoiceOverLabel>) p_Value;
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
				case 1260359781:
					return VoiceOverType;

				case 2902520752:
					return Labels;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1260359781:
					return typeof(EntityVoiceOverInfo).GetProperty(nameof(VoiceOverType));

				case 2902520752:
					return typeof(EntityVoiceOverInfo).GetProperty(nameof(Labels));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
