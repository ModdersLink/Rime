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

namespace fb.Destruction;

[ContainerType(8, 72)]
public class ConnectivityEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<int> BreakableModelEventIds { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<int> StaticModelEventIds { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<uint> StaticModelFirstIndices { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<StaticModelToBreakableParts> StaticModelToBreakablePartsArray { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<BreakablePartToStaticEntityPart> BreakablePartToStaticModelPartArray { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float BreakableModelExtraRadius { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_BreakableModelEventIds = p_EbxWriter.GetArrayWriter(BreakableModelEventIds.GetType(), BreakableModelEventIds.Count);
		p_Writer.Write(s_BreakableModelEventIds.ArrayIndex);
		foreach (var s_Entry in BreakableModelEventIds)
		{
			s_BreakableModelEventIds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_StaticModelEventIds = p_EbxWriter.GetArrayWriter(StaticModelEventIds.GetType(), StaticModelEventIds.Count);
		p_Writer.Write(s_StaticModelEventIds.ArrayIndex);
		foreach (var s_Entry in StaticModelEventIds)
		{
			s_StaticModelEventIds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_StaticModelFirstIndices = p_EbxWriter.GetArrayWriter(StaticModelFirstIndices.GetType(), StaticModelFirstIndices.Count);
		p_Writer.Write(s_StaticModelFirstIndices.ArrayIndex);
		foreach (var s_Entry in StaticModelFirstIndices)
		{
			s_StaticModelFirstIndices.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_StaticModelToBreakablePartsArray = p_EbxWriter.GetArrayWriter(StaticModelToBreakablePartsArray.GetType(), StaticModelToBreakablePartsArray.Count);
		p_Writer.Write(s_StaticModelToBreakablePartsArray.ArrayIndex);
		foreach (var s_Entry in StaticModelToBreakablePartsArray)
		{
			s_Entry.Serialize(s_StaticModelToBreakablePartsArray.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BreakablePartToStaticModelPartArray = p_EbxWriter.GetArrayWriter(BreakablePartToStaticModelPartArray.GetType(), BreakablePartToStaticModelPartArray.Count);
		p_Writer.Write(s_BreakablePartToStaticModelPartArray.ArrayIndex);
		foreach (var s_Entry in BreakablePartToStaticModelPartArray)
		{
			s_Entry.Serialize(s_BreakablePartToStaticModelPartArray.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(BreakableModelExtraRadius);
		p_Writer.WriteNullBytes(4);
	}
}

