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

using fb.Entity;
using fb.Render;
using fb.Core;

namespace fb.GameShared;

[ContainerType(16, 144)]
public class MeshComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<SkeletonAsset> Skeleton { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_BoneFakePhysics = p_EbxWriter.GetArrayWriter(BoneFakePhysics.GetType(), BoneFakePhysics.Count);
		p_Writer.Write(s_BoneFakePhysics.ArrayIndex);
		foreach (var s_Entry in BoneFakePhysics)
		{
			s_BoneFakePhysics.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Skeleton));
		p_Writer.WriteNullBytes(12);
	}
}

