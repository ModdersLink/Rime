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
	public class VoiceOverEventEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<VoiceOverNamedValue> EventPlayer { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverEvent> VoEvent { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FinishedDelay { get; set; }

		[ContainerField(24)]
		public CtrRef<VoiceOverNamedValue> ExtraEventPlayer { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public float TriggerDelay { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool RunOnce { get; set; }

	}
}
