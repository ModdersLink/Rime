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

using fb.Ant;

namespace fb.Venice;

[ContainerType(4, 160)]
public class AwarenessComponentBinding
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef RelativeLookAtPitch { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef RelativeLookAtYaw { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AntRef HasAwarenessTarget { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AntRef ExplosionNearby { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef ExplosionDirection { get; set; } = new();
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public AntRef NearbyThreat { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AntRef NearbyThreatDirection { get; set; } = new();
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public AntRef AmbientThreat { get; set; } = new();
	
}

