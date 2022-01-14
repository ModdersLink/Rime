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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 80)]
	public class OutputNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort BypassHeadroom { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float MinDistance { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public AudioCurve AttenuationCurve { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float Gain { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float HFDampingDistance { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float HFDampingObstruction { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float HFDampingOcclusion { get; set; }

		[ContainerField(52), JsonProperty(Order = 52)]
		public SoundGraphPluginRef MainSendPlugin { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public CtrRef<SoundBusData> MainSend { get; set; } = new();

		[ContainerField(60), LayoutImmutable, JsonProperty(Order = 60)]
		public string OutputName { get; set; } = string.Empty;

		[ContainerField(64), JsonProperty(Order = 64)]
		public OutputTransformSource TransformSource { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public uint OutputNameHash { get; set; }

		[ContainerField(72), JsonProperty(Order = 72)]
		public SoundGraphPluginRef LowPassPlugin { get; set; } = new();

		[ContainerField(75), JsonProperty(Order = 75)]
		public SoundGraphPluginRef VuPlugin { get; set; } = new();

		[ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		public bool Solo { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		public bool EnableHdr { get; set; }

	}
}
