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
	public class DestructionVolumeComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<DestructionVolumeData> DestructionVolumeData { get; set; } = new CtrRef<DestructionVolumeData>(); // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3546689379:
					DestructionVolumeData = (CtrRef<DestructionVolumeData>) p_Value;
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
				case 3546689379:
					return DestructionVolumeData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3546689379:
					return typeof(DestructionVolumeComponentData).GetProperty(nameof(DestructionVolumeData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
