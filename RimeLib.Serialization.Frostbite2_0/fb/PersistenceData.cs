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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 52)]
	public partial class PersistenceData :
		AbstractPersistenceData
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _PersistenceName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _ClubPersistenceName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<PersistenceStatGroup> _ClientDefaultGroup = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<PersistentValueTemplateData> _Values = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private List<CustomReportValueData> _CustomReportValues = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<PersistenceStatGroup> _ServerDefaultGroup = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private CtrRef<PersistenceRetentionPolicy> _RetentionPolicy = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private List<PersistenceConsumableMapping> _ConsumableMappings = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _HistoryDaily;

		[ObservableProperty]
		[property: ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		private bool _HistoryWeekly;

		[ObservableProperty]
		[property: ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		private bool _HistoryMonthly;

		[ObservableProperty]
		[property: ContainerField(47), LayoutImmutable, Blittable, JsonProperty(Order = 47)]
		private bool _OutputProperties;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private bool _DeltaGameReports;

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
