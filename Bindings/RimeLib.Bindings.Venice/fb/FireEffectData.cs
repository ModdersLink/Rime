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
	[ContainerType(16, 80)]
	public class FireEffectData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Rotation { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ZoomRotation { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ZoomOffset { get; set; } = new();
		
		[ContainerField(64)]
		public CtrRef<EffectBlueprint> Effect { get; set; } = new();
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool UseZoomOffset { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool UseZoomRotation { get; set; }
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool DisableDuringZoom { get; set; }
		
		[ContainerField(71), LayoutImmutable, Blittable]
		public bool UpdateTransform { get; set; }
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool StopLoopingEffects { get; set; }
		
	}
}
