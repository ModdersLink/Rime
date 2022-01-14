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
	[ContainerType(4, 16)]
	public class BFServerConfigurationSchedule
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<string> Licenses { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<string> Levels { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public BFServerConfigurationData Data { get; set; } = new();
		
	}
}
