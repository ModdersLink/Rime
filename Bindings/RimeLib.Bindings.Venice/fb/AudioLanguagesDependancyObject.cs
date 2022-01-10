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
	[ContainerType(4, 12)]
	public class AudioLanguagesDependancyObject : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<AudioLanguage>> AudioLanguages { get; set; } = new();

		public static void Deserialize(AudioLanguagesDependancyObject p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.AudioLanguages.Clear();
			(RimeReader Reader, uint Count) s_AudioLanguages = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AudioLanguages.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioLanguage>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_AudioLanguages.Reader.ReadUInt32()));
				p_Instance.AudioLanguages.Add(s_CtrRef);
			}
			
			s_AudioLanguages.Reader.Dispose();
		}

	}
}
