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
	[ContainerType(8, 24)]
	public class UIGPSPosition
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public double Latitude { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public double Longitude { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public double SeaLevelOffset { get; set; }
		
	}
}
