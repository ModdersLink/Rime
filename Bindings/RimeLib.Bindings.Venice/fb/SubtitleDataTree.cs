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
	[ContainerType(4, 16)]
	public class SubtitleDataTree : 
		TreeBase
	{
		[ContainerField(12)]
		public List<CtrRef<SubtitleMainDataNode>> Subtitles { get; set; } = new();

		public static void Deserialize(SubtitleDataTree p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Subtitles.Clear();
			(RimeReader Reader, uint Count) s_Subtitles = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Subtitles.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SubtitleMainDataNode>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Subtitles.Reader.ReadUInt32()));
				p_Instance.Subtitles.Add(s_CtrRef);
			}
			
			s_Subtitles.Reader.Dispose();
		}

	}
}
