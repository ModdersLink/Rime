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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class VoiceOverManuscriptLanguageColumns : FrostbiteContainer
	{
		[ContainerField(Name: "Language", Offset: 0, NameHash: 3872303031, Flags: 53)]
		public CtrRef<AudioLanguage> Language { get; set; } = new CtrRef<AudioLanguage>(); // 0x0 (0)
		
		[ContainerField(Name: "TextColumn", Offset: 4, NameHash: 1804772878, Flags: 16509), LayoutImmutable]
		public string TextColumn { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "SubtitleOffsetColumn", Offset: 8, NameHash: 2288110330, Flags: 16509), LayoutImmutable]
		public string SubtitleOffsetColumn { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3872303031:
					Language = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 1804772878:
					TextColumn = (string) p_Value;
					break;

				case 2288110330:
					SubtitleOffsetColumn = (string) p_Value;
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
				case 3872303031:
					return Language;

				case 1804772878:
					return TextColumn;

				case 2288110330:
					return SubtitleOffsetColumn;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3872303031:
					return typeof(VoiceOverManuscriptLanguageColumns).GetProperty(nameof(Language));

				case 1804772878:
					return typeof(VoiceOverManuscriptLanguageColumns).GetProperty(nameof(TextColumn));

				case 2288110330:
					return typeof(VoiceOverManuscriptLanguageColumns).GetProperty(nameof(SubtitleOffsetColumn));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
