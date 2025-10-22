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

[ContainerType(8, 72)]
public class MaterialGridData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public MaterialDecl DefaultMaterial { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<MaterialDecl> MaterialPairs { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<uint> MaterialIndexMap { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint DefaultMaterialIndex { get; set; } = 0;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<MaterialRelationPropertyPair> MaterialProperties { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<MaterialInteractionGridRow> InteractionGrid { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		DefaultMaterial.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_MaterialPairs = p_EbxWriter.GetArrayWriter(MaterialPairs.GetType(), MaterialPairs.Count);
		p_Writer.Write(s_MaterialPairs.ArrayIndex);
		foreach (var s_Entry in MaterialPairs)
		{
			s_Entry.Serialize(s_MaterialPairs.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_MaterialIndexMap = p_EbxWriter.GetArrayWriter(MaterialIndexMap.GetType(), MaterialIndexMap.Count);
		p_Writer.Write(s_MaterialIndexMap.ArrayIndex);
		foreach (var s_Entry in MaterialIndexMap)
		{
			s_MaterialIndexMap.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DefaultMaterialIndex);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_MaterialProperties = p_EbxWriter.GetArrayWriter(MaterialProperties.GetType(), MaterialProperties.Count);
		p_Writer.Write(s_MaterialProperties.ArrayIndex);
		foreach (var s_Entry in MaterialProperties)
		{
			s_Entry.Serialize(s_MaterialProperties.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InteractionGrid = p_EbxWriter.GetArrayWriter(InteractionGrid.GetType(), InteractionGrid.Count);
		p_Writer.Write(s_InteractionGrid.ArrayIndex);
		foreach (var s_Entry in InteractionGrid)
		{
			s_Entry.Serialize(s_InteractionGrid.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

