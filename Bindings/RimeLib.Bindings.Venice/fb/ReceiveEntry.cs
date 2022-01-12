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
	[ContainerType(4, 28)]
	public class ReceiveEntry : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<AudioGraphParameter> Source { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Parameter { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float SavedValue { get; set; }

	}
}
