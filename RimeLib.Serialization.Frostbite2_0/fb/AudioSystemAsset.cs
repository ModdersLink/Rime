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
	[ContainerType(4, 68)]
	public partial class AudioSystemAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<SoundMasterPatchAsset> _MasterPatch = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<SoundWaveAsset> _DefaultWave = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<StreamPoolAsset> _StreamPools = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _SampleRate;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _SoundSpeed;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _DopplerFactor;

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private CtrRef<SoundTestAsset> _Tests = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CtrRef<MixerSystemAsset> _MixerSystem = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private RefArray<AudioLanguage> _Languages = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private RefArray<AudioLanguageSetting> _LanguageSettings = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private CtrRef<AudioLanguage> _DefaultLanguage = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private RefArray<SoundScopeData> _Scopes = new();

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private RefArray<SoundScopeStrategyData> _ScopeStrategies = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private RefArray<SoundScopeSetupData> _ScopeSetups = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(MasterPatch));
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultWave));
			(RimeWriter Writer, uint ArrayIndex) s_StreamPools = p_EbxWriter.GetArrayWriter(StreamPools.GetType(), StreamPools.Count);
			p_Writer.Write(s_StreamPools.ArrayIndex);
			foreach (var s_Entry in StreamPools)
			{
				s_StreamPools.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(SampleRate);
			p_Writer.Write(SoundSpeed);
			p_Writer.Write(DopplerFactor);
			p_Writer.Write(p_EbxWriter.WriteImport(Tests));
			p_Writer.Write(p_EbxWriter.WriteImport(MixerSystem));
			(RimeWriter Writer, uint ArrayIndex) s_Languages = p_EbxWriter.GetArrayWriter(Languages.GetType(), Languages.Count);
			p_Writer.Write(s_Languages.ArrayIndex);
			foreach (var s_Entry in Languages)
			{
				s_Languages.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_LanguageSettings = p_EbxWriter.GetArrayWriter(LanguageSettings.GetType(), LanguageSettings.Count);
			p_Writer.Write(s_LanguageSettings.ArrayIndex);
			foreach (var s_Entry in LanguageSettings)
			{
				s_LanguageSettings.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultLanguage));
			(RimeWriter Writer, uint ArrayIndex) s_Scopes = p_EbxWriter.GetArrayWriter(Scopes.GetType(), Scopes.Count);
			p_Writer.Write(s_Scopes.ArrayIndex);
			foreach (var s_Entry in Scopes)
			{
				s_Scopes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_ScopeStrategies = p_EbxWriter.GetArrayWriter(ScopeStrategies.GetType(), ScopeStrategies.Count);
			p_Writer.Write(s_ScopeStrategies.ArrayIndex);
			foreach (var s_Entry in ScopeStrategies)
			{
				s_ScopeStrategies.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_ScopeSetups = p_EbxWriter.GetArrayWriter(ScopeSetups.GetType(), ScopeSetups.Count);
			p_Writer.Write(s_ScopeSetups.ArrayIndex);
			foreach (var s_Entry in ScopeSetups)
			{
				s_ScopeSetups.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
