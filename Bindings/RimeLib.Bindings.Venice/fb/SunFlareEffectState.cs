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
	[ContainerType(16, 448)]
	public class SunFlareEffectState : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec4 Element5AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec4 Element5AlphaOccluderCurve { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec4 Element2SizeScreenPosCurve { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public Vec4 Element5SizeScreenPosCurve { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public Vec4 Element2AlphaOccluderCurve { get; set; } = new();

		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec4 Element2AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec2 Element1Size { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec4 Element1SizeOccluderCurve { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public Vec4 Element1SizeScreenPosCurve { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public Vec4 Element1AlphaOccluderCurve { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public Vec4 Element1AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public Vec4 Element5SizeOccluderCurve { get; set; } = new();

		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public Vec4 Element4SizeScreenPosCurve { get; set; } = new();

		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public Vec2 Element3Size { get; set; } = new();

		[ContainerField(232), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public Vec2 Element2Size { get; set; } = new();

		[ContainerField(240), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public Vec4 Element2SizeOccluderCurve { get; set; } = new();

		[ContainerField(256), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public Vec4 Element4AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(272), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public Vec4 Element3SizeOccluderCurve { get; set; } = new();

		[ContainerField(288), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		public Vec2 Element4Size { get; set; } = new();

		[ContainerField(296), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		public Vec2 Element5Size { get; set; } = new();

		[ContainerField(304), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		public Vec4 Element3SizeScreenPosCurve { get; set; } = new();

		[ContainerField(320), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		public Vec4 Element3AlphaOccluderCurve { get; set; } = new();

		[ContainerField(336), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		public Vec4 Element4SizeOccluderCurve { get; set; } = new();

		[ContainerField(352), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		public Vec4 Element3AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(368), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		public Vec4 Element4AlphaOccluderCurve { get; set; } = new();

		[ContainerField(384), JsonProperty(Order = 384)]
		public CtrRef<SurfaceShaderBaseAsset> Element3Shader { get; set; } = new();

		[ContainerField(388), JsonProperty(Order = 388)]
		public CtrRef<SurfaceShaderBaseAsset> Element2Shader { get; set; } = new();

		[ContainerField(392), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
		public float OccluderSize { get; set; }

		[ContainerField(396), JsonProperty(Order = 396)]
		public CtrRef<SurfaceShaderBaseAsset> Element4Shader { get; set; } = new();

		[ContainerField(400), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
		public float Element4RayDistance { get; set; }

		[ContainerField(404), JsonProperty(Order = 404)]
		public CtrRef<SurfaceShaderBaseAsset> Element1Shader { get; set; } = new();

		[ContainerField(408), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
		public float Element2RayDistance { get; set; }

		[ContainerField(412), LayoutImmutable, Blittable, JsonProperty(Order = 412)]
		public float Element1RayDistance { get; set; }

		[ContainerField(416), LayoutImmutable, Blittable, JsonProperty(Order = 416)]
		public float Element5RayDistance { get; set; }

		[ContainerField(420), LayoutImmutable, Blittable, JsonProperty(Order = 420)]
		public float Element3RayDistance { get; set; }

		[ContainerField(424), JsonProperty(Order = 424)]
		public CtrRef<SurfaceShaderBaseAsset> Element5Shader { get; set; } = new();

		[ContainerField(428), LayoutImmutable, Blittable, JsonProperty(Order = 428)]
		public bool Element5Enable { get; set; }

		[ContainerField(429), LayoutImmutable, Blittable, JsonProperty(Order = 429)]
		public bool Element4Enable { get; set; }

		[ContainerField(430), LayoutImmutable, Blittable, JsonProperty(Order = 430)]
		public bool Element3Enable { get; set; }

		[ContainerField(431), LayoutImmutable, Blittable, JsonProperty(Order = 431)]
		public bool Element2Enable { get; set; }

		[ContainerField(432), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
		public bool Element1Enable { get; set; }

		[ContainerField(433), LayoutImmutable, Blittable, JsonProperty(Order = 433)]
		public bool DebugDrawOccluder { get; set; }

		[ContainerField(434), LayoutImmutable, Blittable, JsonProperty(Order = 434)]
		public bool Enable { get; set; }

	}
}
