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

namespace fb.VeniceShared;

[ContainerType(4, 220)]
public class AILocoBinding
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef LocoTarget { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef AttentionState { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AntRef EndPoseEnum { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AntRef CurrentPoseEnum { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef EnterExitPoseEnum { get; set; } = new();
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public AntRef RunStyle { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AntRef TargetWaypointPosition { get; set; } = new();
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public AntRef TargetWaypointRadius { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AntRef TargetSpeedLevel { get; set; } = new();
	
	[ContainerField(0xb4), JsonProperty(Order = 180)]
	public AntRef CruiseSpeedLevel { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public AntRef EnableProceduralHeadAim { get; set; } = new();
	
}

