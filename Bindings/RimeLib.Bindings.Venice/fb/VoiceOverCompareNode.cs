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
	public class VoiceOverCompareNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<VoiceOverValueConnection> A { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<VoiceOverValueConnection> B { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<VoiceOverValue> False { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<VoiceOverValue> True { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public VoiceOverCompareExpressionType Operation { get; set; } = new();

	}
}
