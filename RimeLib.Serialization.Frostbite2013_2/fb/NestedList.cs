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

using fb.Core;
using fb.UI;

namespace fb.VeniceShared;

[ContainerType(8, 112)]
public class NestedList
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public string Label { get; set; } = string.Empty;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public string Index { get; set; } = string.Empty;
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public UIDataSourceInfo ListDataSource { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public UIDataSourceInfo DynamicShowList { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<string> StaticItems { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public DefaultSelectionItem DefaultHighlighted { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public UIListRowType RowType { get; set; } = UIListRowType.TextSelectorRow;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool UseAsNormalListRows { get; set; } = false;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool HiddenOnPC { get; set; } = false;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool HiddenOnXenon { get; set; } = false;
	
	[ContainerField(0x6f), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
	public bool HighLightOnUpdate { get; set; } = true;
	
}

