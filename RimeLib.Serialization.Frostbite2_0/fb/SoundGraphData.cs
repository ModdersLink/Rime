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
	[ContainerType(4, 68)]
	public partial class SoundGraphData :
		AudioGraphData
	{
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private SoundGraphInfo _Info = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private RefArray<AudioGraphParameter> _InputParameters = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private RefArray<AudioGraphParameter> _OutputParameters = new();

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private RefArray<AudioGraphEvent> _InputEvents = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private RefArray<AudioGraphEvent> _OutputEvents = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Info.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_InputParameters = p_EbxWriter.GetArrayWriter(InputParameters.GetType(), InputParameters.Count);
			p_Writer.Write(s_InputParameters.ArrayIndex);
			foreach (var s_Entry in InputParameters)
			{
				s_InputParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_OutputParameters = p_EbxWriter.GetArrayWriter(OutputParameters.GetType(), OutputParameters.Count);
			p_Writer.Write(s_OutputParameters.ArrayIndex);
			foreach (var s_Entry in OutputParameters)
			{
				s_OutputParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_InputEvents = p_EbxWriter.GetArrayWriter(InputEvents.GetType(), InputEvents.Count);
			p_Writer.Write(s_InputEvents.ArrayIndex);
			foreach (var s_Entry in InputEvents)
			{
				s_InputEvents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_OutputEvents = p_EbxWriter.GetArrayWriter(OutputEvents.GetType(), OutputEvents.Count);
			p_Writer.Write(s_OutputEvents.ArrayIndex);
			foreach (var s_Entry in OutputEvents)
			{
				s_OutputEvents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
