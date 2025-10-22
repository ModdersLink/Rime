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
using fb.Physics;
using fb.Entity;

namespace fb.Vegetation;

[ContainerType(16, 224)]
public class VegetationBaseEntityData
	: fb.Entity.GameComponentEntityData
{
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public List<LinearTransform> BasePoseTransforms { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public List<int> Hierarchy { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public List<LinearTransform> LowResBasePoseTransforms { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public List<int> LowResHierarchy { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public List<int> PartIndirection { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public List<int> PartHierarchy { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public List<float> PartInitialHealths { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<SkinnedMeshAsset> ShadowMesh { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public List<bool> BoneIsStem { get; set; } = new();
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<PhysicsEntityData> PhysicsData { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_BasePoseTransforms = p_EbxWriter.GetArrayWriter(BasePoseTransforms.GetType(), BasePoseTransforms.Count);
		p_Writer.Write(s_BasePoseTransforms.ArrayIndex);
		foreach (var s_Entry in BasePoseTransforms)
		{
			s_Entry.Serialize(s_BasePoseTransforms.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Hierarchy = p_EbxWriter.GetArrayWriter(Hierarchy.GetType(), Hierarchy.Count);
		p_Writer.Write(s_Hierarchy.ArrayIndex);
		foreach (var s_Entry in Hierarchy)
		{
			s_Hierarchy.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LowResBasePoseTransforms = p_EbxWriter.GetArrayWriter(LowResBasePoseTransforms.GetType(), LowResBasePoseTransforms.Count);
		p_Writer.Write(s_LowResBasePoseTransforms.ArrayIndex);
		foreach (var s_Entry in LowResBasePoseTransforms)
		{
			s_Entry.Serialize(s_LowResBasePoseTransforms.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LowResHierarchy = p_EbxWriter.GetArrayWriter(LowResHierarchy.GetType(), LowResHierarchy.Count);
		p_Writer.Write(s_LowResHierarchy.ArrayIndex);
		foreach (var s_Entry in LowResHierarchy)
		{
			s_LowResHierarchy.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PartIndirection = p_EbxWriter.GetArrayWriter(PartIndirection.GetType(), PartIndirection.Count);
		p_Writer.Write(s_PartIndirection.ArrayIndex);
		foreach (var s_Entry in PartIndirection)
		{
			s_PartIndirection.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PartHierarchy = p_EbxWriter.GetArrayWriter(PartHierarchy.GetType(), PartHierarchy.Count);
		p_Writer.Write(s_PartHierarchy.ArrayIndex);
		foreach (var s_Entry in PartHierarchy)
		{
			s_PartHierarchy.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PartInitialHealths = p_EbxWriter.GetArrayWriter(PartInitialHealths.GetType(), PartInitialHealths.Count);
		p_Writer.Write(s_PartInitialHealths.ArrayIndex);
		foreach (var s_Entry in PartInitialHealths)
		{
			s_PartInitialHealths.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ShadowMesh));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BoneIsStem = p_EbxWriter.GetArrayWriter(BoneIsStem.GetType(), BoneIsStem.Count);
		p_Writer.Write(s_BoneIsStem.ArrayIndex);
		foreach (var s_Entry in BoneIsStem)
		{
			s_BoneIsStem.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PhysicsData));
		p_Writer.WriteNullBytes(12);
	}
}

