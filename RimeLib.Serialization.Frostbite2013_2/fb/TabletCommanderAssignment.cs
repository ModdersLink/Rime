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


namespace fb.Venice;

[ContainerType(8, 72)]
public class TabletCommanderAssignment
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public TabletCommanderAwardData AssignmentAwardData { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<TabletCommanderAwardData> Dependencies { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<TabletCommanderAwardCriteria> Criterias { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<TabletCommanderDogTagData> DogTags { get; set; } = new();
	
}

