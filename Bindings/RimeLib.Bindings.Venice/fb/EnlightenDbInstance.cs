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
	[ContainerType(16, 192)]
	public class EnlightenDbInstance
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox WorldBoundingbox { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform WorldTransform { get; set; } = new();
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 UvTranslation { get; set; } = new();
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UvTransform { get; set; } = new();
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint GeometryId { get; set; }
		
		[ContainerField(132), LayoutImmutable]
		public string ObjectVariation { get; set; } = string.Empty;
		
		[ContainerField(136), LayoutImmutable]
		public string GuidString { get; set; } = string.Empty;
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public uint UvSizeX { get; set; }
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public uint UvSizeY { get; set; }
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float PixelSize { get; set; }
		
		[ContainerField(152), LayoutImmutable]
		public string EnlightenMeshName { get; set; } = string.Empty;
		
		[ContainerField(156), LayoutImmutable]
		public string MeshAsset { get; set; } = string.Empty;
		
		[ContainerField(160)]
		public List<ulong> InstanceAlbedos { get; set; } = new();
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public GUID CacheKey { get; set; }
		
	}
}
