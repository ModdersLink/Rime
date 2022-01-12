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
	public class SoundGraphInfo
	{
		[ContainerField(0)]
		public List<SoundGraphVoiceInfo> Voices { get; set; } = new();
		
		[ContainerField(4)]
		public List<SoundGraphLinkedPluginAttribute> LinkedPluginAttributes { get; set; } = new();
		
		[ContainerField(8)]
		public List<SoundGraphPluginConnection> Connections { get; set; } = new();
		
		[ContainerField(12)]
		public List<SoundGraphPluginConstructParam> ConstructParams { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint PluginsParamCount { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint PluginCount { get; set; }
		
	}
}
