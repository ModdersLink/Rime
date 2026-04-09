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
	[ContainerType(8, 56)]
	public partial class PerformanceProfileState :
		MetricState
	{
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _ProcessorCount;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _ProcessorCoreCount;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _ProcessorClock;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _TotalMemMB;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _GpuMemMB;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		private string _GraphicAdapterName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		private string _Platform = string.Empty;

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
