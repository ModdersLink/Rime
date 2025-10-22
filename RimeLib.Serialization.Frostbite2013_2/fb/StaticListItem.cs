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

[ContainerType(8, 56)]
public class StaticListItem
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public string ItemName { get; set; } = string.Empty;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public string ItemIndex { get; set; } = string.Empty;
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public UISimpleDataSource DynamicDisable { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UISimpleDataSource DynamicNewContent { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool AppendPlatformToSID { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool ExcludeInRetail { get; set; } = false;
	
}

