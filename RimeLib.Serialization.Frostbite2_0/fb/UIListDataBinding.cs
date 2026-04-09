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
	[ContainerType(4, 104)]
	public partial class UIListDataBinding :
		UIDataBinding
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private int _ListIndex;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private UIDataSourceInfo _ListQuery = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private List<StaticListItem> _StaticItems = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private UIListEmptyRowType _EmptyRowType = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private DefaultSelectionItem _DefaultHighlightedRow = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private UIListRowType _RowType = new();

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private UIListNavigationType _NavigationType = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private UIDataSourceInfo _NavigationTypeSource = new();

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private int _RowSpacing;

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private UIListUnFocusMode _UnFocusMode = new();

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, JsonProperty(Order = 88)]
		private string _DisabledRows = string.Empty;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private bool _ClearListAtNavigationEvent;

		[ObservableProperty]
		[property: ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		private bool _SendIndexWithEvent;

		[ObservableProperty]
		[property: ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		private bool _ScreenRotationEnabled;

		[ObservableProperty]
		[property: ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		private bool _Use3DSelection;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _FireHighlightOnMouseOut;

		[ObservableProperty]
		[property: ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		private bool _DataIncludesButtonLayout;

		[ObservableProperty]
		[property: ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		private bool _Visible;

		[ObservableProperty]
		[property: ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		private bool _SpinnerEnabled;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private bool _UseScrollBar;

		[ObservableProperty]
		[property: ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		private bool _HighLightOnUpdate;

		[ObservableProperty]
		[property: ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		private bool _KeepScrollOffset;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ListIndex);
			ListQuery.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_StaticItems = p_EbxWriter.GetArrayWriter(StaticItems.GetType(), StaticItems.Count);
			p_Writer.Write(s_StaticItems.ArrayIndex);
			foreach (var s_Entry in StaticItems)
			{
				s_Entry.Serialize(s_StaticItems.Writer, p_EbxWriter);
			}
			p_Writer.Write((int) EmptyRowType);
			DefaultHighlightedRow.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) RowType);
			p_Writer.Write((int) NavigationType);
			NavigationTypeSource.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(RowSpacing);
			p_Writer.Write((int) UnFocusMode);
			p_Writer.Write(p_EbxWriter.WriteString(DisabledRows));
			p_Writer.Write(ClearListAtNavigationEvent);
			p_Writer.Write(SendIndexWithEvent);
			p_Writer.Write(ScreenRotationEnabled);
			p_Writer.Write(Use3DSelection);
			p_Writer.Write(FireHighlightOnMouseOut);
			p_Writer.Write(DataIncludesButtonLayout);
			p_Writer.Write(Visible);
			p_Writer.Write(SpinnerEnabled);
			p_Writer.Write(UseScrollBar);
			p_Writer.Write(HighLightOnUpdate);
			p_Writer.Write(KeepScrollOffset);
			p_Writer.WriteNullBytes(1);
		}
	}
}
