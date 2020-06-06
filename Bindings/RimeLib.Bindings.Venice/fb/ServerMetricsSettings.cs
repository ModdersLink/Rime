///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ServerMetricsSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string ReportName { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0xC (12)
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public bool DbxReportEnabled { get; set; } // 0xD (13)
		
		[ContainerField(14), LayoutImmutable, Blittable]
		public bool TickTelemetryEnabled { get; set; } // 0xE (14)
		
		[ContainerField(15), LayoutImmutable, Blittable]
		public bool DevelopmentTelemetryEnabled { get; set; } // 0xF (15)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool PerformanceTelemetryEnabled { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool JuiceTelemetryEnabled { get; set; } // 0x11 (17)
		
		[ContainerField(18), LayoutImmutable, Blittable]
		public bool PerformanceProfileStateEnabled { get; set; } // 0x12 (18)
		
		[ContainerField(19), LayoutImmutable, Blittable]
		public bool TransactionTelemetryEnabled { get; set; } // 0x13 (19)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool CompressTransactions { get; set; } // 0x14 (20)
		
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
