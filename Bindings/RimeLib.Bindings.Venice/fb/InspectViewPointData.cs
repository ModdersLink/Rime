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
	[ContainerType(4, 40)]
	public class InspectViewPointData
	{
		[ContainerField(0), LayoutImmutable]
		public string ViewPointID { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public List<InspectAnimationTriggerData> AnimationTriggers { get; set; } = new();
		
		[ContainerField(8)]
		public List<AntRef> ContinuousAnimationSignal { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LookAtHeight { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Yaw { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Pitch { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Distance { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float FovOffset { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float AdjustmentYaw { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Fixed { get; set; }
		
	}
}
