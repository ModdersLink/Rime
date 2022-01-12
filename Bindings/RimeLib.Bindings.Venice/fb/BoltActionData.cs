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
	public class BoltActionData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float BoltActionDelay { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float BoltActionTime { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool HoldBoltActionUntilFireRelease { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public bool HoldBoltActionUntilZoomRelease { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable]
		public bool ForceBoltActionOnFireTrigger { get; set; }
		
		[ContainerField(11), LayoutImmutable, Blittable]
		public bool UnZoomOnBoltAction { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool ReturnToZoomAfterBoltAction { get; set; }
		
	}
}
