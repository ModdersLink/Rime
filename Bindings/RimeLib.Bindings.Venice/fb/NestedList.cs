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
	[ContainerType(4, 72)]
	public class NestedList
	{
		[ContainerField(0), LayoutImmutable]
		public string Label { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string Index { get; set; } = string.Empty;
		
		[ContainerField(8)]
		public UIDataSourceInfo ListDataSource { get; set; } = new();
		
		[ContainerField(24)]
		public UIDataSourceInfo DynamicShowList { get; set; } = new();
		
		[ContainerField(40)]
		public List<string> StaticItems { get; set; } = new();
		
		[ContainerField(44)]
		public DefaultSelectionItem DefaultHighlighted { get; set; } = new();
		
		[ContainerField(64)]
		public UIListRowType RowType { get; set; } = new();
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool UseAsNormalListRows { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool HiddenOnPC { get; set; }
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool HiddenOnXenon { get; set; }
		
		[ContainerField(71), LayoutImmutable, Blittable]
		public bool HighLightOnUpdate { get; set; }
		
	}
}
