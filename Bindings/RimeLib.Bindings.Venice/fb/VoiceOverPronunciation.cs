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
	[ContainerType(4, 24)]
	public class VoiceOverPronunciation : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public CtrRef<AudioLanguage> PrimaryLanguage { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<AudioLanguage> SecondaryLanguage { get; set; } = new();

		[ContainerField(20)]
		public VoiceOverPronunciationFallback SecondaryFallback { get; set; } = new();

		public static void Deserialize(VoiceOverPronunciation p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.PrimaryLanguage.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SecondaryLanguage.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SecondaryFallback = (VoiceOverPronunciationFallback) p_Reader.ReadInt32();
		}

	}
}
