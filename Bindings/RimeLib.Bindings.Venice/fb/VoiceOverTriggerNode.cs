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
	public class VoiceOverTriggerNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<VoiceOverTriggerParameter> Parameters { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float Delay { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<VoiceOverEvent> Event { get; set; } = new();

	}
}
