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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 544)]
	public class SunFlareComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec4 Element5AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec4 Element5AlphaOccluderCurve { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec4 Element5SizeScreenPosCurve { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public Vec4 Element2SizeOccluderCurve { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public Vec4 Element5SizeOccluderCurve { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public Vec4 Element2AlphaOccluderCurve { get; set; } = new();

		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public Vec4 Element2AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public Vec2 Element1Size { get; set; } = new();

		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public Vec4 Element1SizeOccluderCurve { get; set; } = new();

		[ContainerField(240), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public Vec4 Element1SizeScreenPosCurve { get; set; } = new();

		[ContainerField(256), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public Vec4 Element1AlphaOccluderCurve { get; set; } = new();

		[ContainerField(272), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public Vec4 Element1AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(288), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		public Vec2 Element5Size { get; set; } = new();

		[ContainerField(304), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		public Vec4 Element4SizeOccluderCurve { get; set; } = new();

		[ContainerField(320), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		public Vec2 Element3Size { get; set; } = new();

		[ContainerField(328), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		public Vec2 Element2Size { get; set; } = new();

		[ContainerField(336), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		public Vec4 Element4AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(352), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		public Vec4 Element2SizeScreenPosCurve { get; set; } = new();

		[ContainerField(368), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		public Vec4 Element4SizeScreenPosCurve { get; set; } = new();

		[ContainerField(384), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 384)]
		public Vec2 Element4Size { get; set; } = new();

		[ContainerField(400), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 400)]
		public Vec4 Element3AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(416), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 416)]
		public Vec4 Element4AlphaOccluderCurve { get; set; } = new();

		[ContainerField(432), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 432)]
		public Vec4 Element3SizeOccluderCurve { get; set; } = new();

		[ContainerField(448), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 448)]
		public Vec4 Element3SizeScreenPosCurve { get; set; } = new();

		[ContainerField(464), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		public Vec4 Element3AlphaOccluderCurve { get; set; } = new();

		[ContainerField(480), JsonProperty(Order = 480)]
		public CtrRef<SurfaceShaderBaseAsset> Element1Shader { get; set; } = new();

		[ContainerField(484), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
		public float OccluderSize { get; set; }

		[ContainerField(488), JsonProperty(Order = 488)]
		public CtrRef<SurfaceShaderBaseAsset> Element2Shader { get; set; } = new();

		[ContainerField(492), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
		public float Element3RayDistance { get; set; }

		[ContainerField(496), JsonProperty(Order = 496)]
		public CtrRef<SurfaceShaderBaseAsset> Element4Shader { get; set; } = new();

		[ContainerField(500), LayoutImmutable, Blittable, JsonProperty(Order = 500)]
		public float Element4RayDistance { get; set; }

		[ContainerField(504), LayoutImmutable, Blittable, JsonProperty(Order = 504)]
		public float Element2RayDistance { get; set; }

		[ContainerField(508), LayoutImmutable, Blittable, JsonProperty(Order = 508)]
		public float Element1RayDistance { get; set; }

		[ContainerField(512), LayoutImmutable, Blittable, JsonProperty(Order = 512)]
		public float Element5RayDistance { get; set; }

		[ContainerField(516), JsonProperty(Order = 516)]
		public CtrRef<SurfaceShaderBaseAsset> Element3Shader { get; set; } = new();

		[ContainerField(520), JsonProperty(Order = 520)]
		public Realm Realm { get; set; } = new();

		[ContainerField(524), JsonProperty(Order = 524)]
		public CtrRef<SurfaceShaderBaseAsset> Element5Shader { get; set; } = new();

		[ContainerField(528), LayoutImmutable, Blittable, JsonProperty(Order = 528)]
		public bool Element5Enable { get; set; }

		[ContainerField(529), LayoutImmutable, Blittable, JsonProperty(Order = 529)]
		public bool Element3Enable { get; set; }

		[ContainerField(530), LayoutImmutable, Blittable, JsonProperty(Order = 530)]
		public bool Element2Enable { get; set; }

		[ContainerField(531), LayoutImmutable, Blittable, JsonProperty(Order = 531)]
		public bool Element1Enable { get; set; }

		[ContainerField(532), LayoutImmutable, Blittable, JsonProperty(Order = 532)]
		public bool DebugDrawOccluder { get; set; }

		[ContainerField(533), LayoutImmutable, Blittable, JsonProperty(Order = 533)]
		public bool Enable { get; set; }

		[ContainerField(534), LayoutImmutable, Blittable, JsonProperty(Order = 534)]
		public bool Element4Enable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Element5AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element5AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element5SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element2SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element5SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element2AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element2AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element1Size.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Element1SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element1SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element1AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element1AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element5Size.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Element4SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element3Size.Serialize(p_Writer, p_EbxWriter);
			Element2Size.Serialize(p_Writer, p_EbxWriter);
			Element4AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element2SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element4SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element4Size.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Element3AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element4AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element3SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			Element3SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
			Element3AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Element1Shader));
			p_Writer.Write(OccluderSize);
			p_Writer.Write(p_EbxWriter.WriteImport(Element2Shader));
			p_Writer.Write(Element3RayDistance);
			p_Writer.Write(p_EbxWriter.WriteImport(Element4Shader));
			p_Writer.Write(Element4RayDistance);
			p_Writer.Write(Element2RayDistance);
			p_Writer.Write(Element1RayDistance);
			p_Writer.Write(Element5RayDistance);
			p_Writer.Write(p_EbxWriter.WriteImport(Element3Shader));
			p_Writer.Write((int) Realm);
			p_Writer.Write(p_EbxWriter.WriteImport(Element5Shader));
			p_Writer.Write(Element5Enable);
			p_Writer.Write(Element3Enable);
			p_Writer.Write(Element2Enable);
			p_Writer.Write(Element1Enable);
			p_Writer.Write(DebugDrawOccluder);
			p_Writer.Write(Enable);
			p_Writer.Write(Element4Enable);
			p_Writer.WriteNullBytes(9);
		}
	}
}
