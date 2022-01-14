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
	public class MinMaxNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort X { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort Y { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AudioGraphNodePort Max { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public AudioGraphNodePort Min { get; set; } = new();

	}
}
