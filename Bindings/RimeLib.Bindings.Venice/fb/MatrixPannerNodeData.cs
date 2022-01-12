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
	[ContainerType(4, 88)]
	public class MatrixPannerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort FrontLeft { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Center { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort FrontRight { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort RearLeft { get; set; } = new();

		[ContainerField(48)]
		public AudioGraphNodePort Lfe { get; set; } = new();

		[ContainerField(56)]
		public AudioGraphNodePort RearRight { get; set; } = new();

		[ContainerField(64)]
		public AudioGraphNodePort FarRearLeft { get; set; } = new();

		[ContainerField(72)]
		public AudioGraphNodePort FarRearRight { get; set; } = new();

		[ContainerField(80)]
		public AudioGraphNodePort Out { get; set; } = new();

	}
}
