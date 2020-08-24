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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class NestedList : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string Label { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string Index { get; set; } // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(41)]
		public UIDataSourceInfo ListDataSource { get; set; } = new UIDataSourceInfo(); // 0x8 (8)
		
		[ContainerField(24), MemberInfoFlag(41)]
		public UIDataSourceInfo DynamicShowList { get; set; } = new UIDataSourceInfo(); // 0x18 (24)
		
		[ContainerField(40), MemberInfoFlag(65), ContainerArray]
		public List<string> StaticItems { get; set; } = new List<string>(); // 0x28 (40)
		
		[ContainerField(44), MemberInfoFlag(41)]
		public DefaultSelectionItem DefaultHighlighted { get; set; } = new DefaultSelectionItem(); // 0x2C (44)
		
		[ContainerField(64), MemberInfoFlag(137)]
		public UIListRowType RowType { get; set; } = new UIListRowType(); // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool UseAsNormalListRows { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool HiddenOnPC { get; set; } // 0x45 (69)
		
		[ContainerField(70), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool HiddenOnXenon { get; set; } // 0x46 (70)
		
		[ContainerField(71), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool HighLightOnUpdate { get; set; } // 0x47 (71)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 218105699:
					Label = (string) p_Value;
					break;

				case 214509467:
					Index = (string) p_Value;
					break;

				case 1537495466:
					ListDataSource = (UIDataSourceInfo) p_Value;
					break;

				case 3565414705:
					DynamicShowList = (UIDataSourceInfo) p_Value;
					break;

				case 2586461275:
					StaticItems = (List<string>) p_Value;
					break;

				case 2153962783:
					DefaultHighlighted = (DefaultSelectionItem) p_Value;
					break;

				case 1700793143:
						RowType = (UIListRowType) Enum.ToObject(typeof(UIListRowType), p_Value);
					break;

				case 2244616668:
					UseAsNormalListRows = (bool) p_Value;
					break;

				case 3546601373:
					HiddenOnPC = (bool) p_Value;
					break;

				case 1050741724:
					HiddenOnXenon = (bool) p_Value;
					break;

				case 2774529029:
					HighLightOnUpdate = (bool) p_Value;
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
				case 218105699:
					return Label;

				case 214509467:
					return Index;

				case 1537495466:
					return ListDataSource;

				case 3565414705:
					return DynamicShowList;

				case 2586461275:
					return StaticItems;

				case 2153962783:
					return DefaultHighlighted;

				case 1700793143:
					return RowType;

				case 2244616668:
					return UseAsNormalListRows;

				case 3546601373:
					return HiddenOnPC;

				case 1050741724:
					return HiddenOnXenon;

				case 2774529029:
					return HighLightOnUpdate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 218105699:
					return typeof(NestedList).GetProperty(nameof(Label));

				case 214509467:
					return typeof(NestedList).GetProperty(nameof(Index));

				case 1537495466:
					return typeof(NestedList).GetProperty(nameof(ListDataSource));

				case 3565414705:
					return typeof(NestedList).GetProperty(nameof(DynamicShowList));

				case 2586461275:
					return typeof(NestedList).GetProperty(nameof(StaticItems));

				case 2153962783:
					return typeof(NestedList).GetProperty(nameof(DefaultHighlighted));

				case 1700793143:
					return typeof(NestedList).GetProperty(nameof(RowType));

				case 2244616668:
					return typeof(NestedList).GetProperty(nameof(UseAsNormalListRows));

				case 3546601373:
					return typeof(NestedList).GetProperty(nameof(HiddenOnPC));

				case 1050741724:
					return typeof(NestedList).GetProperty(nameof(HiddenOnXenon));

				case 2774529029:
					return typeof(NestedList).GetProperty(nameof(HighLightOnUpdate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
