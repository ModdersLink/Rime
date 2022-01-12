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
	public class EqualizerSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float LowShelfFrequency { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float LowShelfGain { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float HighShelfFrequency { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float HighShelfGain { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float HpCutoffFrequency { get; set; }

	}
}
