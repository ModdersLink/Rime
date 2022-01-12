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
	[ContainerType(4, 20)]
	public class PoissonRadialBlurData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 PoissonDiscScale { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float BlendFactor { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float RadialScale { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float RadialExponent { get; set; }
		
	}
}
