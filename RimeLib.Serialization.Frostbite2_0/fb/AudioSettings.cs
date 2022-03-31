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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 76)]
	public class AudioSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint WaveCacheSize { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint WaveCacheHeadroom { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float WaveCachePruneTimeLimit { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint WaveCacheRsxSize { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float WaveCacheRsxPruneTimeLimit { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint WaveCacheMaxReadIssueCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint WaveCacheMaxReadActiveCount { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float AudioCoreCpuLoadLimit { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float AudioCoreCpuLoadRecovery { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public int AudioCoreThread { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public int AudioCoreMixJobThreadCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public int AudioCoreMaxMixJobThreadCount { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public uint MaxAudibleSoundCount { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public int AudioCoreMinProcStageVoicesToGoWide { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public uint DelayLineAllocSize { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public uint ReverbAllocSize { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public bool AudioCoreMultipleMixJobsEnabled { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(WaveCacheSize);
			p_Writer.Write(WaveCacheHeadroom);
			p_Writer.Write(WaveCachePruneTimeLimit);
			p_Writer.Write(WaveCacheRsxSize);
			p_Writer.Write(WaveCacheRsxPruneTimeLimit);
			p_Writer.Write(WaveCacheMaxReadIssueCount);
			p_Writer.Write(WaveCacheMaxReadActiveCount);
			p_Writer.Write(AudioCoreCpuLoadLimit);
			p_Writer.Write(AudioCoreCpuLoadRecovery);
			p_Writer.Write(AudioCoreThread);
			p_Writer.Write(AudioCoreMixJobThreadCount);
			p_Writer.Write(AudioCoreMaxMixJobThreadCount);
			p_Writer.Write(MaxAudibleSoundCount);
			p_Writer.Write(AudioCoreMinProcStageVoicesToGoWide);
			p_Writer.Write(DelayLineAllocSize);
			p_Writer.Write(ReverbAllocSize);
			p_Writer.Write(AudioCoreMultipleMixJobsEnabled);
			p_Writer.WriteNullBytes(3);
		}
	}
}
