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
	[ContainerType(4, 20)]
	public class MixerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public List<CtrRef<MixerEntry>> Entries { get; set; } = new();

		[ContainerField(12)]
		public AudioGraphNodePort Out { get; set; } = new();

		public static void Deserialize(MixerNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Entries.Clear();
			(RimeReader Reader, uint Count) s_Entries = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Entries.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MixerEntry>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Entries.Reader.ReadUInt32()));
				p_Instance.Entries.Add(s_CtrRef);
			}
			
			s_Entries.Reader.Dispose();
			fb.AudioGraphNodePort.Deserialize(p_Instance.Out, p_Reader, p_Parser);
		}

	}
}
