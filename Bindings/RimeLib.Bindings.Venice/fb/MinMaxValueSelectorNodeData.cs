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
	[ContainerType(4, 44)]
	public class MinMaxValueSelectorNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public List<CtrRef<MinMaxValueSelectorEntry>> Inputs { get; set; } = new();

		[ContainerField(12)]
		public AudioGraphNodePort MaxValue { get; set; } = new();

		[ContainerField(20)]
		public AudioGraphNodePort MaxIndex { get; set; } = new();

		[ContainerField(28)]
		public AudioGraphNodePort MinValue { get; set; } = new();

		[ContainerField(36)]
		public AudioGraphNodePort MinIndex { get; set; } = new();

		public static void Deserialize(MinMaxValueSelectorNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Inputs.Clear();
			(RimeReader Reader, uint Count) s_Inputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Inputs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MinMaxValueSelectorEntry>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Inputs.Reader.ReadUInt32()));
				p_Instance.Inputs.Add(s_CtrRef);
			}
			
			s_Inputs.Reader.Dispose();
			fb.AudioGraphNodePort.Deserialize(p_Instance.MaxValue, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.MaxIndex, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.MinValue, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.MinIndex, p_Reader, p_Parser);
		}

	}
}
