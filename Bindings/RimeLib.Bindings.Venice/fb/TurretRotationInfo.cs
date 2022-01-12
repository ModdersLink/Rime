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
	public class TurretRotationInfo
	{
		[ContainerField(0)]
		public RotationAxis RotationAxis { get; set; } = new();
		
		[ContainerField(4)]
		public RotationChannel Channel { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MaxRotation { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinRotation { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float PhaseOffset { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool NormalizeRotation { get; set; }
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool InvertRotation { get; set; }
		
	}
}
