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
	[ContainerType(4, 28)]
	public class SimpleValueSelectorNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public List<float> OutValues { get; set; } = new();

		[ContainerField(12)]
		public AudioGraphNodePort Index { get; set; } = new();

		[ContainerField(20)]
		public AudioGraphNodePort Out { get; set; } = new();

		public static void Deserialize(SimpleValueSelectorNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.OutValues.Clear();
			(RimeReader Reader, uint Count) s_OutValues = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OutValues.Count; ++i)
			{
				var s_Value = s_OutValues.Reader.ReadSingle();
				p_Instance.OutValues.Add(s_Value);
			}
			
			s_OutValues.Reader.Dispose();
			fb.AudioGraphNodePort.Deserialize(p_Instance.Index, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Out, p_Reader, p_Parser);
		}

	}
}
