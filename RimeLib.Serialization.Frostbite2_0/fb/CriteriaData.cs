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
	[ContainerType(4, 52)]
	public class CriteriaData :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float CompletionValue { get; set; }

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<CriteriaGateList> GateList { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public StatEvent Measuring { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public RefArray<StatsCategoryBaseData> OrParamsX { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CriteriaType CriteriaType { get; set; } = new();

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string DescriptionSid { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float ScaleFactor { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float Scale { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public bool ShouldSummarize { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		public bool ShouldHide { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		public bool CountEvents { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CompletionValue);
			p_Writer.Write(p_EbxWriter.WriteImport(GateList));
			p_Writer.Write((int) Measuring);
			p_Writer.Write(p_EbxWriter.WriteImport(ParamX));
			p_Writer.Write(p_EbxWriter.WriteImport(ParamY));
			(RimeWriter Writer, uint ArrayIndex) s_OrParamsX = p_EbxWriter.GetArrayWriter(OrParamsX.GetType(), OrParamsX.Count);
			p_Writer.Write(s_OrParamsX.ArrayIndex);
			foreach (var s_Entry in OrParamsX)
			{
				s_OrParamsX.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) CriteriaType);
			p_Writer.Write(p_EbxWriter.WriteString(DescriptionSid));
			p_Writer.Write(ScaleFactor);
			p_Writer.Write(Scale);
			p_Writer.Write(ShouldSummarize);
			p_Writer.Write(ShouldHide);
			p_Writer.Write(CountEvents);
			p_Writer.WriteNullBytes(1);
		}
	}
}
