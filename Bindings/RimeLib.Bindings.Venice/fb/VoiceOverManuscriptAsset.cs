///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VoiceOverManuscriptAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<AudioLanguage> MasterLanguage { get; set; } = new CtrRef<AudioLanguage>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<VoiceOverLanguageRoot> Languages { get; set; } = new RefArray<VoiceOverLanguageRoot>(); // 0x10 (16)
		
		[ContainerField(20)]
		public VoiceOverWaveNameTranslation NameTranslation { get; set; } = new VoiceOverWaveNameTranslation(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string SheetName { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string StringIdColumn { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable]
		public string FileNameColumn { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string PathColumn { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable]
		public string WaveAssetStatusColumn { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable]
		public string CharacterColumn { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable]
		public string VoiceColumn { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable]
		public string StringIdPrefix { get; set; } // 0x34 (52)
		
		[ContainerField(56)]
		public List<VoiceOverManuscriptLanguageColumns> LanguageColumns { get; set; } = new List<VoiceOverManuscriptLanguageColumns>(); // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public int FirstContentRow { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable]
		public string OutputPath { get; set; } // 0x40 (64)
		
		[ContainerField(68)]
		public CtrRef<StreamPoolAsset> StreamPool { get; set; } = new CtrRef<StreamPoolAsset>(); // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool KeepPath { get; set; } // 0x48 (72)
		
		[ContainerField(73), LayoutImmutable, Blittable]
		public bool StringIdUpperCase { get; set; } // 0x49 (73)
		
		[ContainerField(74), LayoutImmutable, Blittable]
		public bool AllowDelete { get; set; } // 0x4A (74)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1351373419:
					MasterLanguage = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 3231948516:
					Languages = (RefArray<VoiceOverLanguageRoot>) p_Value;
					break;

				case 3008262953:
					NameTranslation = (VoiceOverWaveNameTranslation) Enum.ToObject(typeof(VoiceOverWaveNameTranslation), p_Value);
					break;

				case 1655714573:
					SheetName = (string) p_Value;
					break;

				case 2316948715:
					StringIdColumn = (string) p_Value;
					break;

				case 30584978:
					FileNameColumn = (string) p_Value;
					break;

				case 1657585950:
					PathColumn = (string) p_Value;
					break;

				case 355976178:
					WaveAssetStatusColumn = (string) p_Value;
					break;

				case 2622712842:
					CharacterColumn = (string) p_Value;
					break;

				case 3950839045:
					VoiceColumn = (string) p_Value;
					break;

				case 1766158509:
					StringIdPrefix = (string) p_Value;
					break;

				case 1806550354:
					LanguageColumns = (List<VoiceOverManuscriptLanguageColumns>) p_Value;
					break;

				case 1758802268:
					FirstContentRow = (int) p_Value;
					break;

				case 542834903:
					OutputPath = (string) p_Value;
					break;

				case 1617753829:
					StreamPool = (CtrRef<StreamPoolAsset>) p_Value;
					break;

				case 3967552211:
					KeepPath = (bool) p_Value;
					break;

				case 113383467:
					StringIdUpperCase = (bool) p_Value;
					break;

				case 3422513957:
					AllowDelete = (bool) p_Value;
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
				case 1351373419:
					return MasterLanguage;

				case 3231948516:
					return Languages;

				case 3008262953:
					return NameTranslation;

				case 1655714573:
					return SheetName;

				case 2316948715:
					return StringIdColumn;

				case 30584978:
					return FileNameColumn;

				case 1657585950:
					return PathColumn;

				case 355976178:
					return WaveAssetStatusColumn;

				case 2622712842:
					return CharacterColumn;

				case 3950839045:
					return VoiceColumn;

				case 1766158509:
					return StringIdPrefix;

				case 1806550354:
					return LanguageColumns;

				case 1758802268:
					return FirstContentRow;

				case 542834903:
					return OutputPath;

				case 1617753829:
					return StreamPool;

				case 3967552211:
					return KeepPath;

				case 113383467:
					return StringIdUpperCase;

				case 3422513957:
					return AllowDelete;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1351373419:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(MasterLanguage));

				case 3231948516:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(Languages));

				case 3008262953:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(NameTranslation));

				case 1655714573:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(SheetName));

				case 2316948715:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(StringIdColumn));

				case 30584978:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(FileNameColumn));

				case 1657585950:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(PathColumn));

				case 355976178:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(WaveAssetStatusColumn));

				case 2622712842:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(CharacterColumn));

				case 3950839045:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(VoiceColumn));

				case 1766158509:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(StringIdPrefix));

				case 1806550354:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(LanguageColumns));

				case 1758802268:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(FirstContentRow));

				case 542834903:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(OutputPath));

				case 1617753829:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(StreamPool));

				case 3967552211:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(KeepPath));

				case 113383467:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(StringIdUpperCase));

				case 3422513957:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(AllowDelete));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
