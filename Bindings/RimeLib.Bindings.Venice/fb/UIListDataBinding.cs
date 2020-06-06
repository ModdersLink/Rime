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
	public class UIListDataBinding : 
		UIDataBinding
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int ListIndex { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public UIDataSourceInfo ListQuery { get; set; } = new UIDataSourceInfo(); // 0xC (12)
		
		[ContainerField(28)]
		public List<StaticListItem> StaticItems { get; set; } = new List<StaticListItem>(); // 0x1C (28)
		
		[ContainerField(32)]
		public UIListEmptyRowType EmptyRowType { get; set; } = new UIListEmptyRowType(); // 0x20 (32)
		
		[ContainerField(36)]
		public DefaultSelectionItem DefaultHighlightedRow { get; set; } = new DefaultSelectionItem(); // 0x24 (36)
		
		[ContainerField(56)]
		public UIListRowType RowType { get; set; } = new UIListRowType(); // 0x38 (56)
		
		[ContainerField(60)]
		public UIListNavigationType NavigationType { get; set; } = new UIListNavigationType(); // 0x3C (60)
		
		[ContainerField(64)]
		public UIDataSourceInfo NavigationTypeSource { get; set; } = new UIDataSourceInfo(); // 0x40 (64)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public int RowSpacing { get; set; } // 0x50 (80)
		
		[ContainerField(84)]
		public UIListUnFocusMode UnFocusMode { get; set; } = new UIListUnFocusMode(); // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable]
		public string DisabledRows { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public bool ClearListAtNavigationEvent { get; set; } // 0x5C (92)
		
		[ContainerField(93), LayoutImmutable, Blittable]
		public bool SendIndexWithEvent { get; set; } // 0x5D (93)
		
		[ContainerField(94), LayoutImmutable, Blittable]
		public bool ScreenRotationEnabled { get; set; } // 0x5E (94)
		
		[ContainerField(95), LayoutImmutable, Blittable]
		public bool Use3DSelection { get; set; } // 0x5F (95)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool FireHighlightOnMouseOut { get; set; } // 0x60 (96)
		
		[ContainerField(97), LayoutImmutable, Blittable]
		public bool DataIncludesButtonLayout { get; set; } // 0x61 (97)
		
		[ContainerField(98), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x62 (98)
		
		[ContainerField(99), LayoutImmutable, Blittable]
		public bool SpinnerEnabled { get; set; } // 0x63 (99)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool UseScrollBar { get; set; } // 0x64 (100)
		
		[ContainerField(101), LayoutImmutable, Blittable]
		public bool HighLightOnUpdate { get; set; } // 0x65 (101)
		
		[ContainerField(102), LayoutImmutable, Blittable]
		public bool KeepScrollOffset { get; set; } // 0x66 (102)
		
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
