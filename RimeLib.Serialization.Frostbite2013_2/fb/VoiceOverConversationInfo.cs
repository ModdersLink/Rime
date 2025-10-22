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

using fb.Core;

namespace fb.Audio;

[ContainerType(8, 48)]
public class VoiceOverConversationInfo
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public RefArray<VoiceOverDialogGroup> Groups { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public RefArray<VoiceOverDialogTrack> Tracks { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<VoiceOverPronunciation> Pronunciations { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public VoiceOverConversationInterruptMode InterruptMode { get; set; } = VoiceOverConversationInterruptMode.VoiceOverConversationInterruptMode_Allow;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int Priority { get; set; } = 0;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public VoiceOverConversationQueueMode QueueMode { get; set; } = VoiceOverConversationQueueMode.VoiceOverConversationQueueMode_Never;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float Relevancy { get; set; } = 10.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public byte LastSequenceIndex { get; set; } = 0;
	
}

