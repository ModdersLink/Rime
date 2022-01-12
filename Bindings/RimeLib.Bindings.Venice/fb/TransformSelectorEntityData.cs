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
	public class TransformSelectorEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In1 { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In2 { get; set; } = new();

		[ContainerField(144)]
		public Realm Realm { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool Selection { get; set; }

	}
}
