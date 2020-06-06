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
	public class BlueprintContainerItem : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<BlueprintBundleMetadata> Metadata { get; set; } = new CtrRef<BlueprintBundleMetadata>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1408720392:
					Metadata = (CtrRef<BlueprintBundleMetadata>) p_Value;
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
				case 1408720392:
					return Metadata;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1408720392:
					return typeof(BlueprintContainerItem).GetProperty(nameof(Metadata));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
