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
	[ContainerType(4, 16)]
	public class GunSwayDispersionData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MinAngle { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxAngle { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float IncreasePerShot { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DecreasePerSecond { get; set; }
		
	}
}
