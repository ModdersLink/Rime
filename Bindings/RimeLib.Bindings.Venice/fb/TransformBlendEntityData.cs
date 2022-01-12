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
	[ContainerType(16, 160)]
	public class TransformBlendEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In2 { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In1 { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public float BlendValue { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float BlendValue2 { get; set; }

		[ContainerField(152)]
		public Realm Realm { get; set; } = new();

	}
}
