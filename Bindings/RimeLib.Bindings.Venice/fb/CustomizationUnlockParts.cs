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
	public class CustomizationUnlockParts : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string UICategorySid { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<UnlockAssetBase> SelectableUnlocks { get; set; } = new RefArray<UnlockAssetBase>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 795269975:
					UICategorySid = (string) p_Value;
					break;

				case 1920005412:
					SelectableUnlocks = (RefArray<UnlockAssetBase>) p_Value;
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
				case 795269975:
					return UICategorySid;

				case 1920005412:
					return SelectableUnlocks;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 795269975:
					return typeof(CustomizationUnlockParts).GetProperty(nameof(UICategorySid));

				case 1920005412:
					return typeof(CustomizationUnlockParts).GetProperty(nameof(SelectableUnlocks));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
