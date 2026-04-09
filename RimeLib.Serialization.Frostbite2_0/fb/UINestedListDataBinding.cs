///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 84)]
	public partial class UINestedListDataBinding :
		UIDataBinding
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private int _ListIndex;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<NestedList> _NestedLists = new();

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private int _RowSpacing;

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private DefaultSelectionItem _DefaultHighlightedRow = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private UIListNavigationType _NavigationType = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private UIListRowType _RowType = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private UIListEmptyRowType _EmptyRowType = new();

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private int _SelectorWidth;

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private UIDataSourceInfo _Visibility = new();

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private bool _SendIndexWithEvent;

		[ObservableProperty]
		[property: ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		private bool _UseScrollBar;

		[ObservableProperty]
		[property: ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		private bool _DataIncludesButtonLayout;

		[ObservableProperty]
		[property: ContainerField(75), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
		private bool _ClearListAtNavigationEvent;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private bool _Use3DSelection;

		[ObservableProperty]
		[property: ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		private bool _InvertVisible;

		[ObservableProperty]
		[property: ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		private bool _Visible;

		[ObservableProperty]
		[property: ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		private bool _ScreenRotationEnabled;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private bool _HighLightOnUpdate;

		[ObservableProperty]
		[property: ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		private bool _KeepScrollOffset;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ListIndex);
			(RimeWriter Writer, uint ArrayIndex) s_NestedLists = p_EbxWriter.GetArrayWriter(NestedLists.GetType(), NestedLists.Count);
			p_Writer.Write(s_NestedLists.ArrayIndex);
			foreach (var s_Entry in NestedLists)
			{
				s_Entry.Serialize(s_NestedLists.Writer, p_EbxWriter);
			}
			p_Writer.Write(RowSpacing);
			DefaultHighlightedRow.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) NavigationType);
			p_Writer.Write((int) RowType);
			p_Writer.Write((int) EmptyRowType);
			p_Writer.Write(SelectorWidth);
			Visibility.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SendIndexWithEvent);
			p_Writer.Write(UseScrollBar);
			p_Writer.Write(DataIncludesButtonLayout);
			p_Writer.Write(ClearListAtNavigationEvent);
			p_Writer.Write(Use3DSelection);
			p_Writer.Write(InvertVisible);
			p_Writer.Write(Visible);
			p_Writer.Write(ScreenRotationEnabled);
			p_Writer.Write(HighLightOnUpdate);
			p_Writer.Write(KeepScrollOffset);
			p_Writer.WriteNullBytes(2);
		}
	}
}
