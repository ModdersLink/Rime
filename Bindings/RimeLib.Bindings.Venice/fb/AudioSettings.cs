///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(76), ContainerClass]
	public class AudioSettings : 
		DataContainer
	{
		protected uint m_WaveCacheSize = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(120676393)]
		public uint WaveCacheSize { get { return m_WaveCacheSize; } set { if (OnPropertyChanging("AudioSettings." + nameof(WaveCacheSize), this, m_WaveCacheSize, value)) m_WaveCacheSize = value; } } // 0x8 (8)
		
		protected uint m_WaveCacheHeadroom = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2616055963)]
		public uint WaveCacheHeadroom { get { return m_WaveCacheHeadroom; } set { if (OnPropertyChanging("AudioSettings." + nameof(WaveCacheHeadroom), this, m_WaveCacheHeadroom, value)) m_WaveCacheHeadroom = value; } } // 0xC (12)
		
		protected float m_WaveCachePruneTimeLimit = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3511233232)]
		public float WaveCachePruneTimeLimit { get { return m_WaveCachePruneTimeLimit; } set { if (OnPropertyChanging("AudioSettings." + nameof(WaveCachePruneTimeLimit), this, m_WaveCachePruneTimeLimit, value)) m_WaveCachePruneTimeLimit = value; } } // 0x10 (16)
		
		protected uint m_WaveCacheRsxSize = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2616589264)]
		public uint WaveCacheRsxSize { get { return m_WaveCacheRsxSize; } set { if (OnPropertyChanging("AudioSettings." + nameof(WaveCacheRsxSize), this, m_WaveCacheRsxSize, value)) m_WaveCacheRsxSize = value; } } // 0x14 (20)
		
		protected float m_WaveCacheRsxPruneTimeLimit = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(535484713)]
		public float WaveCacheRsxPruneTimeLimit { get { return m_WaveCacheRsxPruneTimeLimit; } set { if (OnPropertyChanging("AudioSettings." + nameof(WaveCacheRsxPruneTimeLimit), this, m_WaveCacheRsxPruneTimeLimit, value)) m_WaveCacheRsxPruneTimeLimit = value; } } // 0x18 (24)
		
		protected uint m_WaveCacheMaxReadIssueCount = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3845970128)]
		public uint WaveCacheMaxReadIssueCount { get { return m_WaveCacheMaxReadIssueCount; } set { if (OnPropertyChanging("AudioSettings." + nameof(WaveCacheMaxReadIssueCount), this, m_WaveCacheMaxReadIssueCount, value)) m_WaveCacheMaxReadIssueCount = value; } } // 0x1C (28)
		
		protected uint m_WaveCacheMaxReadActiveCount = new uint();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(108029477)]
		public uint WaveCacheMaxReadActiveCount { get { return m_WaveCacheMaxReadActiveCount; } set { if (OnPropertyChanging("AudioSettings." + nameof(WaveCacheMaxReadActiveCount), this, m_WaveCacheMaxReadActiveCount, value)) m_WaveCacheMaxReadActiveCount = value; } } // 0x20 (32)
		
		protected float m_AudioCoreCpuLoadLimit = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2039173245)]
		public float AudioCoreCpuLoadLimit { get { return m_AudioCoreCpuLoadLimit; } set { if (OnPropertyChanging("AudioSettings." + nameof(AudioCoreCpuLoadLimit), this, m_AudioCoreCpuLoadLimit, value)) m_AudioCoreCpuLoadLimit = value; } } // 0x24 (36)
		
		protected float m_AudioCoreCpuLoadRecovery = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4028843115)]
		public float AudioCoreCpuLoadRecovery { get { return m_AudioCoreCpuLoadRecovery; } set { if (OnPropertyChanging("AudioSettings." + nameof(AudioCoreCpuLoadRecovery), this, m_AudioCoreCpuLoadRecovery, value)) m_AudioCoreCpuLoadRecovery = value; } } // 0x28 (40)
		
		protected int m_AudioCoreThread = new int();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4095311206)]
		public int AudioCoreThread { get { return m_AudioCoreThread; } set { if (OnPropertyChanging("AudioSettings." + nameof(AudioCoreThread), this, m_AudioCoreThread, value)) m_AudioCoreThread = value; } } // 0x2C (44)
		
		protected int m_AudioCoreMixJobThreadCount = new int();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1467197950)]
		public int AudioCoreMixJobThreadCount { get { return m_AudioCoreMixJobThreadCount; } set { if (OnPropertyChanging("AudioSettings." + nameof(AudioCoreMixJobThreadCount), this, m_AudioCoreMixJobThreadCount, value)) m_AudioCoreMixJobThreadCount = value; } } // 0x30 (48)
		
		protected int m_AudioCoreMaxMixJobThreadCount = new int();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(562156554)]
		public int AudioCoreMaxMixJobThreadCount { get { return m_AudioCoreMaxMixJobThreadCount; } set { if (OnPropertyChanging("AudioSettings." + nameof(AudioCoreMaxMixJobThreadCount), this, m_AudioCoreMaxMixJobThreadCount, value)) m_AudioCoreMaxMixJobThreadCount = value; } } // 0x34 (52)
		
		protected uint m_MaxAudibleSoundCount = new uint();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(685226627)]
		public uint MaxAudibleSoundCount { get { return m_MaxAudibleSoundCount; } set { if (OnPropertyChanging("AudioSettings." + nameof(MaxAudibleSoundCount), this, m_MaxAudibleSoundCount, value)) m_MaxAudibleSoundCount = value; } } // 0x38 (56)
		
		protected int m_AudioCoreMinProcStageVoicesToGoWide = new int();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1771683297)]
		public int AudioCoreMinProcStageVoicesToGoWide { get { return m_AudioCoreMinProcStageVoicesToGoWide; } set { if (OnPropertyChanging("AudioSettings." + nameof(AudioCoreMinProcStageVoicesToGoWide), this, m_AudioCoreMinProcStageVoicesToGoWide, value)) m_AudioCoreMinProcStageVoicesToGoWide = value; } } // 0x3C (60)
		
		protected uint m_DelayLineAllocSize = new uint();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(22362422)]
		public uint DelayLineAllocSize { get { return m_DelayLineAllocSize; } set { if (OnPropertyChanging("AudioSettings." + nameof(DelayLineAllocSize), this, m_DelayLineAllocSize, value)) m_DelayLineAllocSize = value; } } // 0x40 (64)
		
		protected uint m_ReverbAllocSize = new uint();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2086423929)]
		public uint ReverbAllocSize { get { return m_ReverbAllocSize; } set { if (OnPropertyChanging("AudioSettings." + nameof(ReverbAllocSize), this, m_ReverbAllocSize, value)) m_ReverbAllocSize = value; } } // 0x44 (68)
		
		protected bool m_AudioCoreMultipleMixJobsEnabled = new bool();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2281411509)]
		public bool AudioCoreMultipleMixJobsEnabled { get { return m_AudioCoreMultipleMixJobsEnabled; } set { if (OnPropertyChanging("AudioSettings." + nameof(AudioCoreMultipleMixJobsEnabled), this, m_AudioCoreMultipleMixJobsEnabled, value)) m_AudioCoreMultipleMixJobsEnabled = value; } } // 0x48 (72)
		
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
