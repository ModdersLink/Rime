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
	[ContainerType(4, 64)]
	public class DataStepNode :
		UINodeData
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<UINodePort> Out { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public List<float> Steps { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public UIDataSourceInfo CurrentStepDataSource { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public UIDataSourceInfo DataSource { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(In));
			p_Writer.Write(p_EbxWriter.WriteImport(Out));
			(RimeWriter Writer, uint ArrayIndex) s_Steps = p_EbxWriter.GetArrayWriter(Steps.GetType(), Steps.Count);
			p_Writer.Write(s_Steps.ArrayIndex);
			foreach (var s_Entry in Steps)
			{
				s_Steps.Writer.Write(s_Entry);
			}
			CurrentStepDataSource.Serialize(p_Writer, p_EbxWriter);
			DataSource.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
