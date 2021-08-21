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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class BlueprintBundleMetadataContainer : 
		Asset
	{
		protected RefArray<BlueprintContainerItem> m_Items = new RefArray<BlueprintContainerItem>();
		[ContainerField(Name: "Items", Offset: 12, NameHash: 215446531, Flags: 65)]
		public RefArray<BlueprintContainerItem> Items { get { return m_Items; } set { if (OnPropertyChanging("BlueprintBundleMetadataContainer." + nameof(Items), this, m_Items, value)) m_Items = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 215446531:
					Items = (RefArray<BlueprintContainerItem>) p_Value;
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
				case 215446531:
					return Items;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 215446531:
					return typeof(BlueprintBundleMetadataContainer).GetProperty(nameof(Items));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
