///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class DataStepNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<UINodePort> Out { get; set; } = new();

		[ContainerField(28)]
		public List<float> Steps { get; set; } = new();

		[ContainerField(32)]
		public UIDataSourceInfo CurrentStepDataSource { get; set; } = new();

		[ContainerField(48)]
		public UIDataSourceInfo DataSource { get; set; } = new();

		public static void Deserialize(DataStepNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.In.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Out.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Steps.Clear();
			(RimeReader Reader, uint Count) s_Steps = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Steps.Count; ++i)
			{
				var s_Value = s_Steps.Reader.ReadSingle();
				p_Instance.Steps.Add(s_Value);
			}
			
			s_Steps.Reader.Dispose();
			fb.UIDataSourceInfo.Deserialize(p_Instance.CurrentStepDataSource, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.DataSource, p_Reader, p_Parser);
		}

	}
}
