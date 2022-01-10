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
	[ContainerType(4, 40)]
	public class MixerGraphData : 
		AudioGraphData
	{
		[ContainerField(28)]
		public List<CtrRef<AudioGraphParameter>> Inputs { get; set; } = new();

		[ContainerField(32)]
		public List<MixerValueAccumulateMode> AccumulateModes { get; set; } = new();

		[ContainerField(36)]
		public List<CtrRef<AudioGraphParameter>> Outputs { get; set; } = new();

		public static void Deserialize(MixerGraphData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Inputs.Clear();
			(RimeReader Reader, uint Count) s_Inputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Inputs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioGraphParameter>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Inputs.Reader.ReadUInt32()));
				p_Instance.Inputs.Add(s_CtrRef);
			}
			
			s_Inputs.Reader.Dispose();
			p_Instance.AccumulateModes.Clear();
			(RimeReader Reader, uint Count) s_AccumulateModes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AccumulateModes.Count; ++i)
			{
				var s_Value = (MixerValueAccumulateMode) s_AccumulateModes.Reader.ReadInt32();
				p_Instance.AccumulateModes.Add(s_Value);
			}
			
			s_AccumulateModes.Reader.Dispose();
			p_Instance.Outputs.Clear();
			(RimeReader Reader, uint Count) s_Outputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Outputs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioGraphParameter>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Outputs.Reader.ReadUInt32()));
				p_Instance.Outputs.Add(s_CtrRef);
			}
			
			s_Outputs.Reader.Dispose();
		}

	}
}
