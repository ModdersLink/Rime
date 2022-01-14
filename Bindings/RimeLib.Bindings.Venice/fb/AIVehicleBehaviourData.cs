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
	[ContainerType(4, 28)]
	public class AIVehicleBehaviourData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<string> Controls { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<string> Behaviours { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<string> Goals { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<IntentData> Intents { get; set; } = new();

	}
}
