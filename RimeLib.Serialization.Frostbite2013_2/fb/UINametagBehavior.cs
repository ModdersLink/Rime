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

namespace fb.VeniceShared;

[ContainerType(4, 24)]
public class UINametagBehavior
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float CloseDistance { get; set; } = 30.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public bool MagneticToScreen { get; set; } = false;
	
	[ContainerField(0x5), JsonProperty(Order = 5)]
	public UINametagVisibilityConfiguration IconVisibility { get; set; } = new();
	
	[ContainerField(0x9), JsonProperty(Order = 9)]
	public UINametagVisibilityConfiguration NameVisibility { get; set; } = new();
	
	[ContainerField(0xd), JsonProperty(Order = 13)]
	public UINametagVisibilityConfiguration HealthVisibility { get; set; } = new();
	
	[ContainerField(0x11), JsonProperty(Order = 17)]
	public UINametagVisibilityConfiguration DistanceVisibility { get; set; } = new();
	
}

