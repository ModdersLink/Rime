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

using fb.Core;

namespace fb.Venice;

[ContainerType(8, 48)]
public class ServerMetricsSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string ReportName { get; set; } = @"/temp/ServerMetrics/MetricReport.dbx";
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string LogSettingsPrefix { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool DbxReportEnabled { get; set; } = false;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public bool TickTelemetryEnabled { get; set; } = false;
	
	[ContainerField(0x23), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
	public bool DevelopmentTelemetryEnabled { get; set; } = true;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool PerformanceTelemetryEnabled { get; set; } = false;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool JuiceTelemetryEnabled { get; set; } = false;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool PerformanceProfileStateEnabled { get; set; } = false;
	
	[ContainerField(0x27), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
	public bool TransactionTelemetryEnabled { get; set; } = false;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool CompressTransactions { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ReportName));
		p_Writer.Write(p_EbxWriter.WriteString(LogSettingsPrefix));
		p_Writer.Write(Enabled);
		p_Writer.Write(DbxReportEnabled);
		p_Writer.Write(TickTelemetryEnabled);
		p_Writer.Write(DevelopmentTelemetryEnabled);
		p_Writer.Write(PerformanceTelemetryEnabled);
		p_Writer.Write(JuiceTelemetryEnabled);
		p_Writer.Write(PerformanceProfileStateEnabled);
		p_Writer.Write(TransactionTelemetryEnabled);
		p_Writer.Write(CompressTransactions);
		p_Writer.WriteNullBytes(7);
	}
}

