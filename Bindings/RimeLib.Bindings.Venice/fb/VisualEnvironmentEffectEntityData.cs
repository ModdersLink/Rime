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
	[ContainerType(16, 176)]
	public class VisualEnvironmentEffectEntityData : 
		EffectEntityData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec4 LifetimeCurve { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec4 CullDistanceCurve { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public Vec4 CullAngleCurve { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float Lifetime { get; set; }

		[ContainerField(164), JsonProperty(Order = 164)]
		public CtrRef<VisualEnvironmentBlueprint> VisualEnvironment { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public bool SampleOnStartOnly { get; set; }

	}
}
