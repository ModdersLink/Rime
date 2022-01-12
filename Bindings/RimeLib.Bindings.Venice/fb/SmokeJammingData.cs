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
	public class SmokeJammingData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float JammingTime { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxRadius { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MinRadius { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float TargetUpdateTime { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool EnableSmokeJamming { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool JammingPositionIsLocationDependent { get; set; }
		
		[ContainerField(18), LayoutImmutable, Blittable]
		public bool ReportJammedBasedOnStartPosition { get; set; }
		
	}
}
