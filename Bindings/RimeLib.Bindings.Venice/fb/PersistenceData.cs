///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class PersistenceData : 
		AbstractPersistenceData
	{
		protected string m_PersistenceName = new string();
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(1594500373)]
		public string PersistenceName { get { return m_PersistenceName; } set { if (OnPropertyChanging("PersistenceData." + nameof(PersistenceName), this, m_PersistenceName, value)) m_PersistenceName = value; } } // 0xC (12)
		
		protected string m_ClubPersistenceName = new string();
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(1035208813)]
		public string ClubPersistenceName { get { return m_ClubPersistenceName; } set { if (OnPropertyChanging("PersistenceData." + nameof(ClubPersistenceName), this, m_ClubPersistenceName, value)) m_ClubPersistenceName = value; } } // 0x10 (16)
		
		protected CtrRef<PersistenceStatGroup> m_ClientDefaultGroup = new CtrRef<PersistenceStatGroup>();
		[ContainerField(20), ContainerFieldNameHash(2136132136)]
		public CtrRef<PersistenceStatGroup> ClientDefaultGroup { get { return m_ClientDefaultGroup; } set { if (OnPropertyChanging("PersistenceData." + nameof(ClientDefaultGroup), this, m_ClientDefaultGroup, value)) m_ClientDefaultGroup = value; } } // 0x14 (20)
		
		protected List<PersistentValueTemplateData> m_Values = new List<PersistentValueTemplateData>();
		[ContainerField(24), ContainerFieldNameHash(3142410589)]
		public List<PersistentValueTemplateData> Values { get { return m_Values; } set { if (OnPropertyChanging("PersistenceData." + nameof(Values), this, m_Values, value)) m_Values = value; } } // 0x18 (24)
		
		protected List<CustomReportValueData> m_CustomReportValues = new List<CustomReportValueData>();
		[ContainerField(28), ContainerFieldNameHash(982732000)]
		public List<CustomReportValueData> CustomReportValues { get { return m_CustomReportValues; } set { if (OnPropertyChanging("PersistenceData." + nameof(CustomReportValues), this, m_CustomReportValues, value)) m_CustomReportValues = value; } } // 0x1C (28)
		
		protected CtrRef<PersistenceStatGroup> m_ServerDefaultGroup = new CtrRef<PersistenceStatGroup>();
		[ContainerField(32), ContainerFieldNameHash(1370365556)]
		public CtrRef<PersistenceStatGroup> ServerDefaultGroup { get { return m_ServerDefaultGroup; } set { if (OnPropertyChanging("PersistenceData." + nameof(ServerDefaultGroup), this, m_ServerDefaultGroup, value)) m_ServerDefaultGroup = value; } } // 0x20 (32)
		
		protected CtrRef<PersistenceRetentionPolicy> m_RetentionPolicy = new CtrRef<PersistenceRetentionPolicy>();
		[ContainerField(36), ContainerFieldNameHash(1323382353)]
		public CtrRef<PersistenceRetentionPolicy> RetentionPolicy { get { return m_RetentionPolicy; } set { if (OnPropertyChanging("PersistenceData." + nameof(RetentionPolicy), this, m_RetentionPolicy, value)) m_RetentionPolicy = value; } } // 0x24 (36)
		
		protected List<PersistenceConsumableMapping> m_ConsumableMappings = new List<PersistenceConsumableMapping>();
		[ContainerField(40), ContainerFieldNameHash(420464793)]
		public List<PersistenceConsumableMapping> ConsumableMappings { get { return m_ConsumableMappings; } set { if (OnPropertyChanging("PersistenceData." + nameof(ConsumableMappings), this, m_ConsumableMappings, value)) m_ConsumableMappings = value; } } // 0x28 (40)
		
		protected bool m_HistoryDaily = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2252214046)]
		public bool HistoryDaily { get { return m_HistoryDaily; } set { if (OnPropertyChanging("PersistenceData." + nameof(HistoryDaily), this, m_HistoryDaily, value)) m_HistoryDaily = value; } } // 0x2C (44)
		
		protected bool m_HistoryWeekly = new bool();
		[ContainerField(45), LayoutImmutable, Blittable, ContainerFieldNameHash(1752784430)]
		public bool HistoryWeekly { get { return m_HistoryWeekly; } set { if (OnPropertyChanging("PersistenceData." + nameof(HistoryWeekly), this, m_HistoryWeekly, value)) m_HistoryWeekly = value; } } // 0x2D (45)
		
		protected bool m_HistoryMonthly = new bool();
		[ContainerField(46), LayoutImmutable, Blittable, ContainerFieldNameHash(3030502658)]
		public bool HistoryMonthly { get { return m_HistoryMonthly; } set { if (OnPropertyChanging("PersistenceData." + nameof(HistoryMonthly), this, m_HistoryMonthly, value)) m_HistoryMonthly = value; } } // 0x2E (46)
		
		protected bool m_OutputProperties = new bool();
		[ContainerField(47), LayoutImmutable, Blittable, ContainerFieldNameHash(1376339771)]
		public bool OutputProperties { get { return m_OutputProperties; } set { if (OnPropertyChanging("PersistenceData." + nameof(OutputProperties), this, m_OutputProperties, value)) m_OutputProperties = value; } } // 0x2F (47)
		
		protected bool m_DeltaGameReports = new bool();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(1383796302)]
		public bool DeltaGameReports { get { return m_DeltaGameReports; } set { if (OnPropertyChanging("PersistenceData." + nameof(DeltaGameReports), this, m_DeltaGameReports, value)) m_DeltaGameReports = value; } } // 0x30 (48)
		
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
