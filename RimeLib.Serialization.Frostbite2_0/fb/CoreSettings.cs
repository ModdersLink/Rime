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
	public class CoreSettings
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public int RandomTickSeed { get; set; }
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string AvailableLanguages { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public int RandomSessionId { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public int RandomTimeSeed { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float HardwareGpuBias { get; set; }
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public HardwareProfile HardwareProfile { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int JobProcessorCount { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int MaxJobThreadCount { get; set; }
		
		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string Host { get; set; } = string.Empty;
		
		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string HostUser { get; set; } = string.Empty;
		
		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string HostUserDomain { get; set; } = string.Empty;
		
		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string InitSeed { get; set; } = string.Empty;
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public CoreLogLevel LogLevel { get; set; } = new();
		
		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float HardwareCpuBias { get; set; }
		
		[ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		public string GameConfigurationName { get; set; } = string.Empty;
		
		[ContainerField(60), LayoutImmutable, JsonProperty(Order = 60)]
		public string ProfileDirectoryName { get; set; } = string.Empty;
		
		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public bool DisplayAsserts { get; set; }
		
		[ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		public bool LiveEditingEnable { get; set; }
		
		[ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		public bool UseStorageServer { get; set; }
		
		[ContainerField(67), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
		public bool UseDiskCaching { get; set; }
		
		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool CrashOnFatalErrors { get; set; }
		
	}
}
