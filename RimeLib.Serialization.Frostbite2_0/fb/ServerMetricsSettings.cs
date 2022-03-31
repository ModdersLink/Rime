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
	[ContainerType(4, 24)]
	public class ServerMetricsSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string ReportName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public bool Enabled { get; set; }

		[ContainerField(13), LayoutImmutable, Blittable, JsonProperty(Order = 13)]
		public bool DbxReportEnabled { get; set; }

		[ContainerField(14), LayoutImmutable, Blittable, JsonProperty(Order = 14)]
		public bool TickTelemetryEnabled { get; set; }

		[ContainerField(15), LayoutImmutable, Blittable, JsonProperty(Order = 15)]
		public bool DevelopmentTelemetryEnabled { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool PerformanceTelemetryEnabled { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool JuiceTelemetryEnabled { get; set; }

		[ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		public bool PerformanceProfileStateEnabled { get; set; }

		[ContainerField(19), LayoutImmutable, Blittable, JsonProperty(Order = 19)]
		public bool TransactionTelemetryEnabled { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool CompressTransactions { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(ReportName));
			p_Writer.Write(Enabled);
			p_Writer.Write(DbxReportEnabled);
			p_Writer.Write(TickTelemetryEnabled);
			p_Writer.Write(DevelopmentTelemetryEnabled);
			p_Writer.Write(PerformanceTelemetryEnabled);
			p_Writer.Write(JuiceTelemetryEnabled);
			p_Writer.Write(PerformanceProfileStateEnabled);
			p_Writer.Write(TransactionTelemetryEnabled);
			p_Writer.Write(CompressTransactions);
			p_Writer.WriteNullBytes(3);
		}
	}
}
