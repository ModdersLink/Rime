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


namespace fb.VeniceShared;

[ContainerType(8, 24)]
public class UIOptionsConsoleControlsTextFieldMappings
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public RefArray<UIOptionControlTextFieldMapping_NonChanging> NonChanging { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public RefArray<UIOptionControlTextFieldMapping_UnaryChanging> UnaryChanging { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<UIOptionControlTextFieldMapping_BothChanging> BothChanging { get; set; } = new();
	
}

