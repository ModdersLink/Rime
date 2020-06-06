///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIBundlesAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<UIBundleAssetState> UIBundleAssetStateList { get; set; } = new List<UIBundleAssetState>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3131409800:
					UIBundleAssetStateList = (List<UIBundleAssetState>) p_Value;
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
				case 3131409800:
					return UIBundleAssetStateList;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3131409800:
					return typeof(UIBundlesAsset).GetProperty(nameof(UIBundleAssetStateList));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
