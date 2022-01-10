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
	[ContainerType(4, 24)]
	public class LogicalExpressionNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public List<CtrRef<LogicalExpressionEntry>> Inputs { get; set; } = new();

		[ContainerField(12)]
		public AudioGraphNodePort Trigger { get; set; } = new();

		[ContainerField(20)]
		public LogicalExpressionOperator Operator { get; set; } = new();

		public static void Deserialize(LogicalExpressionNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Inputs.Clear();
			(RimeReader Reader, uint Count) s_Inputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Inputs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<LogicalExpressionEntry>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Inputs.Reader.ReadUInt32()));
				p_Instance.Inputs.Add(s_CtrRef);
			}
			
			s_Inputs.Reader.Dispose();
			fb.AudioGraphNodePort.Deserialize(p_Instance.Trigger, p_Reader, p_Parser);
			p_Instance.Operator = (LogicalExpressionOperator) p_Reader.ReadInt32();
		}

	}
}
