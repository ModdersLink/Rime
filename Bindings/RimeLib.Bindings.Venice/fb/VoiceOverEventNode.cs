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
	public class VoiceOverEventNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new();

		[ContainerField(16)]
		public RefArray<VoiceOverStructureNode> Relationship { get; set; } = new();

		[ContainerField(20)]
		public RefArray<VoiceOverValueRedirect> Redirects { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<VoiceOverEvent> Event { get; set; } = new();

	}
}
