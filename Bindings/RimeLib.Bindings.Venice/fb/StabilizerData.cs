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
	public class StabilizerData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float PitchStrength { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float RollStrength { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float VerticalVelocityStrength { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float YawStrength { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool AdvancedYaw { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool Advanced { get; set; }

	}
}
