///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(1, 12)]
	public class SamplerPlugins :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public SoundGraphPluginRef SndPlayer { get; set; } = new();
		
		[ContainerField(3), JsonProperty(Order = 3)]
		public SoundGraphPluginRef Resample { get; set; } = new();
		
		[ContainerField(6), JsonProperty(Order = 6)]
		public SoundGraphPluginRef Pause { get; set; } = new();
		
		[ContainerField(9), JsonProperty(Order = 9)]
		public SoundGraphPluginRef Gain { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SndPlayer.Serialize(p_Writer, p_EbxWriter);
			Resample.Serialize(p_Writer, p_EbxWriter);
			Pause.Serialize(p_Writer, p_EbxWriter);
			Gain.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
