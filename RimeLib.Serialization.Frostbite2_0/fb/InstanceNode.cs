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
	[ContainerType(4, 32)]
	public partial class InstanceNode :
		UINodeData
	{
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<UIGraphAsset> _UIGraph = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private RefArray<UINodePort> _Inputs = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private RefArray<UINodePort> _Outputs = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(UIGraph));
			(RimeWriter Writer, uint ArrayIndex) s_Inputs = p_EbxWriter.GetArrayWriter(Inputs.GetType(), Inputs.Count);
			p_Writer.Write(s_Inputs.ArrayIndex);
			foreach (var s_Entry in Inputs)
			{
				s_Inputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
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
