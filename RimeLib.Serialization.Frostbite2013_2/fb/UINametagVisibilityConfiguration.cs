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

[ContainerType(1, 4)]
public class UINametagVisibilityConfiguration
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public UINametagVisibilityValues LookAtVisibility { get; set; } = new();
	
	[ContainerField(0x2), JsonProperty(Order = 2)]
	public UINametagVisibilityValues Visibility { get; set; } = new();
	
}

