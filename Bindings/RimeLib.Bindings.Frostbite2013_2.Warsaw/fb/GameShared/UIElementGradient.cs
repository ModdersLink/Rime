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


namespace fb.GameShared;

[ContainerType(16, 128)]
public class UIElementGradient
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public UIElementColor TopLeftColor { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UIElementColor TopRightColor { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UIElementColor BottomLeftColor { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public UIElementColor BottomRightColor { get; set; } = new();
	
}

