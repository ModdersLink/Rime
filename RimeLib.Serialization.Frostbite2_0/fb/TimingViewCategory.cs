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
	[ContainerType(4, 28)]
	public class TimingViewCategory :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string CategoryName { get; set; } = string.Empty;

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<string> Keywords { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float SpuBudget { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float CpuBudget { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float GpuBudget { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(CategoryName));
			(RimeWriter Writer, uint ArrayIndex) s_Keywords = p_EbxWriter.GetArrayWriter(Keywords.GetType(), Keywords.Count);
			p_Writer.Write(s_Keywords.ArrayIndex);
			foreach (var s_Entry in Keywords)
			{
				s_Keywords.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(SpuBudget);
			p_Writer.Write(CpuBudget);
			p_Writer.Write(GpuBudget);
		}
	}
}
