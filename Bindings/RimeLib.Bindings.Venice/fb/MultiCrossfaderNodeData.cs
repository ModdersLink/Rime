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
	public class MultiCrossfaderNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public RefArray<MultiCrossfaderGroup> CrossfaderGroups { get; set; } = new();

		[ContainerField(12)]
		public AudioGraphNodePort Start { get; set; } = new();

		[ContainerField(20)]
		public AudioGraphNodePort Stop { get; set; } = new();

		[ContainerField(28)]
		public AudioGraphNodePort Control { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool LockControlValue { get; set; }

	}
}
