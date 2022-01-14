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
	[ContainerType(4, 20)]
	public class VoiceOverGlobalNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<VoiceOverValue> Value { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<VoiceOverNamedValue> Field { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<VoiceOverObject> Object { get; set; } = new();

	}
}
