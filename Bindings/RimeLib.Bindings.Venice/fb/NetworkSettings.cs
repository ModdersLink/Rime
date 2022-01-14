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
	[ContainerType(4, 72)]
	public class NetworkSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint ProtocolVersion { get; set; }

		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string TitleId { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint ClientPort { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint ServerPort { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint MaxGhostCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint MaxClientCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint MaxClientFrameSize { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint MaxServerFrameSize { get; set; }

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string XlspAddress { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string ServerAddress { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string ClientConnectionDebugFilePrefix { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		public string ServerConnectionDebugFilePrefix { get; set; } = string.Empty;

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float TimeNudgeGhostFrequencyFactor { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float TimeNudgeBias { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float ConnectTimeout { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool UseFrameManager { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool TimeSyncEnabled { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		public bool IncrementServerPortOnFail { get; set; }

	}
}
