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

[ContainerType(4, 120)]
public class CharacterMeleeBinding
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef TriggerMelee { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef DefendMelee { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AntRef MeleeKill { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AntRef SelfActor { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef OtherActor { get; set; } = new();
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public AntRef MeleeActive { get; set; } = new();
	
}

