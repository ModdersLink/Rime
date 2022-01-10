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
	public class AiffWriterNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Start { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Stop { get; set; } = new();

		[ContainerField(32)]
		public SoundGraphPluginRef Plugin { get; set; } = new();

		[ContainerField(36), LayoutImmutable]
		public string FileName { get; set; } = string.Empty;

		public static void Deserialize(AiffWriterNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.In, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Start, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Stop, p_Reader, p_Parser);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.Plugin, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.FileName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
