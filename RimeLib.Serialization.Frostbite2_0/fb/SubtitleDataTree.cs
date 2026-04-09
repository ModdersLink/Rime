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
	[ContainerType(4, 16)]
	public partial class SubtitleDataTree :
		TreeBase
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<SubtitleMainDataNode> _Subtitles = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Subtitles = p_EbxWriter.GetArrayWriter(Subtitles.GetType(), Subtitles.Count);
			p_Writer.Write(s_Subtitles.ArrayIndex);
			foreach (var s_Entry in Subtitles)
			{
				s_Subtitles.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
