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
	[ContainerType(16, 544)]
	public class TransformHubEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public LinearTransform In4 { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public LinearTransform In1 { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public LinearTransform In2 { get; set; } = new();

		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public LinearTransform In3 { get; set; } = new();

		[ContainerField(272), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public LinearTransform In8 { get; set; } = new();

		[ContainerField(336), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		public LinearTransform In5 { get; set; } = new();

		[ContainerField(400), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 400)]
		public LinearTransform In6 { get; set; } = new();

		[ContainerField(464), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		public LinearTransform In7 { get; set; } = new();

		[ContainerField(528), JsonProperty(Order = 528)]
		public Realm Realm { get; set; } = new();

	}
}
