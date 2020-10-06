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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(72), ContainerStruct]
	public class CoreSettings : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int RandomTickSeed { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string AvailableLanguages { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int RandomSessionId { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int RandomTimeSeed { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float HardwareGpuBias { get; set; } // 0x10 (16)
		
		[ContainerField(20), MemberInfoFlag(137)]
		public HardwareProfile HardwareProfile { get; set; } = new HardwareProfile(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int JobProcessorCount { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int MaxJobThreadCount { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, MemberInfoFlag(16509)]
		public string Host { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, MemberInfoFlag(16509)]
		public string HostUser { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, MemberInfoFlag(16509)]
		public string HostUserDomain { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, MemberInfoFlag(16509)]
		public string InitSeed { get; set; } // 0x2C (44)
		
		[ContainerField(48), MemberInfoFlag(137)]
		public CoreLogLevel LogLevel { get; set; } = new CoreLogLevel(); // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float HardwareCpuBias { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, MemberInfoFlag(16509)]
		public string GameConfigurationName { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, MemberInfoFlag(16509)]
		public string ProfileDirectoryName { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool DisplayAsserts { get; set; } // 0x40 (64)
		
		[ContainerField(65), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool LiveEditingEnable { get; set; } // 0x41 (65)
		
		[ContainerField(66), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool UseStorageServer { get; set; } // 0x42 (66)
		
		[ContainerField(67), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool UseDiskCaching { get; set; } // 0x43 (67)
		
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
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
