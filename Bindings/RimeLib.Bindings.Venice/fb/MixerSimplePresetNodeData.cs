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
	public class MixerSimplePresetNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Index { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<MixerPreset>> Presets { get; set; } = new();

		public static void Deserialize(MixerSimplePresetNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Index, p_Reader, p_Parser);
			p_Instance.Presets.Clear();
			(RimeReader Reader, uint Count) s_Presets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Presets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MixerPreset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Presets.Reader.ReadUInt32()));
				p_Instance.Presets.Add(s_CtrRef);
			}
			
			s_Presets.Reader.Dispose();
		}

	}
}
