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
	public class AnimatedTransformEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public AntRef Animatable { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; }

		[ContainerField(20)]
		public AntRef Controller { get; set; } = new();

		[ContainerField(24), LayoutImmutable]
		public string BoneName { get; set; } = string.Empty;

	}
}
