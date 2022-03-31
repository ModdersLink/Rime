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
	[ContainerType(8, 56)]
	public class PerformanceProfileState :
		MetricState
	{
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint ProcessorCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint ProcessorCoreCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint ProcessorClock { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint TotalMemMB { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint GpuMemMB { get; set; }

		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string GraphicAdapterName { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string Platform { get; set; } = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ProcessorCount);
			p_Writer.Write(ProcessorCoreCount);
			p_Writer.Write(ProcessorClock);
			p_Writer.Write(TotalMemMB);
			p_Writer.Write(GpuMemMB);
			p_Writer.Write(p_EbxWriter.WriteString(GraphicAdapterName));
			p_Writer.Write(p_EbxWriter.WriteString(Platform));
			p_Writer.WriteNullBytes(4);
		}
	}
}
