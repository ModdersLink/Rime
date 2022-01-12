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
	[ContainerType(4, 84)]
	public class UINestedListDataBinding : 
		UIDataBinding
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int ListIndex { get; set; }

		[ContainerField(12)]
		public List<NestedList> NestedLists { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public int RowSpacing { get; set; }

		[ContainerField(20)]
		public DefaultSelectionItem DefaultHighlightedRow { get; set; } = new();

		[ContainerField(40)]
		public UIListNavigationType NavigationType { get; set; } = new();

		[ContainerField(44)]
		public UIListRowType RowType { get; set; } = new();

		[ContainerField(48)]
		public UIListEmptyRowType EmptyRowType { get; set; } = new();

		[ContainerField(52), LayoutImmutable, Blittable]
		public int SelectorWidth { get; set; }

		[ContainerField(56)]
		public UIDataSourceInfo Visibility { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable]
		public bool SendIndexWithEvent { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable]
		public bool UseScrollBar { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable]
		public bool DataIncludesButtonLayout { get; set; }

		[ContainerField(75), LayoutImmutable, Blittable]
		public bool ClearListAtNavigationEvent { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool Use3DSelection { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable]
		public bool InvertVisible { get; set; }

		[ContainerField(78), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable]
		public bool ScreenRotationEnabled { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public bool HighLightOnUpdate { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable]
		public bool KeepScrollOffset { get; set; }

	}
}
