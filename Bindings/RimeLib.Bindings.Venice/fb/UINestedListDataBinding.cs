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
	[ContainerType(4, 84)]
	public class UINestedListDataBinding : 
		UIDataBinding
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public int ListIndex { get; set; }

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<NestedList> NestedLists { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int RowSpacing { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public DefaultSelectionItem DefaultHighlightedRow { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public UIListNavigationType NavigationType { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public UIListRowType RowType { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public UIListEmptyRowType EmptyRowType { get; set; } = new();

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public int SelectorWidth { get; set; }

		[ContainerField(56), JsonProperty(Order = 56)]
		public UIDataSourceInfo Visibility { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public bool SendIndexWithEvent { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		public bool UseScrollBar { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		public bool DataIncludesButtonLayout { get; set; }

		[ContainerField(75), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
		public bool ClearListAtNavigationEvent { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public bool Use3DSelection { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		public bool InvertVisible { get; set; }

		[ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		public bool Visible { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		public bool ScreenRotationEnabled { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public bool HighLightOnUpdate { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		public bool KeepScrollOffset { get; set; }

	}
}
