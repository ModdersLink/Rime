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

namespace fb.GameShared;

[ContainerType(8, 24)]
public class UIDataSource
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<UIComponentData> DataCategory { get; set; } = new();
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public int DataKey { get; set; } = 0;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string SchematicsProperty { get; set; } = string.Empty;
	
}

