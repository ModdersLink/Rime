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
using fb.Entity;

namespace fb.WorldRender;

[ContainerType(16, 704)]
public class SunFlareComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec4 Element1SizeOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec4 Element1SizeScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec4 Element1AlphaOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = -1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Vec4 Element1AlphaScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Vec4 Element1RotationDistCurve { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xd0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public Vec4 Element2SizeOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec4 Element2SizeScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xf0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public Vec4 Element2AlphaOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = -1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x100), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public Vec4 Element2AlphaScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x110), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public Vec4 Element2RotationDistCurve { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x120), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public Vec4 Element3SizeOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x130), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public Vec4 Element3SizeScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x140), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public Vec4 Element3AlphaOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = -1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x150), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public Vec4 Element3AlphaScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public Vec4 Element3RotationDistCurve { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x170), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public Vec4 Element4SizeOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x180), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public Vec4 Element4SizeScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x190), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public Vec4 Element4AlphaOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = -1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x1a0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 416)]
	public Vec4 Element4AlphaScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x1b0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 432)]
	public Vec4 Element4RotationDistCurve { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x1c0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 448)]
	public Vec4 Element5SizeOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x1d0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 464)]
	public Vec4 Element5SizeScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x1e0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 480)]
	public Vec4 Element5AlphaOccluderCurve { get; set; } = new()
	{
		w = 1.000f,
		z = -1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x1f0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 496)]
	public Vec4 Element5AlphaScreenPosCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x200), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 512)]
	public Vec4 Element5RotationDistCurve { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x210), LayoutImmutable, Blittable, JsonProperty(Order = 528)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x214), LayoutImmutable, Blittable, JsonProperty(Order = 532)]
	public float OccluderSize { get; set; } = 500.000f;
	
	[ContainerField(0x218), JsonProperty(Order = 536)]
	public CtrRef<SurfaceShaderBaseAsset> Element1Shader { get; set; } = new();
	
	[ContainerField(0x220), LayoutImmutable, Blittable, JsonProperty(Order = 544)]
	public float Element1RayDistance { get; set; } = 0.000f;
	
	[ContainerField(0x224), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 548)]
	public Vec2 Element1Size { get; set; } = new()
	{
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x22c), LayoutImmutable, Blittable, JsonProperty(Order = 556)]
	public float Element1RotationLocal { get; set; } = 0.000f;
	
	[ContainerField(0x230), LayoutImmutable, Blittable, JsonProperty(Order = 560)]
	public float Element1RotationDistMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x238), JsonProperty(Order = 568)]
	public CtrRef<SurfaceShaderBaseAsset> Element2Shader { get; set; } = new();
	
	[ContainerField(0x240), LayoutImmutable, Blittable, JsonProperty(Order = 576)]
	public float Element2RayDistance { get; set; } = 0.000f;
	
	[ContainerField(0x244), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 580)]
	public Vec2 Element2Size { get; set; } = new()
	{
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x24c), LayoutImmutable, Blittable, JsonProperty(Order = 588)]
	public float Element2RotationLocal { get; set; } = 0.000f;
	
	[ContainerField(0x250), LayoutImmutable, Blittable, JsonProperty(Order = 592)]
	public float Element2RotationDistMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x258), JsonProperty(Order = 600)]
	public CtrRef<SurfaceShaderBaseAsset> Element3Shader { get; set; } = new();
	
	[ContainerField(0x260), LayoutImmutable, Blittable, JsonProperty(Order = 608)]
	public float Element3RayDistance { get; set; } = 0.000f;
	
	[ContainerField(0x264), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 612)]
	public Vec2 Element3Size { get; set; } = new()
	{
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x26c), LayoutImmutable, Blittable, JsonProperty(Order = 620)]
	public float Element3RotationLocal { get; set; } = 0.000f;
	
	[ContainerField(0x270), LayoutImmutable, Blittable, JsonProperty(Order = 624)]
	public float Element3RotationDistMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x278), JsonProperty(Order = 632)]
	public CtrRef<SurfaceShaderBaseAsset> Element4Shader { get; set; } = new();
	
	[ContainerField(0x280), LayoutImmutable, Blittable, JsonProperty(Order = 640)]
	public float Element4RayDistance { get; set; } = 0.000f;
	
	[ContainerField(0x284), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 644)]
	public Vec2 Element4Size { get; set; } = new()
	{
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x28c), LayoutImmutable, Blittable, JsonProperty(Order = 652)]
	public float Element4RotationLocal { get; set; } = 0.000f;
	
	[ContainerField(0x290), LayoutImmutable, Blittable, JsonProperty(Order = 656)]
	public float Element4RotationDistMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x298), JsonProperty(Order = 664)]
	public CtrRef<SurfaceShaderBaseAsset> Element5Shader { get; set; } = new();
	
	[ContainerField(0x2a0), LayoutImmutable, Blittable, JsonProperty(Order = 672)]
	public float Element5RayDistance { get; set; } = 0.000f;
	
	[ContainerField(0x2a4), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 676)]
	public Vec2 Element5Size { get; set; } = new()
	{
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x2ac), LayoutImmutable, Blittable, JsonProperty(Order = 684)]
	public float Element5RotationLocal { get; set; } = 0.000f;
	
	[ContainerField(0x2b0), LayoutImmutable, Blittable, JsonProperty(Order = 688)]
	public float Element5RotationDistMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x2b4), LayoutImmutable, Blittable, JsonProperty(Order = 692)]
	public bool Enable { get; set; } = false;
	
	[ContainerField(0x2b5), LayoutImmutable, Blittable, JsonProperty(Order = 693)]
	public bool DebugDrawOccluder { get; set; } = false;
	
	[ContainerField(0x2b6), LayoutImmutable, Blittable, JsonProperty(Order = 694)]
	public bool Element1Enable { get; set; } = false;
	
	[ContainerField(0x2b7), LayoutImmutable, Blittable, JsonProperty(Order = 695)]
	public bool Element1RotationAlignedToRay { get; set; } = false;
	
	[ContainerField(0x2b8), LayoutImmutable, Blittable, JsonProperty(Order = 696)]
	public bool Element2Enable { get; set; } = false;
	
	[ContainerField(0x2b9), LayoutImmutable, Blittable, JsonProperty(Order = 697)]
	public bool Element2RotationAlignedToRay { get; set; } = false;
	
	[ContainerField(0x2ba), LayoutImmutable, Blittable, JsonProperty(Order = 698)]
	public bool Element3Enable { get; set; } = false;
	
	[ContainerField(0x2bb), LayoutImmutable, Blittable, JsonProperty(Order = 699)]
	public bool Element3RotationAlignedToRay { get; set; } = false;
	
	[ContainerField(0x2bc), LayoutImmutable, Blittable, JsonProperty(Order = 700)]
	public bool Element4Enable { get; set; } = false;
	
	[ContainerField(0x2bd), LayoutImmutable, Blittable, JsonProperty(Order = 701)]
	public bool Element4RotationAlignedToRay { get; set; } = false;
	
	[ContainerField(0x2be), LayoutImmutable, Blittable, JsonProperty(Order = 702)]
	public bool Element5Enable { get; set; } = false;
	
	[ContainerField(0x2bf), LayoutImmutable, Blittable, JsonProperty(Order = 703)]
	public bool Element5RotationAlignedToRay { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Element1SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element1SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element1AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element1AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element1RotationDistCurve.Serialize(p_Writer, p_EbxWriter);
		Element2SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element2SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element2AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element2AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element2RotationDistCurve.Serialize(p_Writer, p_EbxWriter);
		Element3SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element3SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element3AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element3AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element3RotationDistCurve.Serialize(p_Writer, p_EbxWriter);
		Element4SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element4SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element4AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element4AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element4RotationDistCurve.Serialize(p_Writer, p_EbxWriter);
		Element5SizeOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element5SizeScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element5AlphaOccluderCurve.Serialize(p_Writer, p_EbxWriter);
		Element5AlphaScreenPosCurve.Serialize(p_Writer, p_EbxWriter);
		Element5RotationDistCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(OccluderSize);
		p_Writer.Write(p_EbxWriter.WriteImport(Element1Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Element1RayDistance);
		Element1Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Element1RotationLocal);
		p_Writer.Write(Element1RotationDistMultiplier);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Element2Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Element2RayDistance);
		Element2Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Element2RotationLocal);
		p_Writer.Write(Element2RotationDistMultiplier);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Element3Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Element3RayDistance);
		Element3Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Element3RotationLocal);
		p_Writer.Write(Element3RotationDistMultiplier);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Element4Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Element4RayDistance);
		Element4Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Element4RotationLocal);
		p_Writer.Write(Element4RotationDistMultiplier);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Element5Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Element5RayDistance);
		Element5Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Element5RotationLocal);
		p_Writer.Write(Element5RotationDistMultiplier);
		p_Writer.Write(Enable);
		p_Writer.Write(DebugDrawOccluder);
		p_Writer.Write(Element1Enable);
		p_Writer.Write(Element1RotationAlignedToRay);
		p_Writer.Write(Element2Enable);
		p_Writer.Write(Element2RotationAlignedToRay);
		p_Writer.Write(Element3Enable);
		p_Writer.Write(Element3RotationAlignedToRay);
		p_Writer.Write(Element4Enable);
		p_Writer.Write(Element4RotationAlignedToRay);
		p_Writer.Write(Element5Enable);
		p_Writer.Write(Element5RotationAlignedToRay);
	}
}

