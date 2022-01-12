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
	public class HudImpactData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MaxHealth { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MinHealth { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MaxTimeVisible { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinTimeVisible { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool Enable { get; set; }
		
	}
}
