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
	public class ServerMetricsSettings : 
		DataContainer
	{
		protected string m_ReportName = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(3796964268)]
		public string ReportName { get { return m_ReportName; } set { if (OnPropertyChanging("ServerMetricsSettings." + nameof(ReportName), this, m_ReportName, value)) m_ReportName = value; } } // 0x8 (8)
		
		protected bool m_Enabled = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("ServerMetricsSettings." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0xC (12)
		
		protected bool m_DbxReportEnabled = new bool();
		[ContainerField(13), LayoutImmutable, Blittable, ContainerFieldNameHash(1024647888)]
		public bool DbxReportEnabled { get { return m_DbxReportEnabled; } set { if (OnPropertyChanging("ServerMetricsSettings." + nameof(DbxReportEnabled), this, m_DbxReportEnabled, value)) m_DbxReportEnabled = value; } } // 0xD (13)
		
		protected bool m_TickTelemetryEnabled = new bool();
		[ContainerField(14), LayoutImmutable, Blittable, ContainerFieldNameHash(1626619386)]
		public bool TickTelemetryEnabled { get { return m_TickTelemetryEnabled; } set { if (OnPropertyChanging("ServerMetricsSettings." + nameof(TickTelemetryEnabled), this, m_TickTelemetryEnabled, value)) m_TickTelemetryEnabled = value; } } // 0xE (14)
		
		protected bool m_DevelopmentTelemetryEnabled = new bool();
		[ContainerField(15), LayoutImmutable, Blittable, ContainerFieldNameHash(3737843804)]
		public bool DevelopmentTelemetryEnabled { get { return m_DevelopmentTelemetryEnabled; } set { if (OnPropertyChanging("ServerMetricsSettings." + nameof(DevelopmentTelemetryEnabled), this, m_DevelopmentTelemetryEnabled, value)) m_DevelopmentTelemetryEnabled = value; } } // 0xF (15)
		
		protected bool m_PerformanceTelemetryEnabled = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(4251590071)]
		public bool PerformanceTelemetryEnabled { get { return m_PerformanceTelemetryEnabled; } set { if (OnPropertyChanging("ServerMetricsSettings." + nameof(PerformanceTelemetryEnabled), this, m_PerformanceTelemetryEnabled, value)) m_PerformanceTelemetryEnabled = value; } } // 0x10 (16)
		
		protected bool m_JuiceTelemetryEnabled = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, ContainerFieldNameHash(4037238111)]
		public bool JuiceTelemetryEnabled { get { return m_JuiceTelemetryEnabled; } set { if (OnPropertyChanging("ServerMetricsSettings." + nameof(JuiceTelemetryEnabled), this, m_JuiceTelemetryEnabled, value)) m_JuiceTelemetryEnabled = value; } } // 0x11 (17)
		
		protected bool m_PerformanceProfileStateEnabled = new bool();
		[ContainerField(18), LayoutImmutable, Blittable, ContainerFieldNameHash(3999842340)]
		public bool PerformanceProfileStateEnabled { get { return m_PerformanceProfileStateEnabled; } set { if (OnPropertyChanging("ServerMetricsSettings." + nameof(PerformanceProfileStateEnabled), this, m_PerformanceProfileStateEnabled, value)) m_PerformanceProfileStateEnabled = value; } } // 0x12 (18)
		
		protected bool m_TransactionTelemetryEnabled = new bool();
		[ContainerField(19), LayoutImmutable, Blittable, ContainerFieldNameHash(2302981003)]
		public bool TransactionTelemetryEnabled { get { return m_TransactionTelemetryEnabled; } set { if (OnPropertyChanging("ServerMetricsSettings." + nameof(TransactionTelemetryEnabled), this, m_TransactionTelemetryEnabled, value)) m_TransactionTelemetryEnabled = value; } } // 0x13 (19)
		
		protected bool m_CompressTransactions = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1385035316)]
		public bool CompressTransactions { get { return m_CompressTransactions; } set { if (OnPropertyChanging("ServerMetricsSettings." + nameof(CompressTransactions), this, m_CompressTransactions, value)) m_CompressTransactions = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3796964268:
					ReportName = (string) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
					break;

				case 1024647888:
					DbxReportEnabled = (bool) p_Value;
					break;

				case 1626619386:
					TickTelemetryEnabled = (bool) p_Value;
					break;

				case 3737843804:
					DevelopmentTelemetryEnabled = (bool) p_Value;
					break;

				case 4251590071:
					PerformanceTelemetryEnabled = (bool) p_Value;
					break;

				case 4037238111:
					JuiceTelemetryEnabled = (bool) p_Value;
					break;

				case 3999842340:
					PerformanceProfileStateEnabled = (bool) p_Value;
					break;

				case 2302981003:
					TransactionTelemetryEnabled = (bool) p_Value;
					break;

				case 1385035316:
					CompressTransactions = (bool) p_Value;
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
				case 3796964268:
					return ReportName;

				case 2662400:
					return Enabled;

				case 1024647888:
					return DbxReportEnabled;

				case 1626619386:
					return TickTelemetryEnabled;

				case 3737843804:
					return DevelopmentTelemetryEnabled;

				case 4251590071:
					return PerformanceTelemetryEnabled;

				case 4037238111:
					return JuiceTelemetryEnabled;

				case 3999842340:
					return PerformanceProfileStateEnabled;

				case 2302981003:
					return TransactionTelemetryEnabled;

				case 1385035316:
					return CompressTransactions;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3796964268:
					return typeof(ServerMetricsSettings).GetProperty(nameof(ReportName));

				case 2662400:
					return typeof(ServerMetricsSettings).GetProperty(nameof(Enabled));

				case 1024647888:
					return typeof(ServerMetricsSettings).GetProperty(nameof(DbxReportEnabled));

				case 1626619386:
					return typeof(ServerMetricsSettings).GetProperty(nameof(TickTelemetryEnabled));

				case 3737843804:
					return typeof(ServerMetricsSettings).GetProperty(nameof(DevelopmentTelemetryEnabled));

				case 4251590071:
					return typeof(ServerMetricsSettings).GetProperty(nameof(PerformanceTelemetryEnabled));

				case 4037238111:
					return typeof(ServerMetricsSettings).GetProperty(nameof(JuiceTelemetryEnabled));

				case 3999842340:
					return typeof(ServerMetricsSettings).GetProperty(nameof(PerformanceProfileStateEnabled));

				case 2302981003:
					return typeof(ServerMetricsSettings).GetProperty(nameof(TransactionTelemetryEnabled));

				case 1385035316:
					return typeof(ServerMetricsSettings).GetProperty(nameof(CompressTransactions));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
