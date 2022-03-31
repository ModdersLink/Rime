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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class AwardableTreeBase :
		TreeBase
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<StatCategoryTreeCollection> StatCategoryTreeCollection { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<CriteriaData> GeneralCriteria { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool GeneralStatistics { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(StatCategoryTreeCollection));
			(RimeWriter Writer, uint ArrayIndex) s_GeneralCriteria = p_EbxWriter.GetArrayWriter(GeneralCriteria.GetType(), GeneralCriteria.Count);
			p_Writer.Write(s_GeneralCriteria.ArrayIndex);
			foreach (var s_Entry in GeneralCriteria)
			{
				s_GeneralCriteria.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(GeneralStatistics);
			p_Writer.WriteNullBytes(3);
		}
	}
}
