///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 36)]
	public class VoiceOverDistanceNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValueConnection> A { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<VoiceOverValueConnection> B { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverValueConnection> Threshold { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<VoiceOverValue> Distance { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<VoiceOverValue> False { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<VoiceOverValue> True { get; set; } = new();

		[ContainerField(32)]
		public VoiceOverCompareExpressionType Operation { get; set; } = new();

	}
}
