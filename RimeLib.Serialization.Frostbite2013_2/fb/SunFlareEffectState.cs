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

using fb.Core;
using fb.Render;

namespace fb.WorldRender;

[ContainerType(16, 480)]
public class SunFlareEffectState
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float OccluderSize { get; set; } = 500.000f;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<SurfaceShaderBaseAsset> Element1Shader { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec4 Element1SizeOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec4 Element1SizeScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec4 Element1AlphaOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = -1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec4 Element1AlphaScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec4 Element2SizeOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec4 Element2SizeScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec4 Element2AlphaOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = -1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec4 Element2AlphaScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec4 Element3SizeOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Vec4 Element3SizeScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Vec4 Element3AlphaOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = -1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xd0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public Vec4 Element3AlphaScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec4 Element4SizeOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xf0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public Vec4 Element4SizeScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x100), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public Vec4 Element4AlphaOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = -1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x110), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public Vec4 Element4AlphaScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x120), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public Vec4 Element5SizeOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x130), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public Vec4 Element5SizeScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x140), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public Vec4 Element5AlphaOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = -1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x150), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public Vec4 Element5AlphaScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float Element1RayDistance { get; set; } = 0.000f;
	
	[ContainerField(0x164), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public Vec2 Element1Size { get; set; } = new()
	{
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x170), JsonProperty(Order = 368)]
	public CtrRef<SurfaceShaderBaseAsset> Element2Shader { get; set; } = new();
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public float Element2RayDistance { get; set; } = 0.000f;
	
	[ContainerField(0x17c), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 380)]
	public Vec2 Element2Size { get; set; } = new()
	{
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x188), JsonProperty(Order = 392)]
	public CtrRef<SurfaceShaderBaseAsset> Element3Shader { get; set; } = new();
	
	[ContainerField(0x190), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public float Element3RayDistance { get; set; } = 0.000f;
	
	[ContainerField(0x194), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 404)]
	public Vec2 Element3Size { get; set; } = new()
	{
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x1a0), JsonProperty(Order = 416)]
	public CtrRef<SurfaceShaderBaseAsset> Element4Shader { get; set; } = new();
	
	[ContainerField(0x1a8), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
	public float Element4RayDistance { get; set; } = 0.000f;
	
	[ContainerField(0x1ac), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 428)]
	public Vec2 Element4Size { get; set; } = new()
	{
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x1b8), JsonProperty(Order = 440)]
	public CtrRef<SurfaceShaderBaseAsset> Element5Shader { get; set; } = new();
	
	[ContainerField(0x1c0), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
	public float Element5RayDistance { get; set; } = 0.000f;
	
	[ContainerField(0x1c4), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 452)]
	public Vec2 Element5Size { get; set; } = new()
	{
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x1cc), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
	public bool Enable { get; set; } = false;
	
	[ContainerField(0x1cd), LayoutImmutable, Blittable, JsonProperty(Order = 461)]
	public bool DebugDrawOccluder { get; set; } = false;
	
	[ContainerField(0x1ce), LayoutImmutable, Blittable, JsonProperty(Order = 462)]
	public bool Element1Enable { get; set; } = false;
	
	[ContainerField(0x1cf), LayoutImmutable, Blittable, JsonProperty(Order = 463)]
	public bool Element2Enable { get; set; } = false;
	
	[ContainerField(0x1d0), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
	public bool Element3Enable { get; set; } = false;
	
	[ContainerField(0x1d1), LayoutImmutable, Blittable, JsonProperty(Order = 465)]
	public bool Element4Enable { get; set; } = false;
	
	[ContainerField(0x1d2), LayoutImmutable, Blittable, JsonProperty(Order = 466)]
	public bool Element5Enable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(OccluderSize);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Element1Shader));
		p_Writer.WriteNullBytes(4);
		Element1SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element1SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element1AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element1AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element2SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element2SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element2AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element2AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element3SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element3SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element3AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element3AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element4SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element4SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element4AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element4AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element5SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element5SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element5AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element5AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Element1RayDistance);
		Element1Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Element2Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Element2RayDistance);
		Element2Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Element3Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Element3RayDistance);
		Element3Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Element4Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Element4RayDistance);
		Element4Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Element5Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Element5RayDistance);
		Element5Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Enable);
		p_Writer.Write(DebugDrawOccluder);
		p_Writer.Write(Element1Enable);
		p_Writer.Write(Element2Enable);
		p_Writer.Write(Element3Enable);
		p_Writer.Write(Element4Enable);
		p_Writer.Write(Element5Enable);
		p_Writer.WriteNullBytes(13);
	}
}

