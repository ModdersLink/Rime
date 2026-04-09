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
	public partial class VoiceOverLabelNode :
		VoiceOverExpressionNode
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<VoiceOverLabelSource> _Sources = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<VoiceOverValue> _False = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<VoiceOverValue> _True = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<VoiceOverLabel> _WantedLabels = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private RefArray<VoiceOverLabel> _UnwantedLabels = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private VoiceOverLabelSourceMode _SourceMode = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private VoiceOverLabelCompareMode _WantedCompareMode = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private VoiceOverLabelCompareMode _UnwantedCompareMode = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Sources = p_EbxWriter.GetArrayWriter(Sources.GetType(), Sources.Count);
			p_Writer.Write(s_Sources.ArrayIndex);
			foreach (var s_Entry in Sources)
			{
				s_Sources.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(False));
			p_Writer.Write(p_EbxWriter.WriteImport(True));
			(RimeWriter Writer, uint ArrayIndex) s_WantedLabels = p_EbxWriter.GetArrayWriter(WantedLabels.GetType(), WantedLabels.Count);
			p_Writer.Write(s_WantedLabels.ArrayIndex);
			foreach (var s_Entry in WantedLabels)
			{
				s_WantedLabels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_UnwantedLabels = p_EbxWriter.GetArrayWriter(UnwantedLabels.GetType(), UnwantedLabels.Count);
			p_Writer.Write(s_UnwantedLabels.ArrayIndex);
			foreach (var s_Entry in UnwantedLabels)
			{
				s_UnwantedLabels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) SourceMode);
			p_Writer.Write((int) WantedCompareMode);
			p_Writer.Write((int) UnwantedCompareMode);
		}
	}
}
