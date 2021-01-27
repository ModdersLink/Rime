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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 84)]
	public class UINestedListDataBinding : 
		UIDataBinding
	{
		protected int m_ListIndex = new int();
		[ContainerField(Name: "ListIndex", Offset: 8, NameHash: 102126553, Flags: 49405), LayoutImmutable, Blittable]
		public int ListIndex { get { return m_ListIndex; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(ListIndex), this, m_ListIndex, value)) m_ListIndex = value; } } // 0x8 (8)
		
		protected List<NestedList> m_NestedLists = new List<NestedList>();
		[ContainerField(Name: "NestedLists", Offset: 12, NameHash: 4213273, Flags: 65)]
		public List<NestedList> NestedLists { get { return m_NestedLists; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(NestedLists), this, m_NestedLists, value)) m_NestedLists = value; } } // 0xC (12)
		
		protected int m_RowSpacing = new int();
		[ContainerField(Name: "RowSpacing", Offset: 16, NameHash: 3371971726, Flags: 49405), LayoutImmutable, Blittable]
		public int RowSpacing { get { return m_RowSpacing; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(RowSpacing), this, m_RowSpacing, value)) m_RowSpacing = value; } } // 0x10 (16)
		
		protected DefaultSelectionItem m_DefaultHighlightedRow = new DefaultSelectionItem();
		[ContainerField(Name: "DefaultHighlightedRow", Offset: 20, NameHash: 3059833365, Flags: 41)]
		public DefaultSelectionItem DefaultHighlightedRow { get { return m_DefaultHighlightedRow; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(DefaultHighlightedRow), this, m_DefaultHighlightedRow, value)) m_DefaultHighlightedRow = value; } } // 0x14 (20)
		
		protected UIListNavigationType m_NavigationType = new UIListNavigationType();
		[ContainerField(Name: "NavigationType", Offset: 40, NameHash: 3962792471, Flags: 137)]
		public UIListNavigationType NavigationType { get { return m_NavigationType; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(NavigationType), this, m_NavigationType, value)) m_NavigationType = value; } } // 0x28 (40)
		
		protected UIListRowType m_RowType = new UIListRowType();
		[ContainerField(Name: "RowType", Offset: 44, NameHash: 1700793143, Flags: 137)]
		public UIListRowType RowType { get { return m_RowType; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(RowType), this, m_RowType, value)) m_RowType = value; } } // 0x2C (44)
		
		protected UIListEmptyRowType m_EmptyRowType = new UIListEmptyRowType();
		[ContainerField(Name: "EmptyRowType", Offset: 48, NameHash: 3029081730, Flags: 137)]
		public UIListEmptyRowType EmptyRowType { get { return m_EmptyRowType; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(EmptyRowType), this, m_EmptyRowType, value)) m_EmptyRowType = value; } } // 0x30 (48)
		
		protected int m_SelectorWidth = new int();
		[ContainerField(Name: "SelectorWidth", Offset: 52, NameHash: 595342646, Flags: 49405), LayoutImmutable, Blittable]
		public int SelectorWidth { get { return m_SelectorWidth; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(SelectorWidth), this, m_SelectorWidth, value)) m_SelectorWidth = value; } } // 0x34 (52)
		
		protected UIDataSourceInfo m_Visibility = new UIDataSourceInfo();
		[ContainerField(Name: "Visibility", Offset: 56, NameHash: 1708270083, Flags: 41)]
		public UIDataSourceInfo Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x38 (56)
		
		protected bool m_SendIndexWithEvent = new bool();
		[ContainerField(Name: "SendIndexWithEvent", Offset: 72, NameHash: 936991273, Flags: 49325), LayoutImmutable, Blittable]
		public bool SendIndexWithEvent { get { return m_SendIndexWithEvent; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(SendIndexWithEvent), this, m_SendIndexWithEvent, value)) m_SendIndexWithEvent = value; } } // 0x48 (72)
		
		protected bool m_UseScrollBar = new bool();
		[ContainerField(Name: "UseScrollBar", Offset: 73, NameHash: 900221658, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseScrollBar { get { return m_UseScrollBar; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(UseScrollBar), this, m_UseScrollBar, value)) m_UseScrollBar = value; } } // 0x49 (73)
		
		protected bool m_DataIncludesButtonLayout = new bool();
		[ContainerField(Name: "DataIncludesButtonLayout", Offset: 74, NameHash: 4158288630, Flags: 49325), LayoutImmutable, Blittable]
		public bool DataIncludesButtonLayout { get { return m_DataIncludesButtonLayout; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(DataIncludesButtonLayout), this, m_DataIncludesButtonLayout, value)) m_DataIncludesButtonLayout = value; } } // 0x4A (74)
		
		protected bool m_ClearListAtNavigationEvent = new bool();
		[ContainerField(Name: "ClearListAtNavigationEvent", Offset: 75, NameHash: 1717286605, Flags: 49325), LayoutImmutable, Blittable]
		public bool ClearListAtNavigationEvent { get { return m_ClearListAtNavigationEvent; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(ClearListAtNavigationEvent), this, m_ClearListAtNavigationEvent, value)) m_ClearListAtNavigationEvent = value; } } // 0x4B (75)
		
		protected bool m_Use3DSelection = new bool();
		[ContainerField(Name: "Use3DSelection", Offset: 76, NameHash: 3486139089, Flags: 49325), LayoutImmutable, Blittable]
		public bool Use3DSelection { get { return m_Use3DSelection; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(Use3DSelection), this, m_Use3DSelection, value)) m_Use3DSelection = value; } } // 0x4C (76)
		
		protected bool m_InvertVisible = new bool();
		[ContainerField(Name: "InvertVisible", Offset: 77, NameHash: 301381369, Flags: 49325), LayoutImmutable, Blittable]
		public bool InvertVisible { get { return m_InvertVisible; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(InvertVisible), this, m_InvertVisible, value)) m_InvertVisible = value; } } // 0x4D (77)
		
		protected bool m_Visible = new bool();
		[ContainerField(Name: "Visible", Offset: 78, NameHash: 901540267, Flags: 49325), LayoutImmutable, Blittable]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x4E (78)
		
		protected bool m_ScreenRotationEnabled = new bool();
		[ContainerField(Name: "ScreenRotationEnabled", Offset: 79, NameHash: 3744685560, Flags: 49325), LayoutImmutable, Blittable]
		public bool ScreenRotationEnabled { get { return m_ScreenRotationEnabled; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(ScreenRotationEnabled), this, m_ScreenRotationEnabled, value)) m_ScreenRotationEnabled = value; } } // 0x4F (79)
		
		protected bool m_HighLightOnUpdate = new bool();
		[ContainerField(Name: "HighLightOnUpdate", Offset: 80, NameHash: 2774529029, Flags: 49325), LayoutImmutable, Blittable]
		public bool HighLightOnUpdate { get { return m_HighLightOnUpdate; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(HighLightOnUpdate), this, m_HighLightOnUpdate, value)) m_HighLightOnUpdate = value; } } // 0x50 (80)
		
		protected bool m_KeepScrollOffset = new bool();
		[ContainerField(Name: "KeepScrollOffset", Offset: 81, NameHash: 983569566, Flags: 49325), LayoutImmutable, Blittable]
		public bool KeepScrollOffset { get { return m_KeepScrollOffset; } set { if (OnPropertyChanging("UINestedListDataBinding." + nameof(KeepScrollOffset), this, m_KeepScrollOffset, value)) m_KeepScrollOffset = value; } } // 0x51 (81)
		
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
