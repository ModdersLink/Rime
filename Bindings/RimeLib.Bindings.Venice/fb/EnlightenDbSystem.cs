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
	public class EnlightenDbSystem
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox BoundingBox { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint AtlasStartX { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint AtlasStartY { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint OutputWidth { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public uint OutputHeight { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint PixelCount { get; set; }
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float PixelSize { get; set; }
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public int SystemId { get; set; }
		
		[ContainerField(60)]
		public List<EnlightenDbInstance> Instances { get; set; } = new();
		
		[ContainerField(64)]
		public List<int> InputSystems { get; set; } = new();
		
		[ContainerField(68)]
		public PrecomputeCache SystemCache { get; set; } = new();
		
		[ContainerField(92)]
		public PrecomputeCache ClusteringCache { get; set; } = new();
		
		[ContainerField(116)]
		public PrecomputeCache PreClusteringCache { get; set; } = new();
		
		[ContainerField(140)]
		public PrecomputeCache LightTransportCache { get; set; } = new();
		
		[ContainerField(164)]
		public PrecomputeCache VisibilityCache { get; set; } = new();
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public bool TerrainSystem { get; set; }
		
	}
}
