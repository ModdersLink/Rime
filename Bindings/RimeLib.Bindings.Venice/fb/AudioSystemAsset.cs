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
	public class AudioSystemAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<SoundMasterPatchAsset> MasterPatch { get; set; } = new CtrRef<SoundMasterPatchAsset>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<SoundWaveAsset> DefaultWave { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<StreamPoolAsset> StreamPools { get; set; } = new RefArray<StreamPoolAsset>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint SampleRate { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float SoundSpeed { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float DopplerFactor { get; set; } // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<SoundTestAsset> Tests { get; set; } = new CtrRef<SoundTestAsset>(); // 0x24 (36)
		
		[ContainerField(40)]
		public CtrRef<MixerSystemAsset> MixerSystem { get; set; } = new CtrRef<MixerSystemAsset>(); // 0x28 (40)
		
		[ContainerField(44)]
		public RefArray<AudioLanguage> Languages { get; set; } = new RefArray<AudioLanguage>(); // 0x2C (44)
		
		[ContainerField(48)]
		public RefArray<AudioLanguageSetting> LanguageSettings { get; set; } = new RefArray<AudioLanguageSetting>(); // 0x30 (48)
		
		[ContainerField(52)]
		public CtrRef<AudioLanguage> DefaultLanguage { get; set; } = new CtrRef<AudioLanguage>(); // 0x34 (52)
		
		[ContainerField(56)]
		public RefArray<SoundScopeData> Scopes { get; set; } = new RefArray<SoundScopeData>(); // 0x38 (56)
		
		[ContainerField(60)]
		public RefArray<SoundScopeStrategyData> ScopeStrategies { get; set; } = new RefArray<SoundScopeStrategyData>(); // 0x3C (60)
		
		[ContainerField(64)]
		public RefArray<SoundScopeSetupData> ScopeSetups { get; set; } = new RefArray<SoundScopeSetupData>(); // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1109008247:
					MasterPatch = (CtrRef<SoundMasterPatchAsset>) p_Value;
					break;

				case 2015103915:
					DefaultWave = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 1846268918:
					StreamPools = (RefArray<StreamPoolAsset>) p_Value;
					break;

				case 604757697:
					SampleRate = (uint) p_Value;
					break;

				case 124014113:
					SoundSpeed = (float) p_Value;
					break;

				case 1757845912:
					DopplerFactor = (float) p_Value;
					break;

				case 227718400:
					Tests = (CtrRef<SoundTestAsset>) p_Value;
					break;

				case 1057148587:
					MixerSystem = (CtrRef<MixerSystemAsset>) p_Value;
					break;

				case 3231948516:
					Languages = (RefArray<AudioLanguage>) p_Value;
					break;

				case 689864818:
					LanguageSettings = (RefArray<AudioLanguageSetting>) p_Value;
					break;

				case 1869348380:
					DefaultLanguage = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 3335461020:
					Scopes = (RefArray<SoundScopeData>) p_Value;
					break;

				case 3410651026:
					ScopeStrategies = (RefArray<SoundScopeStrategyData>) p_Value;
					break;

				case 341454043:
					ScopeSetups = (RefArray<SoundScopeSetupData>) p_Value;
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
				case 1109008247:
					return MasterPatch;

				case 2015103915:
					return DefaultWave;

				case 1846268918:
					return StreamPools;

				case 604757697:
					return SampleRate;

				case 124014113:
					return SoundSpeed;

				case 1757845912:
					return DopplerFactor;

				case 227718400:
					return Tests;

				case 1057148587:
					return MixerSystem;

				case 3231948516:
					return Languages;

				case 689864818:
					return LanguageSettings;

				case 1869348380:
					return DefaultLanguage;

				case 3335461020:
					return Scopes;

				case 3410651026:
					return ScopeStrategies;

				case 341454043:
					return ScopeSetups;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1109008247:
					return typeof(AudioSystemAsset).GetProperty(nameof(MasterPatch));

				case 2015103915:
					return typeof(AudioSystemAsset).GetProperty(nameof(DefaultWave));

				case 1846268918:
					return typeof(AudioSystemAsset).GetProperty(nameof(StreamPools));

				case 604757697:
					return typeof(AudioSystemAsset).GetProperty(nameof(SampleRate));

				case 124014113:
					return typeof(AudioSystemAsset).GetProperty(nameof(SoundSpeed));

				case 1757845912:
					return typeof(AudioSystemAsset).GetProperty(nameof(DopplerFactor));

				case 227718400:
					return typeof(AudioSystemAsset).GetProperty(nameof(Tests));

				case 1057148587:
					return typeof(AudioSystemAsset).GetProperty(nameof(MixerSystem));

				case 3231948516:
					return typeof(AudioSystemAsset).GetProperty(nameof(Languages));

				case 689864818:
					return typeof(AudioSystemAsset).GetProperty(nameof(LanguageSettings));

				case 1869348380:
					return typeof(AudioSystemAsset).GetProperty(nameof(DefaultLanguage));

				case 3335461020:
					return typeof(AudioSystemAsset).GetProperty(nameof(Scopes));

				case 3410651026:
					return typeof(AudioSystemAsset).GetProperty(nameof(ScopeStrategies));

				case 341454043:
					return typeof(AudioSystemAsset).GetProperty(nameof(ScopeSetups));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
