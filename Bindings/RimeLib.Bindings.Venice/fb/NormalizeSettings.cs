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
	[ContainerType(4, 24)]
	public class NormalizeSettings
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Maximum { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Minimum { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Velocity { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Lower { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Upper { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool Normalize { get; set; }
		
	}
}
