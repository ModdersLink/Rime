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
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 304)]
public class RagdollComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<RagdollAsset> RagdollAsset { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<SkeletonCollisionData> SkeletonCollisionData { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public RagdollBinding Binding { get; set; } = new();
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public string LeftLegBoneName { get; set; } = string.Empty;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public string RightLegBoneName { get; set; } = string.Empty;
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public List<MaterialDecl> BoneMaterials { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public List<BuoyantPartsData> BuoyantParts { get; set; } = new();
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public bool AllowClientTriggerOnBlend { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SkeletonAsset));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RagdollAsset));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SkeletonCollisionData));
		p_Writer.WriteNullBytes(4);
		Binding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(LeftLegBoneName));
		p_Writer.Write(p_EbxWriter.WriteString(RightLegBoneName));
		(RimeWriter Writer, uint ArrayIndex) s_BoneMaterials = p_EbxWriter.GetArrayWriter(BoneMaterials.GetType(), BoneMaterials.Count);
		p_Writer.Write(s_BoneMaterials.ArrayIndex);
		foreach (var s_Entry in BoneMaterials)
		{
			s_Entry.Serialize(s_BoneMaterials.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BuoyantParts = p_EbxWriter.GetArrayWriter(BuoyantParts.GetType(), BuoyantParts.Count);
		p_Writer.Write(s_BuoyantParts.ArrayIndex);
		foreach (var s_Entry in BuoyantParts)
		{
			s_Entry.Serialize(s_BuoyantParts.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AllowClientTriggerOnBlend);
		p_Writer.WriteNullBytes(15);
	}
}

