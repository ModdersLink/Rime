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
	[ContainerType(4, 56)]
	public class ScaleClampNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort InMin { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort InMax { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort OutMin { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort OutMax { get; set; } = new();

		[ContainerField(48)]
		public AudioGraphNodePort Out { get; set; } = new();

	}
}
