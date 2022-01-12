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
	public class AutoAimData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AutoAimOuterBoxOffset { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AutoAimOuterBoxExtends { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AutoAimInnerBoxOffset { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AutoAimInnerBoxExtends { get; set; } = new();
		
		[ContainerField(64)]
		public CharacterPoseType PoseType { get; set; } = new();
		
	}
}
