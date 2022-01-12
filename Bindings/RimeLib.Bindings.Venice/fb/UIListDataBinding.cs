///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
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
		[ContainerField(8), LayoutImmutable, Blittable]
		public int ListIndex { get; set; }

		[ContainerField(12)]
		public UIDataSourceInfo ListQuery { get; set; } = new();

		[ContainerField(28)]
		public List<StaticListItem> StaticItems { get; set; } = new();

		[ContainerField(32)]
		public UIListEmptyRowType EmptyRowType { get; set; } = new();

		[ContainerField(36)]
		public DefaultSelectionItem DefaultHighlightedRow { get; set; } = new();

		[ContainerField(56)]
		public UIListRowType RowType { get; set; } = new();

		[ContainerField(60)]
		public UIListNavigationType NavigationType { get; set; } = new();

		[ContainerField(64)]
		public UIDataSourceInfo NavigationTypeSource { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public int RowSpacing { get; set; }

		[ContainerField(84)]
		public UIListUnFocusMode UnFocusMode { get; set; } = new();

		[ContainerField(88), LayoutImmutable]
		public string DisabledRows { get; set; } = string.Empty;

		[ContainerField(92), LayoutImmutable, Blittable]
		public bool ClearListAtNavigationEvent { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable]
		public bool SendIndexWithEvent { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable]
		public bool ScreenRotationEnabled { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable]
		public bool Use3DSelection { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool FireHighlightOnMouseOut { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool DataIncludesButtonLayout { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable]
		public bool SpinnerEnabled { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool UseScrollBar { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable]
		public bool HighLightOnUpdate { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable]
		public bool KeepScrollOffset { get; set; }

	}
}
