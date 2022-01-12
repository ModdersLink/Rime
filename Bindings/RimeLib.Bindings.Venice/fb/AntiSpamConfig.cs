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
	[ContainerType(4, 32)]
	public class AntiSpamConfig
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float DetectionInterval { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint DetectionIntervalMaxMessageCount { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint ServerSideMessageCountTolerance { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint SecondsBlocked { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint ServerSideSecondsBlockedTolerance { get; set; }
		
		[ContainerField(20), LayoutImmutable]
		public string NotificationSid { get; set; } = string.Empty;
		
		[ContainerField(24), LayoutImmutable]
		public string StillBlockedSid { get; set; } = string.Empty;
		
		[ContainerField(28)]
		public CtrRef<SoundWaveAsset> WarningSound { get; set; } = new();
		
	}
}
