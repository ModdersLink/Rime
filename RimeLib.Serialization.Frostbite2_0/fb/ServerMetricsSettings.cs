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
	[ContainerType(4, 24)]
	public partial class ServerMetricsSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _ReportName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private bool _Enabled;

		[ObservableProperty]
		[property: ContainerField(13), LayoutImmutable, Blittable, JsonProperty(Order = 13)]
		private bool _DbxReportEnabled;

		[ObservableProperty]
		[property: ContainerField(14), LayoutImmutable, Blittable, JsonProperty(Order = 14)]
		private bool _TickTelemetryEnabled;

		[ObservableProperty]
		[property: ContainerField(15), LayoutImmutable, Blittable, JsonProperty(Order = 15)]
		private bool _DevelopmentTelemetryEnabled;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private bool _PerformanceTelemetryEnabled;

		[ObservableProperty]
		[property: ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		private bool _JuiceTelemetryEnabled;

		[ObservableProperty]
		[property: ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		private bool _PerformanceProfileStateEnabled;

		[ObservableProperty]
		[property: ContainerField(19), LayoutImmutable, Blittable, JsonProperty(Order = 19)]
		private bool _TransactionTelemetryEnabled;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private bool _CompressTransactions;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
