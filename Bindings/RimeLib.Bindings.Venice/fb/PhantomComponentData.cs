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
	[ContainerType(16, 128)]
	public class PhantomComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BoxSize { get; set; } = new();

		[ContainerField(112)]
		public AntRef AsyncQueryPointerAsset { get; set; } = new();

		[ContainerField(116)]
		public AntRef EnableTrajectoryOverride { get; set; } = new();

		[ContainerField(120)]
		public AntRef TrajectoryOverride { get; set; } = new();

	}
}
