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
public class VoiceOverManuscriptAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<AudioLanguage> MasterLanguage { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<VoiceOverLanguageRoot> Languages { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public VoiceOverWaveNameTranslation NameTranslation { get; set; } = VoiceOverWaveNameTranslation.VoiceOverWaveNameTranslation_FullName;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint VariationUnderscoreCount { get; set; } = 1;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string StringIdColumn { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string FileNameColumn { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string PathColumn { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string WaveAssetStatusColumn { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string SheetName { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string VoiceColumn { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string CharacterColumn { get; set; } = string.Empty;
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<VoiceOverManuscriptLanguageColumns> LanguageColumns { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public int FirstContentRow { get; set; } = 2;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public string StringIdPrefix { get; set; } = string.Empty;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public string OutputPath { get; set; } = string.Empty;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public bool KeepPath { get; set; } = false;
	
	[ContainerField(0x89), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
	public bool StringIdUpperCase { get; set; } = true;
	
	[ContainerField(0x8a), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
	public bool AllowDelete { get; set; } = false;
	
	[ContainerField(0x8b), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
	public bool EnableSubtitles { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(MasterLanguage));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Languages = p_EbxWriter.GetArrayWriter(Languages.GetType(), Languages.Count);
		p_Writer.Write(s_Languages.ArrayIndex);
		foreach (var s_Entry in Languages)
		{
			s_Languages.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) NameTranslation);
		p_Writer.Write(VariationUnderscoreCount);
		p_Writer.Write(p_EbxWriter.WriteString(StringIdColumn));
		p_Writer.Write(p_EbxWriter.WriteString(FileNameColumn));
		p_Writer.Write(p_EbxWriter.WriteString(PathColumn));
		p_Writer.Write(p_EbxWriter.WriteString(WaveAssetStatusColumn));
		p_Writer.Write(p_EbxWriter.WriteString(SheetName));
		p_Writer.Write(p_EbxWriter.WriteString(VoiceColumn));
		p_Writer.Write(p_EbxWriter.WriteString(CharacterColumn));
		(RimeWriter Writer, uint ArrayIndex) s_LanguageColumns = p_EbxWriter.GetArrayWriter(LanguageColumns.GetType(), LanguageColumns.Count);
		p_Writer.Write(s_LanguageColumns.ArrayIndex);
		foreach (var s_Entry in LanguageColumns)
		{
			s_Entry.Serialize(s_LanguageColumns.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FirstContentRow);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(StringIdPrefix));
		p_Writer.Write(p_EbxWriter.WriteString(OutputPath));
		p_Writer.Write(KeepPath);
		p_Writer.Write(StringIdUpperCase);
		p_Writer.Write(AllowDelete);
		p_Writer.Write(EnableSubtitles);
		p_Writer.WriteNullBytes(4);
	}
}

