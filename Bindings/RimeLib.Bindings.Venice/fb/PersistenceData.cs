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

	}
}
