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
	[ContainerType(4, 24)]
	public partial class LogicalExpressionNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<LogicalExpressionEntry> _Inputs = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AudioGraphNodePort _Trigger = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private LogicalExpressionOperator _Operator = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Inputs = p_EbxWriter.GetArrayWriter(Inputs.GetType(), Inputs.Count);
			p_Writer.Write(s_Inputs.ArrayIndex);
			foreach (var s_Entry in Inputs)
			{
				s_Inputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			Trigger.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Operator);
		}
	}
}
