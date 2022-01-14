///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
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
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 BoxSize { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public AntRef AsyncQueryPointerAsset { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public AntRef EnableTrajectoryOverride { get; set; } = new();

		[ContainerField(120), JsonProperty(Order = 120)]
		public AntRef TrajectoryOverride { get; set; } = new();

	}
}
