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
	public class EntitySettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint OutOfEntityBusNetworkIdThreshold { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public ExecutionModeType ExecutionMode { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool SpawnSubLevelsFromLogic { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		public bool EditorGameViewEnable { get; set; }

	}
}
