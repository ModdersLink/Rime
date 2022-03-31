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

namespace fb
{
	[ContainerType(4, 44)]
	public class MinMaxValueSelectorNodeData :
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<MinMaxValueSelectorEntry> Inputs { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public AudioGraphNodePort MaxValue { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public AudioGraphNodePort MaxIndex { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public AudioGraphNodePort MinValue { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public AudioGraphNodePort MinIndex { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Inputs = p_EbxWriter.GetArrayWriter(Inputs.GetType(), Inputs.Count);
			p_Writer.Write(s_Inputs.ArrayIndex);
			foreach (var s_Entry in Inputs)
			{
				s_Inputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			MaxValue.Serialize(p_Writer, p_EbxWriter);
			MaxIndex.Serialize(p_Writer, p_EbxWriter);
			MinValue.Serialize(p_Writer, p_EbxWriter);
			MinIndex.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
