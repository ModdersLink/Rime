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
	[ContainerType(4, 40)]
	public partial class MixerGraphData :
		AudioGraphData
	{
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private RefArray<AudioGraphParameter> _Inputs = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private List<MixerValueAccumulateMode> _AccumulateModes = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private RefArray<AudioGraphParameter> _Outputs = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Inputs = p_EbxWriter.GetArrayWriter(Inputs.GetType(), Inputs.Count);
			p_Writer.Write(s_Inputs.ArrayIndex);
			foreach (var s_Entry in Inputs)
			{
				s_Inputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_AccumulateModes = p_EbxWriter.GetArrayWriter(AccumulateModes.GetType(), AccumulateModes.Count);
			p_Writer.Write(s_AccumulateModes.ArrayIndex);
			foreach (var s_Entry in AccumulateModes)
			{
				s_AccumulateModes.Writer.Write((int) s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_Outputs = p_EbxWriter.GetArrayWriter(Outputs.GetType(), Outputs.Count);
			p_Writer.Write(s_Outputs.ArrayIndex);
			foreach (var s_Entry in Outputs)
			{
				s_Outputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
