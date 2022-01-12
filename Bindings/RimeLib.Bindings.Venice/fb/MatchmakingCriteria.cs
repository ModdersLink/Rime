///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
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
		[ContainerField(0)]
		public MatchmakingSizeRule SizeRule { get; set; } = new();
		
		[ContainerField(8)]
		public MatchmakingPingSiteRule PingSiteRule { get; set; } = new();
		
		[ContainerField(12)]
		public MatchmakingRankedRule RankedRule { get; set; } = new();
		
		[ContainerField(16)]
		public List<MatchmakingGenericRule> GenericRules { get; set; } = new();
		
		[ContainerField(20)]
		public MatchmakingVirtualizedRule VirtualizedRule { get; set; } = new();
		
		[ContainerField(28)]
		public List<MatchmakingUserExtendedDataRule> UEDRules { get; set; } = new();
		
	}
}
