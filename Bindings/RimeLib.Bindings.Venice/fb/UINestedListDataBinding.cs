///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UINestedListDataBinding : 
		UIDataBinding
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int ListIndex { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public List<NestedList> NestedLists { get; set; } = new List<NestedList>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int RowSpacing { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public DefaultSelectionItem DefaultHighlightedRow { get; set; } = new DefaultSelectionItem(); // 0x14 (20)
		
		[ContainerField(40)]
		public UIListNavigationType NavigationType { get; set; } = new UIListNavigationType(); // 0x28 (40)
		
		[ContainerField(44)]
		public UIListRowType RowType { get; set; } = new UIListRowType(); // 0x2C (44)
		
		[ContainerField(48)]
		public UIListEmptyRowType EmptyRowType { get; set; } = new UIListEmptyRowType(); // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public int SelectorWidth { get; set; } // 0x34 (52)
		
		[ContainerField(56)]
		public UIDataSourceInfo Visibility { get; set; } = new UIDataSourceInfo(); // 0x38 (56)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool SendIndexWithEvent { get; set; } // 0x48 (72)
		
		[ContainerField(73), LayoutImmutable, Blittable]
		public bool UseScrollBar { get; set; } // 0x49 (73)
		
		[ContainerField(74), LayoutImmutable, Blittable]
		public bool DataIncludesButtonLayout { get; set; } // 0x4A (74)
		
		[ContainerField(75), LayoutImmutable, Blittable]
		public bool ClearListAtNavigationEvent { get; set; } // 0x4B (75)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public bool Use3DSelection { get; set; } // 0x4C (76)
		
		[ContainerField(77), LayoutImmutable, Blittable]
		public bool InvertVisible { get; set; } // 0x4D (77)
		
		[ContainerField(78), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x4E (78)
		
		[ContainerField(79), LayoutImmutable, Blittable]
		public bool ScreenRotationEnabled { get; set; } // 0x4F (79)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public bool HighLightOnUpdate { get; set; } // 0x50 (80)
		
		[ContainerField(81), LayoutImmutable, Blittable]
		public bool KeepScrollOffset { get; set; } // 0x51 (81)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 102126553:
					ListIndex = (int) p_Value;
					break;

				case 4213273:
					NestedLists = (List<NestedList>) p_Value;
					break;

				case 3371971726:
					RowSpacing = (int) p_Value;
					break;

				case 3059833365:
					DefaultHighlightedRow = (DefaultSelectionItem) p_Value;
					break;

				case 3962792471:
					NavigationType = (UIListNavigationType) Enum.ToObject(typeof(UIListNavigationType), p_Value);
					break;

				case 1700793143:
					RowType = (UIListRowType) Enum.ToObject(typeof(UIListRowType), p_Value);
					break;

				case 3029081730:
					EmptyRowType = (UIListEmptyRowType) Enum.ToObject(typeof(UIListEmptyRowType), p_Value);
					break;

				case 595342646:
					SelectorWidth = (int) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 936991273:
					SendIndexWithEvent = (bool) p_Value;
					break;

				case 900221658:
					UseScrollBar = (bool) p_Value;
					break;

				case 4158288630:
					DataIncludesButtonLayout = (bool) p_Value;
					break;

				case 1717286605:
					ClearListAtNavigationEvent = (bool) p_Value;
					break;

				case 3486139089:
					Use3DSelection = (bool) p_Value;
					break;

				case 301381369:
					InvertVisible = (bool) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
					break;

				case 3744685560:
					ScreenRotationEnabled = (bool) p_Value;
					break;

				case 2774529029:
					HighLightOnUpdate = (bool) p_Value;
					break;

				case 983569566:
					KeepScrollOffset = (bool) p_Value;
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
				case 102126553:
					return ListIndex;

				case 4213273:
					return NestedLists;

				case 3371971726:
					return RowSpacing;

				case 3059833365:
					return DefaultHighlightedRow;

				case 3962792471:
					return NavigationType;

				case 1700793143:
					return RowType;

				case 3029081730:
					return EmptyRowType;

				case 595342646:
					return SelectorWidth;

				case 1708270083:
					return Visibility;

				case 936991273:
					return SendIndexWithEvent;

				case 900221658:
					return UseScrollBar;

				case 4158288630:
					return DataIncludesButtonLayout;

				case 1717286605:
					return ClearListAtNavigationEvent;

				case 3486139089:
					return Use3DSelection;

				case 301381369:
					return InvertVisible;

				case 901540267:
					return Visible;

				case 3744685560:
					return ScreenRotationEnabled;

				case 2774529029:
					return HighLightOnUpdate;

				case 983569566:
					return KeepScrollOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 102126553:
					return typeof(UINestedListDataBinding).GetProperty(nameof(ListIndex));

				case 4213273:
					return typeof(UINestedListDataBinding).GetProperty(nameof(NestedLists));

				case 3371971726:
					return typeof(UINestedListDataBinding).GetProperty(nameof(RowSpacing));

				case 3059833365:
					return typeof(UINestedListDataBinding).GetProperty(nameof(DefaultHighlightedRow));

				case 3962792471:
					return typeof(UINestedListDataBinding).GetProperty(nameof(NavigationType));

				case 1700793143:
					return typeof(UINestedListDataBinding).GetProperty(nameof(RowType));

				case 3029081730:
					return typeof(UINestedListDataBinding).GetProperty(nameof(EmptyRowType));

				case 595342646:
					return typeof(UINestedListDataBinding).GetProperty(nameof(SelectorWidth));

				case 1708270083:
					return typeof(UINestedListDataBinding).GetProperty(nameof(Visibility));

				case 936991273:
					return typeof(UINestedListDataBinding).GetProperty(nameof(SendIndexWithEvent));

				case 900221658:
					return typeof(UINestedListDataBinding).GetProperty(nameof(UseScrollBar));

				case 4158288630:
					return typeof(UINestedListDataBinding).GetProperty(nameof(DataIncludesButtonLayout));

				case 1717286605:
					return typeof(UINestedListDataBinding).GetProperty(nameof(ClearListAtNavigationEvent));

				case 3486139089:
					return typeof(UINestedListDataBinding).GetProperty(nameof(Use3DSelection));

				case 301381369:
					return typeof(UINestedListDataBinding).GetProperty(nameof(InvertVisible));

				case 901540267:
					return typeof(UINestedListDataBinding).GetProperty(nameof(Visible));

				case 3744685560:
					return typeof(UINestedListDataBinding).GetProperty(nameof(ScreenRotationEnabled));

				case 2774529029:
					return typeof(UINestedListDataBinding).GetProperty(nameof(HighLightOnUpdate));

				case 983569566:
					return typeof(UINestedListDataBinding).GetProperty(nameof(KeepScrollOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
