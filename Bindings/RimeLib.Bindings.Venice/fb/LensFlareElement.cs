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
	public class LensFlareElement
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeCamDistCurve { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeAngleCurve { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Size { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeOccluderCurve { get; set; } = new();
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeScreenPosCurve { get; set; } = new();
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaCamDistCurve { get; set; } = new();
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaOccluderCurve { get; set; } = new();
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaAngleCurve { get; set; } = new();
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaScreenPosCurve { get; set; } = new();
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float SizeCamDistMax { get; set; }
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float RayDistance { get; set; }
		
		[ContainerField(152)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float AlphaCamDistMax { get; set; }
		
	}
}
