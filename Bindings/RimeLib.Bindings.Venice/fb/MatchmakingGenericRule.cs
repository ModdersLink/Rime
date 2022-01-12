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
	[ContainerType(4, 20)]
	public class MatchmakingGenericRule
	{
		[ContainerField(0), LayoutImmutable]
		public string Rule { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string MinFitThresHold { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string Setting { get; set; } = string.Empty;
		
		[ContainerField(12)]
		public List<MatchmakingRuleString> DesiredValues { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IgnoreIfDefault { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool MergeValues { get; set; }
		
		[ContainerField(18), LayoutImmutable, Blittable]
		public bool SortValues { get; set; }
		
	}
}
