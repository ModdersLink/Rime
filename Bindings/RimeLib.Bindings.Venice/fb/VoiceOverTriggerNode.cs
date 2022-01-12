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
	[ContainerType(4, 24)]
	public class VoiceOverTriggerNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public RefArray<VoiceOverTriggerParameter> Parameters { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float Delay { get; set; }

		[ContainerField(20)]
		public CtrRef<VoiceOverEvent> Event { get; set; } = new();

	}
}
