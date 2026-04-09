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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 76)]
	public partial class AudioSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _WaveCacheSize;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _WaveCacheHeadroom;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _WaveCachePruneTimeLimit;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _WaveCacheRsxSize;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _WaveCacheRsxPruneTimeLimit;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _WaveCacheMaxReadIssueCount;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _WaveCacheMaxReadActiveCount;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _AudioCoreCpuLoadLimit;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _AudioCoreCpuLoadRecovery;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private int _AudioCoreThread;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private int _AudioCoreMixJobThreadCount;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private int _AudioCoreMaxMixJobThreadCount;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private uint _MaxAudibleSoundCount;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private int _AudioCoreMinProcStageVoicesToGoWide;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private uint _DelayLineAllocSize;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private uint _ReverbAllocSize;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private bool _AudioCoreMultipleMixJobsEnabled;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
