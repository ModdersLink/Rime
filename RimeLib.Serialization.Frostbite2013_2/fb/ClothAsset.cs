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

namespace fb.Physics;

[ContainerType(8, 88)]
public class ClothAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<ClothSectionMapping> MeshSectionMappings { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ResourceRef HavokClothResource { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public ClothStatesSetup StatesSetup { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<uint> DisplayBufferIndices { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public List<ClothBoneTableEntry> BoneTable { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_MeshSectionMappings = p_EbxWriter.GetArrayWriter(MeshSectionMappings.GetType(), MeshSectionMappings.Count);
		p_Writer.Write(s_MeshSectionMappings.ArrayIndex);
		foreach (var s_Entry in MeshSectionMappings)
		{
			s_Entry.Serialize(s_MeshSectionMappings.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		HavokClothResource.Serialize(p_Writer);
		StatesSetup.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_DisplayBufferIndices = p_EbxWriter.GetArrayWriter(DisplayBufferIndices.GetType(), DisplayBufferIndices.Count);
		p_Writer.Write(s_DisplayBufferIndices.ArrayIndex);
		foreach (var s_Entry in DisplayBufferIndices)
		{
			s_DisplayBufferIndices.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BoneTable = p_EbxWriter.GetArrayWriter(BoneTable.GetType(), BoneTable.Count);
		p_Writer.Write(s_BoneTable.ArrayIndex);
		foreach (var s_Entry in BoneTable)
		{
			s_Entry.Serialize(s_BoneTable.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

