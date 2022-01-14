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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class StatsCategoryBaseData :
		TreeNodeBase
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<StatsCategoryBaseData> BaseSubCategories { get; set; } = new();

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string Code { get; set; } = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_BaseSubCategories = p_EbxWriter.GetArrayWriter(BaseSubCategories.GetType(), BaseSubCategories.Count);
			p_Writer.Write(s_BaseSubCategories.ArrayIndex);
			foreach (var s_Entry in BaseSubCategories)
			{
				s_BaseSubCategories.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteString(Code));
		}
	}
}
