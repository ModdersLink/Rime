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
	[ContainerType(4, 44)]
	public class MinMaxValueSelectorNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public RefArray<MinMaxValueSelectorEntry> Inputs { get; set; } = new();

		[ContainerField(12)]
		public AudioGraphNodePort MaxValue { get; set; } = new();

		[ContainerField(20)]
		public AudioGraphNodePort MaxIndex { get; set; } = new();

		[ContainerField(28)]
		public AudioGraphNodePort MinValue { get; set; } = new();

		[ContainerField(36)]
		public AudioGraphNodePort MinIndex { get; set; } = new();

	}
}
