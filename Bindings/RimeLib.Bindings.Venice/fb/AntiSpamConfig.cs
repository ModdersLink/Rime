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
	[ContainerType(4, 32)]
	public class AntiSpamConfig
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float DetectionInterval { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public uint DetectionIntervalMaxMessageCount { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint ServerSideMessageCountTolerance { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint SecondsBlocked { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint ServerSideSecondsBlockedTolerance { get; set; }
		
		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string NotificationSid { get; set; } = string.Empty;
		
		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string StillBlockedSid { get; set; } = string.Empty;
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<SoundWaveAsset> WarningSound { get; set; } = new();
		
	}
}
