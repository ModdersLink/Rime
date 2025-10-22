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

using fb.GameShared;

namespace fb.VeniceShared;

[ContainerType(16, 48)]
public class UIMinimapIconConfiguration
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public UIElementColor BgCol { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<UIElementFontStyle> SmallFont { get; set; } = new();
	
}

