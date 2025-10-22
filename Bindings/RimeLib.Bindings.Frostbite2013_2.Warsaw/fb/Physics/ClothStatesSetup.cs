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

namespace fb.Physics;

[ContainerType(8, 32)]
public class ClothStatesSetup
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public List<uint> States { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public List<ClothStateSetupTransitionLookup> StatesTransitionLookups { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<ClothStateSetupTransition> StatesTransitions { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint EmptyState { get; set; } = 0;
	
}

