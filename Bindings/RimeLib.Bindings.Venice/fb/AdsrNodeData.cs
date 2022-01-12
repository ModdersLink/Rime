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
	public class AdsrNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Trigger { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Release { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort A { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort D { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort S { get; set; } = new();

		[ContainerField(48)]
		public AudioGraphNodePort R { get; set; } = new();

		[ContainerField(56)]
		public AudioGraphNodePort Value { get; set; } = new();

		[ContainerField(64)]
		public AudioGraphNodePort Finished { get; set; } = new();

	}
}
