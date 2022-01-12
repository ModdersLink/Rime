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
	[ContainerType(4, 16)]
	public class SoundGraphPluginConnection
	{
		[ContainerField(0)]
		public SoundGraphPluginConnectionType ConnectionType { get; set; } = new();
		
		[ContainerField(4)]
		public List<SoundGraphPluginConnectionParam> Parameters { get; set; } = new();
		
		[ContainerField(8)]
		public CtrRef<SoundBusData> Bus { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public sbyte VoiceIndex { get; set; }
		
	}
}
