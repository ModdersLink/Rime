///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class UIBundlesAsset : 
		Asset
	{
		protected List<UIBundleAssetState> m_UIBundleAssetStateList = new List<UIBundleAssetState>();
		[ContainerField(Name: "UIBundleAssetStateList", Offset: 12, NameHash: 3131409800, Flags: 65)]
		public List<UIBundleAssetState> UIBundleAssetStateList { get { return m_UIBundleAssetStateList; } set { if (OnPropertyChanging("UIBundlesAsset." + nameof(UIBundleAssetStateList), this, m_UIBundleAssetStateList, value)) m_UIBundleAssetStateList = value; } } // 0xC (12)
		
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
