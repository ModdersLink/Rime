///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class ServerMetricsSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string ReportName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		[ContainerField(13), LayoutImmutable, Blittable]
		public bool DbxReportEnabled { get; set; }

		[ContainerField(14), LayoutImmutable, Blittable]
		public bool TickTelemetryEnabled { get; set; }

		[ContainerField(15), LayoutImmutable, Blittable]
		public bool DevelopmentTelemetryEnabled { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool PerformanceTelemetryEnabled { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable]
		public bool JuiceTelemetryEnabled { get; set; }

		[ContainerField(18), LayoutImmutable, Blittable]
		public bool PerformanceProfileStateEnabled { get; set; }

		[ContainerField(19), LayoutImmutable, Blittable]
		public bool TransactionTelemetryEnabled { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool CompressTransactions { get; set; }

	}
}
