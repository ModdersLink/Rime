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

namespace fb.Entity;

[ContainerType(8, 104)]
public class SkeletonAsset
	: fb.Entity.BaseSkeletonAsset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<string> BoneNames { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<uint> BoneNameHashes { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<int> Hierarchy { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<LinearTransform> LocalPose { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<LinearTransform> ModelPose { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<int> ServerSkeletonToSkeletonMap { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<int> SkeletonToServerSkeletonMap { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public List<int> ServerHierarchy { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public List<int> GameplayBonesToSkeleton { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public List<int> GameplayBonesToServerSkeleton { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_BoneNames = p_EbxWriter.GetArrayWriter(BoneNames.GetType(), BoneNames.Count);
		p_Writer.Write(s_BoneNames.ArrayIndex);
		foreach (var s_Entry in BoneNames)
		{
			s_BoneNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BoneNameHashes = p_EbxWriter.GetArrayWriter(BoneNameHashes.GetType(), BoneNameHashes.Count);
		p_Writer.Write(s_BoneNameHashes.ArrayIndex);
		foreach (var s_Entry in BoneNameHashes)
		{
			s_BoneNameHashes.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Hierarchy = p_EbxWriter.GetArrayWriter(Hierarchy.GetType(), Hierarchy.Count);
		p_Writer.Write(s_Hierarchy.ArrayIndex);
		foreach (var s_Entry in Hierarchy)
		{
			s_Hierarchy.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LocalPose = p_EbxWriter.GetArrayWriter(LocalPose.GetType(), LocalPose.Count);
		p_Writer.Write(s_LocalPose.ArrayIndex);
		foreach (var s_Entry in LocalPose)
		{
			s_Entry.Serialize(s_LocalPose.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ModelPose = p_EbxWriter.GetArrayWriter(ModelPose.GetType(), ModelPose.Count);
		p_Writer.Write(s_ModelPose.ArrayIndex);
		foreach (var s_Entry in ModelPose)
		{
			s_Entry.Serialize(s_ModelPose.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ServerSkeletonToSkeletonMap = p_EbxWriter.GetArrayWriter(ServerSkeletonToSkeletonMap.GetType(), ServerSkeletonToSkeletonMap.Count);
		p_Writer.Write(s_ServerSkeletonToSkeletonMap.ArrayIndex);
		foreach (var s_Entry in ServerSkeletonToSkeletonMap)
		{
			s_ServerSkeletonToSkeletonMap.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SkeletonToServerSkeletonMap = p_EbxWriter.GetArrayWriter(SkeletonToServerSkeletonMap.GetType(), SkeletonToServerSkeletonMap.Count);
		p_Writer.Write(s_SkeletonToServerSkeletonMap.ArrayIndex);
		foreach (var s_Entry in SkeletonToServerSkeletonMap)
		{
			s_SkeletonToServerSkeletonMap.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ServerHierarchy = p_EbxWriter.GetArrayWriter(ServerHierarchy.GetType(), ServerHierarchy.Count);
		p_Writer.Write(s_ServerHierarchy.ArrayIndex);
		foreach (var s_Entry in ServerHierarchy)
		{
			s_ServerHierarchy.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_GameplayBonesToSkeleton = p_EbxWriter.GetArrayWriter(GameplayBonesToSkeleton.GetType(), GameplayBonesToSkeleton.Count);
		p_Writer.Write(s_GameplayBonesToSkeleton.ArrayIndex);
		foreach (var s_Entry in GameplayBonesToSkeleton)
		{
			s_GameplayBonesToSkeleton.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_GameplayBonesToServerSkeleton = p_EbxWriter.GetArrayWriter(GameplayBonesToServerSkeleton.GetType(), GameplayBonesToServerSkeleton.Count);
		p_Writer.Write(s_GameplayBonesToServerSkeleton.ArrayIndex);
		foreach (var s_Entry in GameplayBonesToServerSkeleton)
		{
			s_GameplayBonesToServerSkeleton.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

