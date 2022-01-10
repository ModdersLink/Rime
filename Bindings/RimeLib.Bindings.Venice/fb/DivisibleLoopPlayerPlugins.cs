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
	[ContainerType(1, 12)]
	public class DivisibleLoopPlayerPlugins
	{
		[ContainerField(0)]
		public SoundGraphPluginRef SndPlayer { get; set; } = new();
		
		[ContainerField(3)]
		public SoundGraphPluginRef Pause { get; set; } = new();
		
		[ContainerField(6)]
		public SoundGraphPluginRef Gain { get; set; } = new();
		
		[ContainerField(9)]
		public SoundGraphPluginRef GainFader { get; set; } = new();
		
		public static void Deserialize(DivisibleLoopPlayerPlugins p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.SoundGraphPluginRef.Deserialize(p_Instance.SndPlayer, p_Reader, p_Parser);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.Pause, p_Reader, p_Parser);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.Gain, p_Reader, p_Parser);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.GainFader, p_Reader, p_Parser);
		}
	}
}
