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
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 112)]
public class UICommoRoseButtonInfo
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public string ButtonId { get; set; } = string.Empty;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public string ButtonText { get; set; } = string.Empty;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string ChatText { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public ChatChannelType ChatChannel { get; set; } = ChatChannelType.CctSayAll;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<UIElementAction> Action { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string IconTextureId { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public UICommoRoseTextAlignment TextAlignment { get; set; } = UICommoRoseTextAlignment.UICommoRoseTextAlignment_Center;
	
	[ContainerField(0x34), JsonProperty(Order = 52)]
	public UIElementRect InactiveRect { get; set; } = new();
	
	[ContainerField(0x44), JsonProperty(Order = 68)]
	public UIElementRect ActiveRect { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<UIElementFontStyle> InactiveFontStyle { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<UIElementFontStyle> ActiveFontStyle { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool UseLocalRect { get; set; } = false;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool IsSelectable { get; set; } = true;
	
}

