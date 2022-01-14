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
	public class BusNodeData : 
		SoundBusData
	{
		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public SoundGraphPluginRef VuPlugin { get; set; } = new();

	}
}
