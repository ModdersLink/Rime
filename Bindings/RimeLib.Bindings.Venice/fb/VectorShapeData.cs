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
	public class VectorShapeData : 
		BaseShapeData
	{
		[ContainerField(12)]
		public List<Vec3> Points { get; set; } = new();

		[ContainerField(16)]
		public List<Vec3> Normals { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Tension { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool IsClosed { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool AllowRoll { get; set; }

	}
}
