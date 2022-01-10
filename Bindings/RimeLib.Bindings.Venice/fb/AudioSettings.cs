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
	[ContainerType(4, 76)]
	public class AudioSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint WaveCacheSize { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint WaveCacheHeadroom { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float WaveCachePruneTimeLimit { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint WaveCacheRsxSize { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float WaveCacheRsxPruneTimeLimit { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint WaveCacheMaxReadIssueCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint WaveCacheMaxReadActiveCount { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float AudioCoreCpuLoadLimit { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AudioCoreCpuLoadRecovery { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public int AudioCoreThread { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public int AudioCoreMixJobThreadCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public int AudioCoreMaxMixJobThreadCount { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public uint MaxAudibleSoundCount { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public int AudioCoreMinProcStageVoicesToGoWide { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public uint DelayLineAllocSize { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public uint ReverbAllocSize { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public bool AudioCoreMultipleMixJobsEnabled { get; set; }

		public static void Deserialize(AudioSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WaveCacheSize = p_Reader.ReadUInt32();
			p_Instance.WaveCacheHeadroom = p_Reader.ReadUInt32();
			p_Instance.WaveCachePruneTimeLimit = p_Reader.ReadSingle();
			p_Instance.WaveCacheRsxSize = p_Reader.ReadUInt32();
			p_Instance.WaveCacheRsxPruneTimeLimit = p_Reader.ReadSingle();
			p_Instance.WaveCacheMaxReadIssueCount = p_Reader.ReadUInt32();
			p_Instance.WaveCacheMaxReadActiveCount = p_Reader.ReadUInt32();
			p_Instance.AudioCoreCpuLoadLimit = p_Reader.ReadSingle();
			p_Instance.AudioCoreCpuLoadRecovery = p_Reader.ReadSingle();
			p_Instance.AudioCoreThread = p_Reader.ReadInt32();
			p_Instance.AudioCoreMixJobThreadCount = p_Reader.ReadInt32();
			p_Instance.AudioCoreMaxMixJobThreadCount = p_Reader.ReadInt32();
			p_Instance.MaxAudibleSoundCount = p_Reader.ReadUInt32();
			p_Instance.AudioCoreMinProcStageVoicesToGoWide = p_Reader.ReadInt32();
			p_Instance.DelayLineAllocSize = p_Reader.ReadUInt32();
			p_Instance.ReverbAllocSize = p_Reader.ReadUInt32();
			p_Instance.AudioCoreMultipleMixJobsEnabled = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
