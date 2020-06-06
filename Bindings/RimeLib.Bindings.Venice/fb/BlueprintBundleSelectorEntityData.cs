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
	public class BlueprintBundleSelectorEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<SpawnEntitySelector> BlueprintSelector { get; set; } = new CtrRef<SpawnEntitySelector>(); // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4244087711:
					BlueprintSelector = (CtrRef<SpawnEntitySelector>) p_Value;
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
				case 4244087711:
					return BlueprintSelector;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4244087711:
					return typeof(BlueprintBundleSelectorEntityData).GetProperty(nameof(BlueprintSelector));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
