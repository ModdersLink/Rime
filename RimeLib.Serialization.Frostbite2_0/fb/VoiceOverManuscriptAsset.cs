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
	public partial class VoiceOverManuscriptAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<AudioLanguage> _MasterLanguage = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<VoiceOverLanguageRoot> _Languages = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private VoiceOverWaveNameTranslation _NameTranslation = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _SheetName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _StringIdColumn = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _FileNameColumn = string.Empty;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _PathColumn = string.Empty;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		private string _WaveAssetStatusColumn = string.Empty;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		private string _CharacterColumn = string.Empty;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		private string _VoiceColumn = string.Empty;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		private string _StringIdPrefix = string.Empty;

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private List<VoiceOverManuscriptLanguageColumns> _LanguageColumns = new();

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private int _FirstContentRow;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, JsonProperty(Order = 64)]
		private string _OutputPath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private CtrRef<StreamPoolAsset> _StreamPool = new();

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private bool _KeepPath;

		[ObservableProperty]
		[property: ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		private bool _StringIdUpperCase;

		[ObservableProperty]
		[property: ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		private bool _AllowDelete;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(MasterLanguage));
			(RimeWriter Writer, uint ArrayIndex) s_Languages = p_EbxWriter.GetArrayWriter(Languages.GetType(), Languages.Count);
			p_Writer.Write(s_Languages.ArrayIndex);
			foreach (var s_Entry in Languages)
			{
				s_Languages.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) NameTranslation);
			p_Writer.Write(p_EbxWriter.WriteString(SheetName));
			p_Writer.Write(p_EbxWriter.WriteString(StringIdColumn));
			p_Writer.Write(p_EbxWriter.WriteString(FileNameColumn));
			p_Writer.Write(p_EbxWriter.WriteString(PathColumn));
			p_Writer.Write(p_EbxWriter.WriteString(WaveAssetStatusColumn));
			p_Writer.Write(p_EbxWriter.WriteString(CharacterColumn));
			p_Writer.Write(p_EbxWriter.WriteString(VoiceColumn));
			p_Writer.Write(p_EbxWriter.WriteString(StringIdPrefix));
			(RimeWriter Writer, uint ArrayIndex) s_LanguageColumns = p_EbxWriter.GetArrayWriter(LanguageColumns.GetType(), LanguageColumns.Count);
			p_Writer.Write(s_LanguageColumns.ArrayIndex);
			foreach (var s_Entry in LanguageColumns)
			{
				s_Entry.Serialize(s_LanguageColumns.Writer, p_EbxWriter);
			}
			p_Writer.Write(FirstContentRow);
			p_Writer.Write(p_EbxWriter.WriteString(OutputPath));
			p_Writer.Write(p_EbxWriter.WriteImport(StreamPool));
			p_Writer.Write(KeepPath);
			p_Writer.Write(StringIdUpperCase);
			p_Writer.Write(AllowDelete);
			p_Writer.WriteNullBytes(1);
		}
	}
}
