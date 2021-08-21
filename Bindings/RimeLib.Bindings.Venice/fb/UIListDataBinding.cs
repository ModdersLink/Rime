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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 104)]
	public class UIListDataBinding : 
		UIDataBinding
	{
		protected int m_ListIndex = new int();
		[ContainerField(Name: "ListIndex", Offset: 8, NameHash: 102126553, Flags: 49405), LayoutImmutable, Blittable]
		public int ListIndex { get { return m_ListIndex; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(ListIndex), this, m_ListIndex, value)) m_ListIndex = value; } } // 0x8 (8)
		
		protected UIDataSourceInfo m_ListQuery = new UIDataSourceInfo();
		[ContainerField(Name: "ListQuery", Offset: 12, NameHash: 111226701, Flags: 41)]
		public UIDataSourceInfo ListQuery { get { return m_ListQuery; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(ListQuery), this, m_ListQuery, value)) m_ListQuery = value; } } // 0xC (12)
		
		protected List<StaticListItem> m_StaticItems = new List<StaticListItem>();
		[ContainerField(Name: "StaticItems", Offset: 28, NameHash: 2586461275, Flags: 65)]
		public List<StaticListItem> StaticItems { get { return m_StaticItems; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(StaticItems), this, m_StaticItems, value)) m_StaticItems = value; } } // 0x1C (28)
		
		protected UIListEmptyRowType m_EmptyRowType = new UIListEmptyRowType();
		[ContainerField(Name: "EmptyRowType", Offset: 32, NameHash: 3029081730, Flags: 137)]
		public UIListEmptyRowType EmptyRowType { get { return m_EmptyRowType; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(EmptyRowType), this, m_EmptyRowType, value)) m_EmptyRowType = value; } } // 0x20 (32)
		
		protected DefaultSelectionItem m_DefaultHighlightedRow = new DefaultSelectionItem();
		[ContainerField(Name: "DefaultHighlightedRow", Offset: 36, NameHash: 3059833365, Flags: 41)]
		public DefaultSelectionItem DefaultHighlightedRow { get { return m_DefaultHighlightedRow; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(DefaultHighlightedRow), this, m_DefaultHighlightedRow, value)) m_DefaultHighlightedRow = value; } } // 0x24 (36)
		
		protected UIListRowType m_RowType = new UIListRowType();
		[ContainerField(Name: "RowType", Offset: 56, NameHash: 1700793143, Flags: 137)]
		public UIListRowType RowType { get { return m_RowType; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(RowType), this, m_RowType, value)) m_RowType = value; } } // 0x38 (56)
		
		protected UIListNavigationType m_NavigationType = new UIListNavigationType();
		[ContainerField(Name: "NavigationType", Offset: 60, NameHash: 3962792471, Flags: 137)]
		public UIListNavigationType NavigationType { get { return m_NavigationType; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(NavigationType), this, m_NavigationType, value)) m_NavigationType = value; } } // 0x3C (60)
		
		protected UIDataSourceInfo m_NavigationTypeSource = new UIDataSourceInfo();
		[ContainerField(Name: "NavigationTypeSource", Offset: 64, NameHash: 3478726026, Flags: 41)]
		public UIDataSourceInfo NavigationTypeSource { get { return m_NavigationTypeSource; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(NavigationTypeSource), this, m_NavigationTypeSource, value)) m_NavigationTypeSource = value; } } // 0x40 (64)
		
		protected int m_RowSpacing = new int();
		[ContainerField(Name: "RowSpacing", Offset: 80, NameHash: 3371971726, Flags: 49405), LayoutImmutable, Blittable]
		public int RowSpacing { get { return m_RowSpacing; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(RowSpacing), this, m_RowSpacing, value)) m_RowSpacing = value; } } // 0x50 (80)
		
		protected UIListUnFocusMode m_UnFocusMode = new UIListUnFocusMode();
		[ContainerField(Name: "UnFocusMode", Offset: 84, NameHash: 385936785, Flags: 137)]
		public UIListUnFocusMode UnFocusMode { get { return m_UnFocusMode; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(UnFocusMode), this, m_UnFocusMode, value)) m_UnFocusMode = value; } } // 0x54 (84)
		
		protected string m_DisabledRows = string.Empty;
		[ContainerField(Name: "DisabledRows", Offset: 88, NameHash: 3598316716, Flags: 16509), LayoutImmutable]
		public string DisabledRows { get { return m_DisabledRows; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(DisabledRows), this, m_DisabledRows, value)) m_DisabledRows = value; } } // 0x58 (88)
		
		protected bool m_ClearListAtNavigationEvent = new bool();
		[ContainerField(Name: "ClearListAtNavigationEvent", Offset: 92, NameHash: 1717286605, Flags: 49325), LayoutImmutable, Blittable]
		public bool ClearListAtNavigationEvent { get { return m_ClearListAtNavigationEvent; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(ClearListAtNavigationEvent), this, m_ClearListAtNavigationEvent, value)) m_ClearListAtNavigationEvent = value; } } // 0x5C (92)
		
		protected bool m_SendIndexWithEvent = new bool();
		[ContainerField(Name: "SendIndexWithEvent", Offset: 93, NameHash: 936991273, Flags: 49325), LayoutImmutable, Blittable]
		public bool SendIndexWithEvent { get { return m_SendIndexWithEvent; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(SendIndexWithEvent), this, m_SendIndexWithEvent, value)) m_SendIndexWithEvent = value; } } // 0x5D (93)
		
		protected bool m_ScreenRotationEnabled = new bool();
		[ContainerField(Name: "ScreenRotationEnabled", Offset: 94, NameHash: 3744685560, Flags: 49325), LayoutImmutable, Blittable]
		public bool ScreenRotationEnabled { get { return m_ScreenRotationEnabled; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(ScreenRotationEnabled), this, m_ScreenRotationEnabled, value)) m_ScreenRotationEnabled = value; } } // 0x5E (94)
		
		protected bool m_Use3DSelection = new bool();
		[ContainerField(Name: "Use3DSelection", Offset: 95, NameHash: 3486139089, Flags: 49325), LayoutImmutable, Blittable]
		public bool Use3DSelection { get { return m_Use3DSelection; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(Use3DSelection), this, m_Use3DSelection, value)) m_Use3DSelection = value; } } // 0x5F (95)
		
		protected bool m_FireHighlightOnMouseOut = new bool();
		[ContainerField(Name: "FireHighlightOnMouseOut", Offset: 96, NameHash: 1186215811, Flags: 49325), LayoutImmutable, Blittable]
		public bool FireHighlightOnMouseOut { get { return m_FireHighlightOnMouseOut; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(FireHighlightOnMouseOut), this, m_FireHighlightOnMouseOut, value)) m_FireHighlightOnMouseOut = value; } } // 0x60 (96)
		
		protected bool m_DataIncludesButtonLayout = new bool();
		[ContainerField(Name: "DataIncludesButtonLayout", Offset: 97, NameHash: 4158288630, Flags: 49325), LayoutImmutable, Blittable]
		public bool DataIncludesButtonLayout { get { return m_DataIncludesButtonLayout; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(DataIncludesButtonLayout), this, m_DataIncludesButtonLayout, value)) m_DataIncludesButtonLayout = value; } } // 0x61 (97)
		
		protected bool m_Visible = new bool();
		[ContainerField(Name: "Visible", Offset: 98, NameHash: 901540267, Flags: 49325), LayoutImmutable, Blittable]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x62 (98)
		
		protected bool m_SpinnerEnabled = new bool();
		[ContainerField(Name: "SpinnerEnabled", Offset: 99, NameHash: 3928778749, Flags: 49325), LayoutImmutable, Blittable]
		public bool SpinnerEnabled { get { return m_SpinnerEnabled; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(SpinnerEnabled), this, m_SpinnerEnabled, value)) m_SpinnerEnabled = value; } } // 0x63 (99)
		
		protected bool m_UseScrollBar = new bool();
		[ContainerField(Name: "UseScrollBar", Offset: 100, NameHash: 900221658, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseScrollBar { get { return m_UseScrollBar; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(UseScrollBar), this, m_UseScrollBar, value)) m_UseScrollBar = value; } } // 0x64 (100)
		
		protected bool m_HighLightOnUpdate = new bool();
		[ContainerField(Name: "HighLightOnUpdate", Offset: 101, NameHash: 2774529029, Flags: 49325), LayoutImmutable, Blittable]
		public bool HighLightOnUpdate { get { return m_HighLightOnUpdate; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(HighLightOnUpdate), this, m_HighLightOnUpdate, value)) m_HighLightOnUpdate = value; } } // 0x65 (101)
		
		protected bool m_KeepScrollOffset = new bool();
		[ContainerField(Name: "KeepScrollOffset", Offset: 102, NameHash: 983569566, Flags: 49325), LayoutImmutable, Blittable]
		public bool KeepScrollOffset { get { return m_KeepScrollOffset; } set { if (OnPropertyChanging("UIListDataBinding." + nameof(KeepScrollOffset), this, m_KeepScrollOffset, value)) m_KeepScrollOffset = value; } } // 0x66 (102)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 102126553:
					ListIndex = (int) p_Value;
					break;

				case 111226701:
					ListQuery = (UIDataSourceInfo) p_Value;
					break;

				case 2586461275:
					StaticItems = (List<StaticListItem>) p_Value;
					break;

				case 3029081730:
					EmptyRowType = (UIListEmptyRowType) Enum.ToObject(typeof(UIListEmptyRowType), p_Value);
					break;

				case 3059833365:
					DefaultHighlightedRow = (DefaultSelectionItem) p_Value;
					break;

				case 1700793143:
					RowType = (UIListRowType) Enum.ToObject(typeof(UIListRowType), p_Value);
					break;

				case 3962792471:
					NavigationType = (UIListNavigationType) Enum.ToObject(typeof(UIListNavigationType), p_Value);
					break;

				case 3478726026:
					NavigationTypeSource = (UIDataSourceInfo) p_Value;
					break;

				case 3371971726:
					RowSpacing = (int) p_Value;
					break;

				case 385936785:
					UnFocusMode = (UIListUnFocusMode) Enum.ToObject(typeof(UIListUnFocusMode), p_Value);
					break;

				case 3598316716:
					DisabledRows = (string) p_Value;
					break;

				case 1717286605:
					ClearListAtNavigationEvent = (bool) p_Value;
					break;

				case 936991273:
					SendIndexWithEvent = (bool) p_Value;
					break;

				case 3744685560:
					ScreenRotationEnabled = (bool) p_Value;
					break;

				case 3486139089:
					Use3DSelection = (bool) p_Value;
					break;

				case 1186215811:
					FireHighlightOnMouseOut = (bool) p_Value;
					break;

				case 4158288630:
					DataIncludesButtonLayout = (bool) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
					break;

				case 3928778749:
					SpinnerEnabled = (bool) p_Value;
					break;

				case 900221658:
					UseScrollBar = (bool) p_Value;
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

				case 111226701:
					return ListQuery;

				case 2586461275:
					return StaticItems;

				case 3029081730:
					return EmptyRowType;

				case 3059833365:
					return DefaultHighlightedRow;

				case 1700793143:
					return RowType;

				case 3962792471:
					return NavigationType;

				case 3478726026:
					return NavigationTypeSource;

				case 3371971726:
					return RowSpacing;

				case 385936785:
					return UnFocusMode;

				case 3598316716:
					return DisabledRows;

				case 1717286605:
					return ClearListAtNavigationEvent;

				case 936991273:
					return SendIndexWithEvent;

				case 3744685560:
					return ScreenRotationEnabled;

				case 3486139089:
					return Use3DSelection;

				case 1186215811:
					return FireHighlightOnMouseOut;

				case 4158288630:
					return DataIncludesButtonLayout;

				case 901540267:
					return Visible;

				case 3928778749:
					return SpinnerEnabled;

				case 900221658:
					return UseScrollBar;

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
					return typeof(UIListDataBinding).GetProperty(nameof(ListIndex));

				case 111226701:
					return typeof(UIListDataBinding).GetProperty(nameof(ListQuery));

				case 2586461275:
					return typeof(UIListDataBinding).GetProperty(nameof(StaticItems));

				case 3029081730:
					return typeof(UIListDataBinding).GetProperty(nameof(EmptyRowType));

				case 3059833365:
					return typeof(UIListDataBinding).GetProperty(nameof(DefaultHighlightedRow));

				case 1700793143:
					return typeof(UIListDataBinding).GetProperty(nameof(RowType));

				case 3962792471:
					return typeof(UIListDataBinding).GetProperty(nameof(NavigationType));

				case 3478726026:
					return typeof(UIListDataBinding).GetProperty(nameof(NavigationTypeSource));

				case 3371971726:
					return typeof(UIListDataBinding).GetProperty(nameof(RowSpacing));

				case 385936785:
					return typeof(UIListDataBinding).GetProperty(nameof(UnFocusMode));

				case 3598316716:
					return typeof(UIListDataBinding).GetProperty(nameof(DisabledRows));

				case 1717286605:
					return typeof(UIListDataBinding).GetProperty(nameof(ClearListAtNavigationEvent));

				case 936991273:
					return typeof(UIListDataBinding).GetProperty(nameof(SendIndexWithEvent));

				case 3744685560:
					return typeof(UIListDataBinding).GetProperty(nameof(ScreenRotationEnabled));

				case 3486139089:
					return typeof(UIListDataBinding).GetProperty(nameof(Use3DSelection));

				case 1186215811:
					return typeof(UIListDataBinding).GetProperty(nameof(FireHighlightOnMouseOut));

				case 4158288630:
					return typeof(UIListDataBinding).GetProperty(nameof(DataIncludesButtonLayout));

				case 901540267:
					return typeof(UIListDataBinding).GetProperty(nameof(Visible));

				case 3928778749:
					return typeof(UIListDataBinding).GetProperty(nameof(SpinnerEnabled));

				case 900221658:
					return typeof(UIListDataBinding).GetProperty(nameof(UseScrollBar));

				case 2774529029:
					return typeof(UIListDataBinding).GetProperty(nameof(HighLightOnUpdate));

				case 983569566:
					return typeof(UIListDataBinding).GetProperty(nameof(KeepScrollOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
