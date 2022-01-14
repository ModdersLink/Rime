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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class MatchmakingCriteria
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public MatchmakingSizeRule SizeRule { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public MatchmakingPingSiteRule PingSiteRule { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public MatchmakingRankedRule RankedRule { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public List<MatchmakingGenericRule> GenericRules { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public MatchmakingVirtualizedRule VirtualizedRule { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public List<MatchmakingUserExtendedDataRule> UEDRules { get; set; } = new();
		
	}
}
