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
	[ContainerType(4, 52)]
	public class WaveSwitcherNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Index { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Advance { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Wave { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort IndexChanged { get; set; } = new();

		[ContainerField(40)]
		public List<CtrRef<SoundWaveAsset>> Waves { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public float DefaultIndex { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool IsRandom { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool RandomStartIndex { get; set; }

		public static void Deserialize(WaveSwitcherNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Index, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Advance, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Wave, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.IndexChanged, p_Reader, p_Parser);
			p_Instance.Waves.Clear();
			(RimeReader Reader, uint Count) s_Waves = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Waves.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundWaveAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Waves.Reader.ReadUInt32()));
				p_Instance.Waves.Add(s_CtrRef);
			}
			
			s_Waves.Reader.Dispose();
			p_Instance.DefaultIndex = p_Reader.ReadSingle();
			p_Instance.IsRandom = p_Reader.ReadBool();
			p_Instance.RandomStartIndex = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
