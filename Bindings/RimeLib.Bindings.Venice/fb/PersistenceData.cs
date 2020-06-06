///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class PersistenceData : 
		AbstractPersistenceData
	{
		[ContainerField(12), LayoutImmutable]
		public string PersistenceName { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string ClubPersistenceName { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<PersistenceStatGroup> ClientDefaultGroup { get; set; } = new CtrRef<PersistenceStatGroup>(); // 0x14 (20)
		
		[ContainerField(24)]
		public List<PersistentValueTemplateData> Values { get; set; } = new List<PersistentValueTemplateData>(); // 0x18 (24)
		
		[ContainerField(28)]
		public List<CustomReportValueData> CustomReportValues { get; set; } = new List<CustomReportValueData>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<PersistenceStatGroup> ServerDefaultGroup { get; set; } = new CtrRef<PersistenceStatGroup>(); // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<PersistenceRetentionPolicy> RetentionPolicy { get; set; } = new CtrRef<PersistenceRetentionPolicy>(); // 0x24 (36)
		
		[ContainerField(40)]
		public List<PersistenceConsumableMapping> ConsumableMappings { get; set; } = new List<PersistenceConsumableMapping>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool HistoryDaily { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool HistoryWeekly { get; set; } // 0x2D (45)
		
		[ContainerField(46), LayoutImmutable, Blittable]
		public bool HistoryMonthly { get; set; } // 0x2E (46)
		
		[ContainerField(47), LayoutImmutable, Blittable]
		public bool OutputProperties { get; set; } // 0x2F (47)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool DeltaGameReports { get; set; } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1594500373:
					PersistenceName = (string) p_Value;
					break;

				case 1035208813:
					ClubPersistenceName = (string) p_Value;
					break;

				case 2136132136:
					ClientDefaultGroup = (CtrRef<PersistenceStatGroup>) p_Value;
					break;

				case 3142410589:
					Values = (List<PersistentValueTemplateData>) p_Value;
					break;

				case 982732000:
					CustomReportValues = (List<CustomReportValueData>) p_Value;
					break;

				case 1370365556:
					ServerDefaultGroup = (CtrRef<PersistenceStatGroup>) p_Value;
					break;

				case 1323382353:
					RetentionPolicy = (CtrRef<PersistenceRetentionPolicy>) p_Value;
					break;

				case 420464793:
					ConsumableMappings = (List<PersistenceConsumableMapping>) p_Value;
					break;

				case 2252214046:
					HistoryDaily = (bool) p_Value;
					break;

				case 1752784430:
					HistoryWeekly = (bool) p_Value;
					break;

				case 3030502658:
					HistoryMonthly = (bool) p_Value;
					break;

				case 1376339771:
					OutputProperties = (bool) p_Value;
					break;

				case 1383796302:
					DeltaGameReports = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1594500373:
					return PersistenceName;

				case 1035208813:
					return ClubPersistenceName;

				case 2136132136:
					return ClientDefaultGroup;

				case 3142410589:
					return Values;

				case 982732000:
					return CustomReportValues;

				case 1370365556:
					return ServerDefaultGroup;

				case 1323382353:
					return RetentionPolicy;

				case 420464793:
					return ConsumableMappings;

				case 2252214046:
					return HistoryDaily;

				case 1752784430:
					return HistoryWeekly;

				case 3030502658:
					return HistoryMonthly;

				case 1376339771:
					return OutputProperties;

				case 1383796302:
					return DeltaGameReports;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1594500373:
					return typeof(PersistenceData).GetProperty(nameof(PersistenceName));

				case 1035208813:
					return typeof(PersistenceData).GetProperty(nameof(ClubPersistenceName));

				case 2136132136:
					return typeof(PersistenceData).GetProperty(nameof(ClientDefaultGroup));

				case 3142410589:
					return typeof(PersistenceData).GetProperty(nameof(Values));

				case 982732000:
					return typeof(PersistenceData).GetProperty(nameof(CustomReportValues));

				case 1370365556:
					return typeof(PersistenceData).GetProperty(nameof(ServerDefaultGroup));

				case 1323382353:
					return typeof(PersistenceData).GetProperty(nameof(RetentionPolicy));

				case 420464793:
					return typeof(PersistenceData).GetProperty(nameof(ConsumableMappings));

				case 2252214046:
					return typeof(PersistenceData).GetProperty(nameof(HistoryDaily));

				case 1752784430:
					return typeof(PersistenceData).GetProperty(nameof(HistoryWeekly));

				case 3030502658:
					return typeof(PersistenceData).GetProperty(nameof(HistoryMonthly));

				case 1376339771:
					return typeof(PersistenceData).GetProperty(nameof(OutputProperties));

				case 1383796302:
					return typeof(PersistenceData).GetProperty(nameof(DeltaGameReports));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
