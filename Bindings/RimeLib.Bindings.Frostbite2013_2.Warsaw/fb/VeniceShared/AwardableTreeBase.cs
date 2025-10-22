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

[ContainerType(8, 48)]
public class AwardableTreeBase
	: fb.Entity.TreeBase
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<StatCategoryTreeCollection> StatCategoryTreeCollection { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<CriteriaData> GeneralCriteria { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool GeneralStatistics { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(StatCategoryTreeCollection));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_GeneralCriteria = p_EbxWriter.GetArrayWriter(GeneralCriteria.GetType(), GeneralCriteria.Count);
		p_Writer.Write(s_GeneralCriteria.ArrayIndex);
		foreach (var s_Entry in GeneralCriteria)
		{
			s_GeneralCriteria.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(GeneralStatistics);
		p_Writer.WriteNullBytes(7);
	}
}

