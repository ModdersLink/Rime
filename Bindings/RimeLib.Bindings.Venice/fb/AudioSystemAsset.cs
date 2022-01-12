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
	[ContainerType(4, 68)]
	public class AudioSystemAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<SoundMasterPatchAsset> MasterPatch { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<SoundWaveAsset> DefaultWave { get; set; } = new();

		[ContainerField(20)]
		public RefArray<StreamPoolAsset> StreamPools { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint SampleRate { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float SoundSpeed { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float DopplerFactor { get; set; }

		[ContainerField(36)]
		public CtrRef<SoundTestAsset> Tests { get; set; } = new();

		[ContainerField(40)]
		public CtrRef<MixerSystemAsset> MixerSystem { get; set; } = new();

		[ContainerField(44)]
		public RefArray<AudioLanguage> Languages { get; set; } = new();

		[ContainerField(48)]
		public RefArray<AudioLanguageSetting> LanguageSettings { get; set; } = new();

		[ContainerField(52)]
		public CtrRef<AudioLanguage> DefaultLanguage { get; set; } = new();

		[ContainerField(56)]
		public RefArray<SoundScopeData> Scopes { get; set; } = new();

		[ContainerField(60)]
		public RefArray<SoundScopeStrategyData> ScopeStrategies { get; set; } = new();

		[ContainerField(64)]
		public RefArray<SoundScopeSetupData> ScopeSetups { get; set; } = new();

	}
}
