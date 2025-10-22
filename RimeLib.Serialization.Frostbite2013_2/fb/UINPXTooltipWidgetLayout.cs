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

[ContainerType(4, 44)]
public class UINPXTooltipWidgetLayout
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public UILayoutMode LayoutMode { get; set; } = UILayoutMode.UILayoutMode_AnchorOffset;
	
	[ContainerField(0x4), JsonProperty(Order = 4)]
	public UIElementOffset Offset { get; set; } = new();
	
	[ContainerField(0xc), JsonProperty(Order = 12)]
	public UIElementAnchor Anchor { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public UIElementOffset Position { get; set; } = new();
	
	[ContainerField(0x1c), JsonProperty(Order = 28)]
	public UIElementRectExpansion Expansion { get; set; } = new();
	
}

