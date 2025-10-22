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

using fb.Audio;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 48)]
public class AntiSpamConfig
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float DetectionInterval { get; set; } = 6.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public uint DetectionIntervalMaxMessageCount { get; set; } = 6;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public uint ServerSideMessageCountTolerance { get; set; } = 1;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public uint SecondsBlocked { get; set; } = 30;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint ServerSideSecondsBlockedTolerance { get; set; } = 3;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string NotificationSid { get; set; } = @"You are spamming too much! Blocked for #SEC# seconds!";
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string StillBlockedSid { get; set; } = @"You are still blocked for spamming, #SEC# seconds remain until you will be permitted to chat.";
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<SoundWaveAsset> WarningSound { get; set; } = new();
	
}

