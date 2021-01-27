///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 72)]
	public class CoreSettings : FrostbiteContainer
	{
		[ContainerField(Name: "RandomTickSeed", Offset: 0, NameHash: 671402876, Flags: 49405), LayoutImmutable, Blittable]
		public int RandomTickSeed { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "AvailableLanguages", Offset: 4, NameHash: 788680445, Flags: 16509), LayoutImmutable]
		public string AvailableLanguages { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "RandomSessionId", Offset: 8, NameHash: 95247661, Flags: 49405), LayoutImmutable, Blittable]
		public int RandomSessionId { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "RandomTimeSeed", Offset: 12, NameHash: 1358958012, Flags: 49405), LayoutImmutable, Blittable]
		public int RandomTimeSeed { get; set; } // 0xC (12)
		
		[ContainerField(Name: "HardwareGpuBias", Offset: 16, NameHash: 2612024544, Flags: 49469), LayoutImmutable, Blittable]
		public float HardwareGpuBias { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "HardwareProfile", Offset: 20, NameHash: 1651739824, Flags: 137)]
		public HardwareProfile HardwareProfile { get; set; } = new HardwareProfile(); // 0x14 (20)
		
		[ContainerField(Name: "JobProcessorCount", Offset: 24, NameHash: 3483829783, Flags: 49405), LayoutImmutable, Blittable]
		public int JobProcessorCount { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "MaxJobThreadCount", Offset: 28, NameHash: 1877549307, Flags: 49405), LayoutImmutable, Blittable]
		public int MaxJobThreadCount { get; set; } // 0x1C (28)
		
		[ContainerField(Name: "Host", Offset: 32, NameHash: 2089155077, Flags: 16509), LayoutImmutable]
		public string Host { get; set; } // 0x20 (32)
		
		[ContainerField(Name: "HostUser", Offset: 36, NameHash: 3816077620, Flags: 16509), LayoutImmutable]
		public string HostUser { get; set; } // 0x24 (36)
		
		[ContainerField(Name: "HostUserDomain", Offset: 40, NameHash: 2838452564, Flags: 16509), LayoutImmutable]
		public string HostUserDomain { get; set; } // 0x28 (40)
		
		[ContainerField(Name: "InitSeed", Offset: 44, NameHash: 4105745672, Flags: 16509), LayoutImmutable]
		public string InitSeed { get; set; } // 0x2C (44)
		
		[ContainerField(Name: "LogLevel", Offset: 48, NameHash: 1867701815, Flags: 137)]
		public CoreLogLevel LogLevel { get; set; } = new CoreLogLevel(); // 0x30 (48)
		
		[ContainerField(Name: "HardwareCpuBias", Offset: 52, NameHash: 1750607332, Flags: 49469), LayoutImmutable, Blittable]
		public float HardwareCpuBias { get; set; } // 0x34 (52)
		
		[ContainerField(Name: "GameConfigurationName", Offset: 56, NameHash: 2876236092, Flags: 16509), LayoutImmutable]
		public string GameConfigurationName { get; set; } // 0x38 (56)
		
		[ContainerField(Name: "ProfileDirectoryName", Offset: 60, NameHash: 615982176, Flags: 16509), LayoutImmutable]
		public string ProfileDirectoryName { get; set; } // 0x3C (60)
		
		[ContainerField(Name: "DisplayAsserts", Offset: 64, NameHash: 1371733582, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisplayAsserts { get; set; } // 0x40 (64)
		
		[ContainerField(Name: "LiveEditingEnable", Offset: 65, NameHash: 3660493806, Flags: 49325), LayoutImmutable, Blittable]
		public bool LiveEditingEnable { get; set; } // 0x41 (65)
		
		[ContainerField(Name: "UseStorageServer", Offset: 66, NameHash: 3367165722, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseStorageServer { get; set; } // 0x42 (66)
		
		[ContainerField(Name: "UseDiskCaching", Offset: 67, NameHash: 2390567258, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseDiskCaching { get; set; } // 0x43 (67)
		
		[ContainerField(Name: "CrashOnFatalErrors", Offset: 68, NameHash: 3503810106, Flags: 49325), LayoutImmutable, Blittable]
		public bool CrashOnFatalErrors { get; set; } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 671402876:
					RandomTickSeed = (int) p_Value;
					break;

				case 788680445:
					AvailableLanguages = (string) p_Value;
					break;

				case 95247661:
					RandomSessionId = (int) p_Value;
					break;

				case 1358958012:
					RandomTimeSeed = (int) p_Value;
					break;

				case 2612024544:
					HardwareGpuBias = (float) p_Value;
					break;

				case 1651739824:
						HardwareProfile = (HardwareProfile) Enum.ToObject(typeof(HardwareProfile), p_Value);
					break;

				case 3483829783:
					JobProcessorCount = (int) p_Value;
					break;

				case 1877549307:
					MaxJobThreadCount = (int) p_Value;
					break;

				case 2089155077:
					Host = (string) p_Value;
					break;

				case 3816077620:
					HostUser = (string) p_Value;
					break;

				case 2838452564:
					HostUserDomain = (string) p_Value;
					break;

				case 4105745672:
					InitSeed = (string) p_Value;
					break;

				case 1867701815:
						LogLevel = (CoreLogLevel) Enum.ToObject(typeof(CoreLogLevel), p_Value);
					break;

				case 1750607332:
					HardwareCpuBias = (float) p_Value;
					break;

				case 2876236092:
					GameConfigurationName = (string) p_Value;
					break;

				case 615982176:
					ProfileDirectoryName = (string) p_Value;
					break;

				case 1371733582:
					DisplayAsserts = (bool) p_Value;
					break;

				case 3660493806:
					LiveEditingEnable = (bool) p_Value;
					break;

				case 3367165722:
					UseStorageServer = (bool) p_Value;
					break;

				case 2390567258:
					UseDiskCaching = (bool) p_Value;
					break;

				case 3503810106:
					CrashOnFatalErrors = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 671402876:
					return RandomTickSeed;

				case 788680445:
					return AvailableLanguages;

				case 95247661:
					return RandomSessionId;

				case 1358958012:
					return RandomTimeSeed;

				case 2612024544:
					return HardwareGpuBias;

				case 1651739824:
					return HardwareProfile;

				case 3483829783:
					return JobProcessorCount;

				case 1877549307:
					return MaxJobThreadCount;

				case 2089155077:
					return Host;

				case 3816077620:
					return HostUser;

				case 2838452564:
					return HostUserDomain;

				case 4105745672:
					return InitSeed;

				case 1867701815:
					return LogLevel;

				case 1750607332:
					return HardwareCpuBias;

				case 2876236092:
					return GameConfigurationName;

				case 615982176:
					return ProfileDirectoryName;

				case 1371733582:
					return DisplayAsserts;

				case 3660493806:
					return LiveEditingEnable;

				case 3367165722:
					return UseStorageServer;

				case 2390567258:
					return UseDiskCaching;

				case 3503810106:
					return CrashOnFatalErrors;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 671402876:
					return typeof(CoreSettings).GetProperty(nameof(RandomTickSeed));

				case 788680445:
					return typeof(CoreSettings).GetProperty(nameof(AvailableLanguages));

				case 95247661:
					return typeof(CoreSettings).GetProperty(nameof(RandomSessionId));

				case 1358958012:
					return typeof(CoreSettings).GetProperty(nameof(RandomTimeSeed));

				case 2612024544:
					return typeof(CoreSettings).GetProperty(nameof(HardwareGpuBias));

				case 1651739824:
					return typeof(CoreSettings).GetProperty(nameof(HardwareProfile));

				case 3483829783:
					return typeof(CoreSettings).GetProperty(nameof(JobProcessorCount));

				case 1877549307:
					return typeof(CoreSettings).GetProperty(nameof(MaxJobThreadCount));

				case 2089155077:
					return typeof(CoreSettings).GetProperty(nameof(Host));

				case 3816077620:
					return typeof(CoreSettings).GetProperty(nameof(HostUser));

				case 2838452564:
					return typeof(CoreSettings).GetProperty(nameof(HostUserDomain));

				case 4105745672:
					return typeof(CoreSettings).GetProperty(nameof(InitSeed));

				case 1867701815:
					return typeof(CoreSettings).GetProperty(nameof(LogLevel));

				case 1750607332:
					return typeof(CoreSettings).GetProperty(nameof(HardwareCpuBias));

				case 2876236092:
					return typeof(CoreSettings).GetProperty(nameof(GameConfigurationName));

				case 615982176:
					return typeof(CoreSettings).GetProperty(nameof(ProfileDirectoryName));

				case 1371733582:
					return typeof(CoreSettings).GetProperty(nameof(DisplayAsserts));

				case 3660493806:
					return typeof(CoreSettings).GetProperty(nameof(LiveEditingEnable));

				case 3367165722:
					return typeof(CoreSettings).GetProperty(nameof(UseStorageServer));

				case 2390567258:
					return typeof(CoreSettings).GetProperty(nameof(UseDiskCaching));

				case 3503810106:
					return typeof(CoreSettings).GetProperty(nameof(CrashOnFatalErrors));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
