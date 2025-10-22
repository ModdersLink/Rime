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

namespace fb.GameShared;

[ContainerType(16, 224)]
public class StaticModelEntityData
	: fb.Physics.GamePhysicsEntityData
{
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public RefArray<PartLinkData> PartLinks { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public uint BoneCount { get; set; } = 0;
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public List<LinearTransform> BasePoseTransforms { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public List<PhysicsPartInfo> PhysicsPartInfos { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public StaticModelNetworkInfo NetworkInfo { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public bool ExcludeFromNearbyObjectDestruction { get; set; } = false;
	
	[ContainerField(0xd9), LayoutImmutable, Blittable, JsonProperty(Order = 217)]
	public bool AnimatePhysics { get; set; } = false;
	
	[ContainerField(0xda), LayoutImmutable, Blittable, JsonProperty(Order = 218)]
	public bool TerrainShaderNodesEnable { get; set; } = false;
	
	[ContainerField(0xdb), LayoutImmutable, Blittable, JsonProperty(Order = 219)]
	public bool Visible { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_PartLinks = p_EbxWriter.GetArrayWriter(PartLinks.GetType(), PartLinks.Count);
		p_Writer.Write(s_PartLinks.ArrayIndex);
		foreach (var s_Entry in PartLinks)
		{
			s_PartLinks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(BoneCount);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BasePoseTransforms = p_EbxWriter.GetArrayWriter(BasePoseTransforms.GetType(), BasePoseTransforms.Count);
		p_Writer.Write(s_BasePoseTransforms.ArrayIndex);
		foreach (var s_Entry in BasePoseTransforms)
		{
			s_Entry.Serialize(s_BasePoseTransforms.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PhysicsPartInfos = p_EbxWriter.GetArrayWriter(PhysicsPartInfos.GetType(), PhysicsPartInfos.Count);
		p_Writer.Write(s_PhysicsPartInfos.ArrayIndex);
		foreach (var s_Entry in PhysicsPartInfos)
		{
			s_Entry.Serialize(s_PhysicsPartInfos.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		NetworkInfo.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ExcludeFromNearbyObjectDestruction);
		p_Writer.Write(AnimatePhysics);
		p_Writer.Write(TerrainShaderNodesEnable);
		p_Writer.Write(Visible);
		p_Writer.WriteNullBytes(4);
	}
}

