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
	public class NFSUIListDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Refresh { get; set; } = new UIDataSourceInfo(); // 0x8 (8)
		
		[ContainerField(24)]
		public List<UIListItem> Items { get; set; } = new List<UIListItem>(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1327541432:
					Refresh = (UIDataSourceInfo) p_Value;
					break;

				case 215446531:
					Items = (List<UIListItem>) p_Value;
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
				case 1327541432:
					return Refresh;

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
				case 1327541432:
					return typeof(NFSUIListDataBinding).GetProperty(nameof(Refresh));

				case 215446531:
					return typeof(NFSUIListDataBinding).GetProperty(nameof(Items));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
