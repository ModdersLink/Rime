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
	[ContainerType(4, 24)]
	public class AIVehicleTypes : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<AIVehicleBehaviourData> VehicleTypes { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<BehaviourData> Goals { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<BehaviourData> Intents { get; set; } = new();

	}
}
