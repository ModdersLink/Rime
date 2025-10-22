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

namespace fb.VeniceShared;

[ContainerType(8, 56)]
public class StatCategoriesBaseTree
	: fb.Entity.TreeBase
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<StatsCategoryBaseData> RootBaseCategories { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<CriteriaData> ParamX { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<CriteriaData> ParamY { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool ProcessAllLevelsInTree { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_RootBaseCategories = p_EbxWriter.GetArrayWriter(RootBaseCategories.GetType(), RootBaseCategories.Count);
		p_Writer.Write(s_RootBaseCategories.ArrayIndex);
		foreach (var s_Entry in RootBaseCategories)
		{
			s_RootBaseCategories.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ParamX = p_EbxWriter.GetArrayWriter(ParamX.GetType(), ParamX.Count);
		p_Writer.Write(s_ParamX.ArrayIndex);
		foreach (var s_Entry in ParamX)
		{
			s_ParamX.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ParamY = p_EbxWriter.GetArrayWriter(ParamY.GetType(), ParamY.Count);
		p_Writer.Write(s_ParamY.ArrayIndex);
		foreach (var s_Entry in ParamY)
		{
			s_ParamY.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ProcessAllLevelsInTree);
		p_Writer.WriteNullBytes(7);
	}
}

