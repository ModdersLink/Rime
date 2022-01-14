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
	[ContainerType(4, 28)]
	public class SimpleValueSelectorNodeData :
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<float> OutValues { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public AudioGraphNodePort Index { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public AudioGraphNodePort Out { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_OutValues = p_EbxWriter.GetArrayWriter(OutValues.GetType(), OutValues.Count);
			p_Writer.Write(s_OutValues.ArrayIndex);
			foreach (var s_Entry in OutValues)
			{
				s_OutValues.Writer.Write(s_Entry);
			}
			Index.Serialize(p_Writer, p_EbxWriter);
			Out.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
