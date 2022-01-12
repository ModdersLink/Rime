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
	public class TurnEffectData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MaxRollAngle { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxPitchAngle { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float YawVelocityThreshhold { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float VelocityThreshhold { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SafeTime { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float BeginTime { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float HoldTime { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float EndTime { get; set; }
		
	}
}
