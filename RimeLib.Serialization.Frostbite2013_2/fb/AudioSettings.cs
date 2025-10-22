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

[ContainerType(8, 128)]
public class AudioSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint DataManagerCacheSize { get; set; } = 15728640;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint DataManagerCacheRsxSize { get; set; } = 0;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint DataManagerMaxReadIssueCount { get; set; } = 1;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint DataManagerMaxReadActiveCount { get; set; } = 2;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint DataManagerMaxTrimSize { get; set; } = 0;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float AudioCoreCpuLoadLimit { get; set; } = 70.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float AudioCoreCpuLoadRecovery { get; set; } = 10.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public int AudioCoreThread { get; set; } = -1;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int AudioCoreMixJobThreadCount { get; set; } = -1;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int AudioCoreMaxMixJobThreadCount { get; set; } = 3;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int AudioCoreMinProcStageVoicesToGoWide { get; set; } = 30;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float AudioCoreMiniumMixAhead { get; set; } = 0.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float AudioCoreTargetMixAhead { get; set; } = 0.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint AudioCoreMaxChannelCount { get; set; } = 8;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public uint DelayLineAllocSize { get; set; } = 1572864;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint ReverbAllocSize { get; set; } = 0;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint MaxAudibleSoundCount { get; set; } = 15;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float HdrSuspensionThreshold { get; set; } = 2.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float HdrZombieThreshold { get; set; } = 4.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float HdrEnableSuspensionThreshold { get; set; } = 3.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float SoundSpeed { get; set; } = 331.500f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float SoundDopplerFactor { get; set; } = 0.500f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float SoundDopplerSmoothFactor { get; set; } = 0.800f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float MusicRequestBufferTime { get; set; } = 3.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint DacDelay { get; set; } = 0;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float DacAmplitude { get; set; } = 1.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public bool AudioCoreMultipleMixJobsEnabled { get; set; } = true;
	
	[ContainerField(0x79), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
	public bool AudioCoreSystemJobsEnabled { get; set; } = false;
	
	[ContainerField(0x7a), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
	public bool AudioCoreWatchDogThreadEnabled { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DataManagerCacheSize);
		p_Writer.Write(DataManagerCacheRsxSize);
		p_Writer.Write(DataManagerMaxReadIssueCount);
		p_Writer.Write(DataManagerMaxReadActiveCount);
		p_Writer.Write(DataManagerMaxTrimSize);
		p_Writer.Write(AudioCoreCpuLoadLimit);
		p_Writer.Write(AudioCoreCpuLoadRecovery);
		p_Writer.Write(AudioCoreThread);
		p_Writer.Write(AudioCoreMixJobThreadCount);
		p_Writer.Write(AudioCoreMaxMixJobThreadCount);
		p_Writer.Write(AudioCoreMinProcStageVoicesToGoWide);
		p_Writer.Write(AudioCoreMiniumMixAhead);
		p_Writer.Write(AudioCoreTargetMixAhead);
		p_Writer.Write(AudioCoreMaxChannelCount);
		p_Writer.Write(DelayLineAllocSize);
		p_Writer.Write(ReverbAllocSize);
		p_Writer.Write(MaxAudibleSoundCount);
		p_Writer.Write(HdrSuspensionThreshold);
		p_Writer.Write(HdrZombieThreshold);
		p_Writer.Write(HdrEnableSuspensionThreshold);
		p_Writer.Write(SoundSpeed);
		p_Writer.Write(SoundDopplerFactor);
		p_Writer.Write(SoundDopplerSmoothFactor);
		p_Writer.Write(MusicRequestBufferTime);
		p_Writer.Write(DacDelay);
		p_Writer.Write(DacAmplitude);
		p_Writer.Write(AudioCoreMultipleMixJobsEnabled);
		p_Writer.Write(AudioCoreSystemJobsEnabled);
		p_Writer.Write(AudioCoreWatchDogThreadEnabled);
		p_Writer.WriteNullBytes(5);
	}
}

