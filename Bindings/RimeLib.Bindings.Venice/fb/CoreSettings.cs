///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
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
		[ContainerField(0), LayoutImmutable, Blittable]
		public int RandomTickSeed { get; set; }
		
		[ContainerField(4), LayoutImmutable]
		public string AvailableLanguages { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int RandomSessionId { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int RandomTimeSeed { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float HardwareGpuBias { get; set; }
		
		[ContainerField(20)]
		public HardwareProfile HardwareProfile { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int JobProcessorCount { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int MaxJobThreadCount { get; set; }
		
		[ContainerField(32), LayoutImmutable]
		public string Host { get; set; } = string.Empty;
		
		[ContainerField(36), LayoutImmutable]
		public string HostUser { get; set; } = string.Empty;
		
		[ContainerField(40), LayoutImmutable]
		public string HostUserDomain { get; set; } = string.Empty;
		
		[ContainerField(44), LayoutImmutable]
		public string InitSeed { get; set; } = string.Empty;
		
		[ContainerField(48)]
		public CoreLogLevel LogLevel { get; set; } = new();
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float HardwareCpuBias { get; set; }
		
		[ContainerField(56), LayoutImmutable]
		public string GameConfigurationName { get; set; } = string.Empty;
		
		[ContainerField(60), LayoutImmutable]
		public string ProfileDirectoryName { get; set; } = string.Empty;
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public bool DisplayAsserts { get; set; }
		
		[ContainerField(65), LayoutImmutable, Blittable]
		public bool LiveEditingEnable { get; set; }
		
		[ContainerField(66), LayoutImmutable, Blittable]
		public bool UseStorageServer { get; set; }
		
		[ContainerField(67), LayoutImmutable, Blittable]
		public bool UseDiskCaching { get; set; }
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool CrashOnFatalErrors { get; set; }
		
		public static void Deserialize(CoreSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RandomTickSeed = p_Reader.ReadInt32();
			p_Instance.AvailableLanguages = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.RandomSessionId = p_Reader.ReadInt32();
			p_Instance.RandomTimeSeed = p_Reader.ReadInt32();
			p_Instance.HardwareGpuBias = p_Reader.ReadSingle();
			p_Instance.HardwareProfile = (HardwareProfile) p_Reader.ReadInt32();
			p_Instance.JobProcessorCount = p_Reader.ReadInt32();
			p_Instance.MaxJobThreadCount = p_Reader.ReadInt32();
			p_Instance.Host = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.HostUser = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.HostUserDomain = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.InitSeed = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.LogLevel = (CoreLogLevel) p_Reader.ReadInt32();
			p_Instance.HardwareCpuBias = p_Reader.ReadSingle();
			p_Instance.GameConfigurationName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ProfileDirectoryName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DisplayAsserts = p_Reader.ReadBool();
			p_Instance.LiveEditingEnable = p_Reader.ReadBool();
			p_Instance.UseStorageServer = p_Reader.ReadBool();
			p_Instance.UseDiskCaching = p_Reader.ReadBool();
			p_Instance.CrashOnFatalErrors = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
