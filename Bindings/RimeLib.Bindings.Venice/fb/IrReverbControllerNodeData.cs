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
	public class IrReverbControllerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Reverb0 { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Amplitude0 { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Reverb1 { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Amplitude1 { get; set; } = new();

	}
}
