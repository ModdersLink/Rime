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


namespace fb.Online;

[ContainerType(8, 112)]
public class MatchmakingCriteria
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public MatchmakingSizeRule SizeRule { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public MatchmakingPingSiteRule PingSiteRule { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public MatchmakingRankedRule RankedRule { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<MatchmakingGenericRule> GenericRules { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public MatchmakingVirtualizedRule VirtualizedRule { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<MatchmakingUserExtendedDataRule> UEDRules { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public MatchmakingModRule ModRule { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public MatchmakingSlotUtilizationRule SlotUtilizationRule { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public MatchmakingFreePlayerSlotsRule FreePlayerSlotsRule { get; set; } = new();
	
}

