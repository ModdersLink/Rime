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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 104)]
	public class UIListDataBinding : 
		UIDataBinding
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public int ListIndex { get; set; }

		[ContainerField(12), JsonProperty(Order = 12)]
		public UIDataSourceInfo ListQuery { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public List<StaticListItem> StaticItems { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public UIListEmptyRowType EmptyRowType { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public DefaultSelectionItem DefaultHighlightedRow { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public UIListRowType RowType { get; set; } = new();

		[ContainerField(60), JsonProperty(Order = 60)]
		public UIListNavigationType NavigationType { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public UIDataSourceInfo NavigationTypeSource { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public int RowSpacing { get; set; }

		[ContainerField(84), JsonProperty(Order = 84)]
		public UIListUnFocusMode UnFocusMode { get; set; } = new();

		[ContainerField(88), LayoutImmutable, JsonProperty(Order = 88)]
		public string DisabledRows { get; set; } = string.Empty;

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public bool ClearListAtNavigationEvent { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		public bool SendIndexWithEvent { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		public bool ScreenRotationEnabled { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		public bool Use3DSelection { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool FireHighlightOnMouseOut { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		public bool DataIncludesButtonLayout { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		public bool Visible { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		public bool SpinnerEnabled { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public bool UseScrollBar { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		public bool HighLightOnUpdate { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		public bool KeepScrollOffset { get; set; }

	}
}
