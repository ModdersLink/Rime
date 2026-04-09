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
	[ContainerType(4, 44)]
	public partial class MinMaxValueSelectorNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<MinMaxValueSelectorEntry> _Inputs = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AudioGraphNodePort _MaxValue = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AudioGraphNodePort _MaxIndex = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AudioGraphNodePort _MinValue = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AudioGraphNodePort _MinIndex = new();

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
