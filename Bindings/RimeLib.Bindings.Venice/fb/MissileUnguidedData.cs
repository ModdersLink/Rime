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
	public class MissileUnguidedData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 StaticPosition { get; set; } = new();
		
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 TargetPositionOffset { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UseTargetPosition { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool UseStaticPosition { get; set; }
		
	}
}
