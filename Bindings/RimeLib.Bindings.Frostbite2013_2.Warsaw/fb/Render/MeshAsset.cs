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

namespace fb.Render;

[ContainerType(8, 96)]
public class MeshAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<MeshLodGroup> LodGroup { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ResourceRef MeshSetResource { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public ResourceRef OccluderMeshResource { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float LodScale { get; set; } = 1.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float CullScale { get; set; } = 1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float CoverageValue { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public EnlightenType EnlightenType { get; set; } = fb.Render.EnlightenType.EnlightenType_Dynamic;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<ProceduralAnimationTypeSimple> ProceduralAnimation { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public RefArray<MeshMaterial> Materials { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint NameHash { get; set; } = 0;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool StreamingEnable { get; set; } = true;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool OccluderMeshEnable { get; set; } = false;
	
	[ContainerField(0x56), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
	public bool OccluderHighPriority { get; set; } = false;
	
	[ContainerField(0x57), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
	public bool OccluderIsConservative { get; set; } = true;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool DestructionMaterialEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(LodGroup));
		p_Writer.WriteNullBytes(4);
		MeshSetResource.Serialize(p_Writer);
		OccluderMeshResource.Serialize(p_Writer);
		p_Writer.Write(LodScale);
		p_Writer.Write(CullScale);
		p_Writer.Write(CoverageValue);
		p_Writer.Write((int) EnlightenType);
		p_Writer.Write(p_EbxWriter.WriteImport(ProceduralAnimation));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Materials = p_EbxWriter.GetArrayWriter(Materials.GetType(), Materials.Count);
		p_Writer.Write(s_Materials.ArrayIndex);
		foreach (var s_Entry in Materials)
		{
			s_Materials.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(NameHash);
		p_Writer.Write(StreamingEnable);
		p_Writer.Write(OccluderMeshEnable);
		p_Writer.Write(OccluderHighPriority);
		p_Writer.Write(OccluderIsConservative);
		p_Writer.Write(DestructionMaterialEnable);
		p_Writer.WriteNullBytes(7);
	}
}

