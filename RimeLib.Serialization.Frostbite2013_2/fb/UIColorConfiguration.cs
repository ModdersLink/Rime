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

[ContainerType(16, 320)]
public class UIColorConfiguration
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public UIElementColor Neutral { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UIElementColor Team { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UIElementColor Squad { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public UIElementColor Enemy { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor Team1 { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementColor Team2 { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor Team3 { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementColor Team4 { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public UIElementColor Commander { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public UIElementColor Spectator { get; set; } = new();
	
}

