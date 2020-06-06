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
	public class BlueprintBundle : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<Blueprint> Blueprint { get; set; } = new CtrRef<Blueprint>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<RegistryContainer> RegistryContainer { get; set; } = new CtrRef<RegistryContainer>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4232469066:
					Blueprint = (CtrRef<Blueprint>) p_Value;
					break;

				case 1535522391:
					RegistryContainer = (CtrRef<RegistryContainer>) p_Value;
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
				case 4232469066:
					return Blueprint;

				case 1535522391:
					return RegistryContainer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4232469066:
					return typeof(BlueprintBundle).GetProperty(nameof(Blueprint));

				case 1535522391:
					return typeof(BlueprintBundle).GetProperty(nameof(RegistryContainer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
