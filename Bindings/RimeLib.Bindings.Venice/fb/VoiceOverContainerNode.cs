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
	public class VoiceOverContainerNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public RefArray<VoiceOverValueConnection> Condition { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new();

		[ContainerField(20)]
		public RefArray<VoiceOverStructureNode> TrueRelationship { get; set; } = new();

		[ContainerField(24)]
		public RefArray<VoiceOverStructureNode> FalseRelationship { get; set; } = new();

		[ContainerField(28)]
		public VoiceOverContainerConditionMode ConditionMode { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Probability { get; set; }

	}
}
