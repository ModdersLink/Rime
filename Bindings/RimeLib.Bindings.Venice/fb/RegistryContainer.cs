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
	public class RegistryContainer : 
		DataContainer
	{
		[ContainerField(8)]
		public RefArray<DataContainer> EntityRegistry { get; set; } = new RefArray<DataContainer>(); // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<DataContainer> AssetRegistry { get; set; } = new RefArray<DataContainer>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<DataContainer> BlueprintRegistry { get; set; } = new RefArray<DataContainer>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<DataContainer> ReferenceObjectRegistry { get; set; } = new RefArray<DataContainer>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 398962539:
					EntityRegistry = (RefArray<DataContainer>) p_Value;
					break;

				case 3305796672:
					AssetRegistry = (RefArray<DataContainer>) p_Value;
					break;

				case 3531202111:
					BlueprintRegistry = (RefArray<DataContainer>) p_Value;
					break;

				case 1248214958:
					ReferenceObjectRegistry = (RefArray<DataContainer>) p_Value;
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
				case 398962539:
					return EntityRegistry;

				case 3305796672:
					return AssetRegistry;

				case 3531202111:
					return BlueprintRegistry;

				case 1248214958:
					return ReferenceObjectRegistry;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 398962539:
					return typeof(RegistryContainer).GetProperty(nameof(EntityRegistry));

				case 3305796672:
					return typeof(RegistryContainer).GetProperty(nameof(AssetRegistry));

				case 3531202111:
					return typeof(RegistryContainer).GetProperty(nameof(BlueprintRegistry));

				case 1248214958:
					return typeof(RegistryContainer).GetProperty(nameof(ReferenceObjectRegistry));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
