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
	[ContainerType(16, 80)]
	public class EnlightenPipelineTerrainMesh
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec2 UvTranslation { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public AxisAlignedBox BoundingBox { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec4 UvTransform { get; set; } = new();
		
		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public uint LightMapResolution { get; set; }
		
		[ContainerField(68), LayoutImmutable, JsonProperty(Order = 68)]
		public string TerrainMeshName { get; set; } = string.Empty;
		
	}
}
