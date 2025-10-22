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

[ContainerType(4, 280)]
public class SpecialMovesBinding
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef UseNewVault { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef TriggerHighVault { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AntRef TriggerUpVault { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AntRef TriggerLowVault { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef TriggerSlideIntoProne { get; set; } = new();
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public AntRef TriggerSpecialAnimation { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AntRef SpecialAnimationIndex { get; set; } = new();
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public AntRef ObjectHeight { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AntRef ObjectDistance { get; set; } = new();
	
	[ContainerField(0xb4), JsonProperty(Order = 180)]
	public AntRef ObjectThickness { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public AntRef StartObjectDistanceTimer { get; set; } = new();
	
	[ContainerField(0xdc), JsonProperty(Order = 220)]
	public AntRef VaultObjectPositionX { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public AntRef VaultObjectPositionZ { get; set; } = new();
	
	[ContainerField(0x104), JsonProperty(Order = 260)]
	public AntRef CancelAnimation { get; set; } = new();
	
}

