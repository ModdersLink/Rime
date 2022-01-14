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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 68)]
	public class AudioSystemAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SoundMasterPatchAsset> MasterPatch { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<SoundWaveAsset> DefaultWave { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<StreamPoolAsset> StreamPools { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint SampleRate { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float SoundSpeed { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float DopplerFactor { get; set; }

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<SoundTestAsset> Tests { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<MixerSystemAsset> MixerSystem { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public RefArray<AudioLanguage> Languages { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public RefArray<AudioLanguageSetting> LanguageSettings { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public CtrRef<AudioLanguage> DefaultLanguage { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public RefArray<SoundScopeData> Scopes { get; set; } = new();

		[ContainerField(60), JsonProperty(Order = 60)]
		public RefArray<SoundScopeStrategyData> ScopeStrategies { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public RefArray<SoundScopeSetupData> ScopeSetups { get; set; } = new();

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
