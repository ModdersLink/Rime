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
	[ContainerType(4, 72)]
	public class NestedList
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Label { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string Index { get; set; } = string.Empty;
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public UIDataSourceInfo ListDataSource { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public UIDataSourceInfo DynamicShowList { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public List<string> StaticItems { get; set; } = new();
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public DefaultSelectionItem DefaultHighlighted { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public UIListRowType RowType { get; set; } = new();
		
		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool UseAsNormalListRows { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool HiddenOnPC { get; set; }
		
		[ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		public bool HiddenOnXenon { get; set; }
		
		[ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		public bool HighLightOnUpdate { get; set; }
		
	}
}
