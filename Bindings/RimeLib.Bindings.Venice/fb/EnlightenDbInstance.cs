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
	[ContainerType(16, 192)]
	public class EnlightenDbInstance
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public AxisAlignedBox WorldBoundingbox { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public LinearTransform WorldTransform { get; set; } = new();
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec2 UvTranslation { get; set; } = new();
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec4 UvTransform { get; set; } = new();
		
		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public uint GeometryId { get; set; }
		
		[ContainerField(132), LayoutImmutable, JsonProperty(Order = 132)]
		public string ObjectVariation { get; set; } = string.Empty;
		
		[ContainerField(136), LayoutImmutable, JsonProperty(Order = 136)]
		public string GuidString { get; set; } = string.Empty;
		
		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public uint UvSizeX { get; set; }
		
		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public uint UvSizeY { get; set; }
		
		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float PixelSize { get; set; }
		
		[ContainerField(152), LayoutImmutable, JsonProperty(Order = 152)]
		public string EnlightenMeshName { get; set; } = string.Empty;
		
		[ContainerField(156), LayoutImmutable, JsonProperty(Order = 156)]
		public string MeshAsset { get; set; } = string.Empty;
		
		[ContainerField(160), JsonProperty(Order = 160)]
		public List<ulong> InstanceAlbedos { get; set; } = new();
		
		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public GUID CacheKey { get; set; }
		
	}
}
