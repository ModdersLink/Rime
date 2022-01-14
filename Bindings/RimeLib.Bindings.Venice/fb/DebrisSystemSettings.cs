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
	[ContainerType(4, 44)]
	public class DebrisSystemSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint MeshDrawCountLimit { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float TimeScale { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float MeshCullingDistance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint DrawStats { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint MeshBatchCountLimit { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float MeshStreamingPriorityMultiplier { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool MeshRenderingEnable { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool EnableJobs { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool MeshShadowEnable { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		public bool MeshViewCullingEnable { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool MeshHavokRenderingEnable { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool MeshDrawTransforms { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		public bool Enable { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
		public bool MeshDrawBoundingBoxes { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool MeshDrawCullStats { get; set; }

	}
}
