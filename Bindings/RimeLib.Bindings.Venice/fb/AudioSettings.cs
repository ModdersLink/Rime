///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AudioSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint WaveCacheSize { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint WaveCacheHeadroom { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float WaveCachePruneTimeLimit { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint WaveCacheRsxSize { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float WaveCacheRsxPruneTimeLimit { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint WaveCacheMaxReadIssueCount { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint WaveCacheMaxReadActiveCount { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float AudioCoreCpuLoadLimit { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AudioCoreCpuLoadRecovery { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int AudioCoreThread { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public int AudioCoreMixJobThreadCount { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public int AudioCoreMaxMixJobThreadCount { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public uint MaxAudibleSoundCount { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public int AudioCoreMinProcStageVoicesToGoWide { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public uint DelayLineAllocSize { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public uint ReverbAllocSize { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool AudioCoreMultipleMixJobsEnabled { get; set; } // 0x48 (72)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 120676393:
					WaveCacheSize = (uint) p_Value;
					break;

				case 2616055963:
					WaveCacheHeadroom = (uint) p_Value;
					break;

				case 3511233232:
					WaveCachePruneTimeLimit = (float) p_Value;
					break;

				case 2616589264:
					WaveCacheRsxSize = (uint) p_Value;
					break;

				case 535484713:
					WaveCacheRsxPruneTimeLimit = (float) p_Value;
					break;

				case 3845970128:
					WaveCacheMaxReadIssueCount = (uint) p_Value;
					break;

				case 108029477:
					WaveCacheMaxReadActiveCount = (uint) p_Value;
					break;

				case 2039173245:
					AudioCoreCpuLoadLimit = (float) p_Value;
					break;

				case 4028843115:
					AudioCoreCpuLoadRecovery = (float) p_Value;
					break;

				case 4095311206:
					AudioCoreThread = (int) p_Value;
					break;

				case 1467197950:
					AudioCoreMixJobThreadCount = (int) p_Value;
					break;

				case 562156554:
					AudioCoreMaxMixJobThreadCount = (int) p_Value;
					break;

				case 685226627:
					MaxAudibleSoundCount = (uint) p_Value;
					break;

				case 1771683297:
					AudioCoreMinProcStageVoicesToGoWide = (int) p_Value;
					break;

				case 22362422:
					DelayLineAllocSize = (uint) p_Value;
					break;

				case 2086423929:
					ReverbAllocSize = (uint) p_Value;
					break;

				case 2281411509:
					AudioCoreMultipleMixJobsEnabled = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 120676393:
					return WaveCacheSize;

				case 2616055963:
					return WaveCacheHeadroom;

				case 3511233232:
					return WaveCachePruneTimeLimit;

				case 2616589264:
					return WaveCacheRsxSize;

				case 535484713:
					return WaveCacheRsxPruneTimeLimit;

				case 3845970128:
					return WaveCacheMaxReadIssueCount;

				case 108029477:
					return WaveCacheMaxReadActiveCount;

				case 2039173245:
					return AudioCoreCpuLoadLimit;

				case 4028843115:
					return AudioCoreCpuLoadRecovery;

				case 4095311206:
					return AudioCoreThread;

				case 1467197950:
					return AudioCoreMixJobThreadCount;

				case 562156554:
					return AudioCoreMaxMixJobThreadCount;

				case 685226627:
					return MaxAudibleSoundCount;

				case 1771683297:
					return AudioCoreMinProcStageVoicesToGoWide;

				case 22362422:
					return DelayLineAllocSize;

				case 2086423929:
					return ReverbAllocSize;

				case 2281411509:
					return AudioCoreMultipleMixJobsEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 120676393:
					return typeof(AudioSettings).GetProperty(nameof(WaveCacheSize));

				case 2616055963:
					return typeof(AudioSettings).GetProperty(nameof(WaveCacheHeadroom));

				case 3511233232:
					return typeof(AudioSettings).GetProperty(nameof(WaveCachePruneTimeLimit));

				case 2616589264:
					return typeof(AudioSettings).GetProperty(nameof(WaveCacheRsxSize));

				case 535484713:
					return typeof(AudioSettings).GetProperty(nameof(WaveCacheRsxPruneTimeLimit));

				case 3845970128:
					return typeof(AudioSettings).GetProperty(nameof(WaveCacheMaxReadIssueCount));

				case 108029477:
					return typeof(AudioSettings).GetProperty(nameof(WaveCacheMaxReadActiveCount));

				case 2039173245:
					return typeof(AudioSettings).GetProperty(nameof(AudioCoreCpuLoadLimit));

				case 4028843115:
					return typeof(AudioSettings).GetProperty(nameof(AudioCoreCpuLoadRecovery));

				case 4095311206:
					return typeof(AudioSettings).GetProperty(nameof(AudioCoreThread));

				case 1467197950:
					return typeof(AudioSettings).GetProperty(nameof(AudioCoreMixJobThreadCount));

				case 562156554:
					return typeof(AudioSettings).GetProperty(nameof(AudioCoreMaxMixJobThreadCount));

				case 685226627:
					return typeof(AudioSettings).GetProperty(nameof(MaxAudibleSoundCount));

				case 1771683297:
					return typeof(AudioSettings).GetProperty(nameof(AudioCoreMinProcStageVoicesToGoWide));

				case 22362422:
					return typeof(AudioSettings).GetProperty(nameof(DelayLineAllocSize));

				case 2086423929:
					return typeof(AudioSettings).GetProperty(nameof(ReverbAllocSize));

				case 2281411509:
					return typeof(AudioSettings).GetProperty(nameof(AudioCoreMultipleMixJobsEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
