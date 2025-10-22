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

[ContainerType(8, 144)]
public class AudioSystemAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<SoundMasterPatchAsset> MasterPatch { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<StreamPoolPreset> StreamPoolPresets { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<StreamPoolPreset> DefaultStreamPoolPreset { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<SoundDataPolicy> DataPolicies { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint SampleRate { get; set; } = 48000;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<SoundTestAsset> Tests { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<MixerSystemAsset> MixerSystem { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public RefArray<AudioLanguage> Languages { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public RefArray<AudioLanguageSetting> LanguageSettings { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<AudioLanguage> DefaultLanguage { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public RefArray<SoundScopeData> Scopes { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public RefArray<SoundScopeStrategyData> ScopeStrategies { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public RefArray<SoundScopeSetupData> ScopeSetups { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public RefArray<HdrSetting> HdrSettings { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<HdrSetting> DefaultHdrSetting { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(MasterPatch));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_StreamPoolPresets = p_EbxWriter.GetArrayWriter(StreamPoolPresets.GetType(), StreamPoolPresets.Count);
		p_Writer.Write(s_StreamPoolPresets.ArrayIndex);
		foreach (var s_Entry in StreamPoolPresets)
		{
			s_StreamPoolPresets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultStreamPoolPreset));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_DataPolicies = p_EbxWriter.GetArrayWriter(DataPolicies.GetType(), DataPolicies.Count);
		p_Writer.Write(s_DataPolicies.ArrayIndex);
		foreach (var s_Entry in DataPolicies)
		{
			s_DataPolicies.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SampleRate);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Tests));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MixerSystem));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Languages = p_EbxWriter.GetArrayWriter(Languages.GetType(), Languages.Count);
		p_Writer.Write(s_Languages.ArrayIndex);
		foreach (var s_Entry in Languages)
		{
			s_Languages.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LanguageSettings = p_EbxWriter.GetArrayWriter(LanguageSettings.GetType(), LanguageSettings.Count);
		p_Writer.Write(s_LanguageSettings.ArrayIndex);
		foreach (var s_Entry in LanguageSettings)
		{
			s_LanguageSettings.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultLanguage));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Scopes = p_EbxWriter.GetArrayWriter(Scopes.GetType(), Scopes.Count);
		p_Writer.Write(s_Scopes.ArrayIndex);
		foreach (var s_Entry in Scopes)
		{
			s_Scopes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ScopeStrategies = p_EbxWriter.GetArrayWriter(ScopeStrategies.GetType(), ScopeStrategies.Count);
		p_Writer.Write(s_ScopeStrategies.ArrayIndex);
		foreach (var s_Entry in ScopeStrategies)
		{
			s_ScopeStrategies.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ScopeSetups = p_EbxWriter.GetArrayWriter(ScopeSetups.GetType(), ScopeSetups.Count);
		p_Writer.Write(s_ScopeSetups.ArrayIndex);
		foreach (var s_Entry in ScopeSetups)
		{
			s_ScopeSetups.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_HdrSettings = p_EbxWriter.GetArrayWriter(HdrSettings.GetType(), HdrSettings.Count);
		p_Writer.Write(s_HdrSettings.ArrayIndex);
		foreach (var s_Entry in HdrSettings)
		{
			s_HdrSettings.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultHdrSetting));
		p_Writer.WriteNullBytes(4);
	}
}

