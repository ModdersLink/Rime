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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class DefaultSelectionItem : FrostbiteContainer
	{
		[ContainerField(Name: "DefaultSelectionQuery", Offset: 0, NameHash: 3074304548, Flags: 41)]
		public UIDataSourceInfo DefaultSelectionQuery { get; set; } = new UIDataSourceInfo(); // 0x0 (0)
		
		[ContainerField(Name: "DefaultSelectionIndex", Offset: 16, NameHash: 3046460336, Flags: 49405), LayoutImmutable, Blittable]
		public int DefaultSelectionIndex { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3074304548:
					DefaultSelectionQuery = (UIDataSourceInfo) p_Value;
					break;

				case 3046460336:
					DefaultSelectionIndex = (int) p_Value;
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
				case 3074304548:
					return DefaultSelectionQuery;

				case 3046460336:
					return DefaultSelectionIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3074304548:
					return typeof(DefaultSelectionItem).GetProperty(nameof(DefaultSelectionQuery));

				case 3046460336:
					return typeof(DefaultSelectionItem).GetProperty(nameof(DefaultSelectionIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
