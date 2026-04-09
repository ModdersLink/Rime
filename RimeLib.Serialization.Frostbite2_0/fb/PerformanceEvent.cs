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
	[ContainerType(16, 96)]
	public partial class PerformanceEvent :
		MetricEvent
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _Position = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _FreeCPUMemory;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _CPUAverage;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _AllocCPUMemory;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _FreeGPUMemory;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _GPUAverage;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private int _DrawCallCount;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private int _PrimitiveCount;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _AllocGPUMemory;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, JsonProperty(Order = 64)]
		private string _PerformanceLocation = string.Empty;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private GUID _PerformanceLink = GUID.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Position.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FreeCPUMemory);
			p_Writer.Write(CPUAverage);
			p_Writer.Write(AllocCPUMemory);
			p_Writer.Write(FreeGPUMemory);
			p_Writer.Write(GPUAverage);
			p_Writer.Write(DrawCallCount);
			p_Writer.Write(PrimitiveCount);
			p_Writer.Write(AllocGPUMemory);
			p_Writer.Write(p_EbxWriter.WriteString(PerformanceLocation));
			PerformanceLink.Serialize(p_Writer);
			p_Writer.WriteNullBytes(12);
		}
	}
}
