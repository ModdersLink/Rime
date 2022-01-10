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
	public class MixerAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<MixerGraphData> Graph { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<MixerPreset>> Presets { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<MixerPreset> DefaultPreset { get; set; } = new();

		public static void Deserialize(MixerAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Graph.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Presets.Clear();
			(RimeReader Reader, uint Count) s_Presets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Presets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MixerPreset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Presets.Reader.ReadUInt32()));
				p_Instance.Presets.Add(s_CtrRef);
			}
			
			s_Presets.Reader.Dispose();
			p_Instance.DefaultPreset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
