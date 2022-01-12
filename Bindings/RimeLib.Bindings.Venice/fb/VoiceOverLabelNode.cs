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
	[ContainerType(4, 40)]
	public class VoiceOverLabelNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public RefArray<VoiceOverLabelSource> Sources { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<VoiceOverValue> False { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverValue> True { get; set; } = new();

		[ContainerField(20)]
		public RefArray<VoiceOverLabel> WantedLabels { get; set; } = new();

		[ContainerField(24)]
		public RefArray<VoiceOverLabel> UnwantedLabels { get; set; } = new();

		[ContainerField(28)]
		public VoiceOverLabelSourceMode SourceMode { get; set; } = new();

		[ContainerField(32)]
		public VoiceOverLabelCompareMode WantedCompareMode { get; set; } = new();

		[ContainerField(36)]
		public VoiceOverLabelCompareMode UnwantedCompareMode { get; set; } = new();

	}
}
