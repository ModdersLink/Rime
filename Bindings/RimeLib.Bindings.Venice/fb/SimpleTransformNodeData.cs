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
	public class SimpleTransformNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort X { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Y { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Z { get; set; } = new();

		[ContainerField(32)]
		public SimpleTransformOperation Operation { get; set; } = new();

		[ContainerField(36)]
		public AngleUnit AngleUnit { get; set; } = new();

	}
}
