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
	[ContainerType(16, 160)]
	public class EnlightenLightProbeSet
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new();
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox BoundingBox { get; set; } = new();
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint SizeX { get; set; }
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint SizeZ { get; set; }
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public uint SizeY { get; set; }
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public int SystemId { get; set; }
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float BlendDistance { get; set; }
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public int Priority { get; set; }
		
		[ContainerField(120)]
		public List<Vec3> Positions { get; set; } = new();
		
		[ContainerField(124)]
		public List<uint> ValidIndices { get; set; } = new();
		
		[ContainerField(128)]
		public List<int> InputSystems { get; set; } = new();
		
		[ContainerField(132)]
		public PrecomputeCache Cache { get; set; } = new();
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public bool StaticProbeSet { get; set; }
		
	}
}
