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
	[ContainerType(4, 32)]
	public class PerformanceFpsHistogram
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Below5 { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Below10 { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Below15 { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Below20 { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Below25 { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Below30 { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Below60 { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Above60 { get; set; }
		
	}
}
