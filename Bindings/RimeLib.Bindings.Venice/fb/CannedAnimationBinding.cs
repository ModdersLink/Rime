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
	[ContainerType(4, 40)]
	public class CannedAnimationBinding
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef LevelIndex { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef ScenarioIndex { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef ActorIndex { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef PartIndex { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef TriggerCannedAnimation { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef ExitCannedAnimation { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef ExternalTime { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntRef BlendValue { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntRef AdvanceScenario { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public AntRef EnteredLoop { get; set; } = new();
		
	}
}
