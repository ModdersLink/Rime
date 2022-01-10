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
	public class MixerPreset : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint NameHash { get; set; }

		[ContainerField(12)]
		public List<MixerPresetGroupData> Groups { get; set; } = new();

		[ContainerField(16)]
		public List<MixerPresetNodeData> Nodes { get; set; } = new();

		public static void Deserialize(MixerPreset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.NameHash = p_Reader.ReadUInt32();
			p_Instance.Groups.Clear();
			(RimeReader Reader, uint Count) s_Groups = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Groups.Count; ++i)
			{
				var s_Value = new MixerPresetGroupData();
				fb.MixerPresetGroupData.Deserialize(s_Value, s_Groups.Reader, p_Parser);
				p_Instance.Groups.Add(s_Value);
			}
			
			s_Groups.Reader.Dispose();
			p_Instance.Nodes.Clear();
			(RimeReader Reader, uint Count) s_Nodes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Nodes.Count; ++i)
			{
				var s_Value = new MixerPresetNodeData();
				fb.MixerPresetNodeData.Deserialize(s_Value, s_Nodes.Reader, p_Parser);
				p_Instance.Nodes.Add(s_Value);
			}
			
			s_Nodes.Reader.Dispose();
		}

	}
}
