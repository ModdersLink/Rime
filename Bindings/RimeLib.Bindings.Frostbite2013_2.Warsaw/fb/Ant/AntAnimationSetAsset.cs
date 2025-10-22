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
using fb.Entity;

namespace fb.Ant;

[ContainerType(8, 72)]
public class AntAnimationSetAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ResourceRef AssetBankResource { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int ActorAssetIndex { get; set; } = -1;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<int> ClipAssetIndices { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<int> LoopingClipAssetIndices { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public int SceneOpMatrixAssetIndex { get; set; } = -1;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool UseTraj2Ref { get; set; } = false;
	
	[ContainerField(0x45), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
	public bool AllowAnimationCulling { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SkeletonAsset));
		p_Writer.WriteNullBytes(4);
		AssetBankResource.Serialize(p_Writer);
		p_Writer.Write(ActorAssetIndex);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ClipAssetIndices = p_EbxWriter.GetArrayWriter(ClipAssetIndices.GetType(), ClipAssetIndices.Count);
		p_Writer.Write(s_ClipAssetIndices.ArrayIndex);
		foreach (var s_Entry in ClipAssetIndices)
		{
			s_ClipAssetIndices.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LoopingClipAssetIndices = p_EbxWriter.GetArrayWriter(LoopingClipAssetIndices.GetType(), LoopingClipAssetIndices.Count);
		p_Writer.Write(s_LoopingClipAssetIndices.ArrayIndex);
		foreach (var s_Entry in LoopingClipAssetIndices)
		{
			s_LoopingClipAssetIndices.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SceneOpMatrixAssetIndex);
		p_Writer.Write(UseTraj2Ref);
		p_Writer.Write(AllowAnimationCulling);
		p_Writer.WriteNullBytes(2);
	}
}

