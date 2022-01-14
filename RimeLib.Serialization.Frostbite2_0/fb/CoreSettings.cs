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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 72)]
	public class CoreSettings :
		EbxSerializable
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
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(RandomTickSeed);
			p_Writer.Write(p_EbxWriter.WriteString(AvailableLanguages));
			p_Writer.Write(RandomSessionId);
			p_Writer.Write(RandomTimeSeed);
			p_Writer.Write(HardwareGpuBias);
			p_Writer.Write((int) HardwareProfile);
			p_Writer.Write(JobProcessorCount);
			p_Writer.Write(MaxJobThreadCount);
			p_Writer.Write(p_EbxWriter.WriteString(Host));
			p_Writer.Write(p_EbxWriter.WriteString(HostUser));
			p_Writer.Write(p_EbxWriter.WriteString(HostUserDomain));
			p_Writer.Write(p_EbxWriter.WriteString(InitSeed));
			p_Writer.Write((int) LogLevel);
			p_Writer.Write(HardwareCpuBias);
			p_Writer.Write(p_EbxWriter.WriteString(GameConfigurationName));
			p_Writer.Write(p_EbxWriter.WriteString(ProfileDirectoryName));
			p_Writer.Write(DisplayAsserts);
			p_Writer.Write(LiveEditingEnable);
			p_Writer.Write(UseStorageServer);
			p_Writer.Write(UseDiskCaching);
			p_Writer.Write(CrashOnFatalErrors);
			p_Writer.WriteNullBytes(3);
		}
	}
}
