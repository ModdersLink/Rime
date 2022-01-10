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
	public class MixerInputEntry : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<AudioGraphParameter> Source { get; set; } = new();

		[ContainerField(20)]
		public MixerValueAccumulateMode AccumulateMode { get; set; } = new();

		public static void Deserialize(MixerInputEntry p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Out, p_Reader, p_Parser);
			p_Instance.Source.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AccumulateMode = (MixerValueAccumulateMode) p_Reader.ReadInt32();
		}

	}
}
