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
	[ContainerType(16, 32)]
	public class SoldierHeadCollisionPoseData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 IdleOffset { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MovingForwardOffset { get; set; } = new();
		
	}
}
