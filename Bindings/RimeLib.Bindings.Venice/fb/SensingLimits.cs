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
	public class SensingLimits
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float HearingDistance { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float HearingCutoff { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float ViewAngle { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float PeripheralViewAngle { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float PeripheralViewDistance { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float PeripheralMovementCutoff { get; set; }
		
	}
}
