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
	[ContainerType(4, 52)]
	public class PersistenceData :
		AbstractPersistenceData
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string PersistenceName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string ClubPersistenceName { get; set; } = string.Empty;

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<PersistenceStatGroup> ClientDefaultGroup { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<PersistentValueTemplateData> Values { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public List<CustomReportValueData> CustomReportValues { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<PersistenceStatGroup> ServerDefaultGroup { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<PersistenceRetentionPolicy> RetentionPolicy { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public List<PersistenceConsumableMapping> ConsumableMappings { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool HistoryDaily { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public bool HistoryWeekly { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		public bool HistoryMonthly { get; set; }

		[ContainerField(47), LayoutImmutable, Blittable, JsonProperty(Order = 47)]
		public bool OutputProperties { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public bool DeltaGameReports { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(PersistenceName));
			p_Writer.Write(p_EbxWriter.WriteString(ClubPersistenceName));
			p_Writer.Write(p_EbxWriter.WriteImport(ClientDefaultGroup));
			(RimeWriter Writer, uint ArrayIndex) s_Values = p_EbxWriter.GetArrayWriter(Values.GetType(), Values.Count);
			p_Writer.Write(s_Values.ArrayIndex);
			foreach (var s_Entry in Values)
			{
				s_Entry.Serialize(s_Values.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_CustomReportValues = p_EbxWriter.GetArrayWriter(CustomReportValues.GetType(), CustomReportValues.Count);
			p_Writer.Write(s_CustomReportValues.ArrayIndex);
			foreach (var s_Entry in CustomReportValues)
			{
				s_Entry.Serialize(s_CustomReportValues.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(ServerDefaultGroup));
			p_Writer.Write(p_EbxWriter.WriteImport(RetentionPolicy));
			(RimeWriter Writer, uint ArrayIndex) s_ConsumableMappings = p_EbxWriter.GetArrayWriter(ConsumableMappings.GetType(), ConsumableMappings.Count);
			p_Writer.Write(s_ConsumableMappings.ArrayIndex);
			foreach (var s_Entry in ConsumableMappings)
			{
				s_Entry.Serialize(s_ConsumableMappings.Writer, p_EbxWriter);
			}
			p_Writer.Write(HistoryDaily);
			p_Writer.Write(HistoryWeekly);
			p_Writer.Write(HistoryMonthly);
			p_Writer.Write(OutputProperties);
			p_Writer.Write(DeltaGameReports);
			p_Writer.WriteNullBytes(3);
		}
	}
}
