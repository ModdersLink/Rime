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
	[ContainerType(4, 28)]
	public class VoiceOverIntervalNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValueConnection> Threshold { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<VoiceOverValue> Time { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverValue> False { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<VoiceOverValue> True { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<VoiceOverInterval> Interval { get; set; } = new();

	}
}
