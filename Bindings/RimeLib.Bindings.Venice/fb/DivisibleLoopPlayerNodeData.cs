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
	[ContainerType(4, 72)]
	public class DivisibleLoopPlayerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Start { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Stop { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort FreezeSegment { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort Output { get; set; } = new();

		[ContainerField(48)]
		public CtrRef<SoundWaveAsset> Wave { get; set; } = new();

		[ContainerField(52)]
		public AudioGraphNodePort ExternalWave { get; set; } = new();

		[ContainerField(60)]
		public List<DivisibleLoopPlayerPlugins> Plugins { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public float CrossFadeLength { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public bool StartAtRandomPosition { get; set; }

		public static void Deserialize(DivisibleLoopPlayerNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Start, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Stop, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Amplitude, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.FreezeSegment, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Output, p_Reader, p_Parser);
			p_Instance.Wave.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.AudioGraphNodePort.Deserialize(p_Instance.ExternalWave, p_Reader, p_Parser);
			p_Instance.Plugins.Clear();
			(RimeReader Reader, uint Count) s_Plugins = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Plugins.Count; ++i)
			{
				var s_Value = new DivisibleLoopPlayerPlugins();
				fb.DivisibleLoopPlayerPlugins.Deserialize(s_Value, s_Plugins.Reader, p_Parser);
				p_Instance.Plugins.Add(s_Value);
			}
			
			s_Plugins.Reader.Dispose();
			p_Instance.CrossFadeLength = p_Reader.ReadSingle();
			p_Instance.StartAtRandomPosition = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
