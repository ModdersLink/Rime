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
	public class InterfaceDescriptorData : 
		DynamicDataContainer
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<DynamicEvent> InputEvents { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<DynamicEvent> OutputEvents { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<DynamicLink> InputLinks { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<DynamicLink> OutputLinks { get; set; } = new();

	}
}
