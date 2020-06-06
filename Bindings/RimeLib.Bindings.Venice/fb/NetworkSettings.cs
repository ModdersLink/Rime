///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class NetworkSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint ProtocolVersion { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string TitleId { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint ClientPort { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint ServerPort { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxGhostCount { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint MaxClientCount { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint MaxClientFrameSize { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint MaxServerFrameSize { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable]
		public string XlspAddress { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable]
		public string ServerAddress { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable]
		public string ClientConnectionDebugFilePrefix { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable]
		public string ServerConnectionDebugFilePrefix { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float TimeNudgeGhostFrequencyFactor { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float TimeNudgeBias { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float ConnectTimeout { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool UseFrameManager { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool TimeSyncEnabled { get; set; } // 0x45 (69)
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool IncrementServerPortOnFail { get; set; } // 0x46 (70)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3170322697:
					ProtocolVersion = (uint) p_Value;
					break;

				case 3335995016:
					TitleId = (string) p_Value;
					break;

				case 891909509:
					ClientPort = (uint) p_Value;
					break;

				case 1802195673:
					ServerPort = (uint) p_Value;
					break;

				case 2256733237:
					MaxGhostCount = (uint) p_Value;
					break;

				case 59362443:
					MaxClientCount = (uint) p_Value;
					break;

				case 1801242448:
					MaxClientFrameSize = (uint) p_Value;
					break;

				case 3192625292:
					MaxServerFrameSize = (uint) p_Value;
					break;

				case 536568484:
					XlspAddress = (string) p_Value;
					break;

				case 2537212758:
					ServerAddress = (string) p_Value;
					break;

				case 46256173:
					ClientConnectionDebugFilePrefix = (string) p_Value;
					break;

				case 1658812785:
					ServerConnectionDebugFilePrefix = (string) p_Value;
					break;

				case 3739247939:
					TimeNudgeGhostFrequencyFactor = (float) p_Value;
					break;

				case 1899495764:
					TimeNudgeBias = (float) p_Value;
					break;

				case 1924381792:
					ConnectTimeout = (float) p_Value;
					break;

				case 1232877352:
					UseFrameManager = (bool) p_Value;
					break;

				case 1025585810:
					TimeSyncEnabled = (bool) p_Value;
					break;

				case 1185335067:
					IncrementServerPortOnFail = (bool) p_Value;
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
				case 3170322697:
					return ProtocolVersion;

				case 3335995016:
					return TitleId;

				case 891909509:
					return ClientPort;

				case 1802195673:
					return ServerPort;

				case 2256733237:
					return MaxGhostCount;

				case 59362443:
					return MaxClientCount;

				case 1801242448:
					return MaxClientFrameSize;

				case 3192625292:
					return MaxServerFrameSize;

				case 536568484:
					return XlspAddress;

				case 2537212758:
					return ServerAddress;

				case 46256173:
					return ClientConnectionDebugFilePrefix;

				case 1658812785:
					return ServerConnectionDebugFilePrefix;

				case 3739247939:
					return TimeNudgeGhostFrequencyFactor;

				case 1899495764:
					return TimeNudgeBias;

				case 1924381792:
					return ConnectTimeout;

				case 1232877352:
					return UseFrameManager;

				case 1025585810:
					return TimeSyncEnabled;

				case 1185335067:
					return IncrementServerPortOnFail;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3170322697:
					return typeof(NetworkSettings).GetProperty(nameof(ProtocolVersion));

				case 3335995016:
					return typeof(NetworkSettings).GetProperty(nameof(TitleId));

				case 891909509:
					return typeof(NetworkSettings).GetProperty(nameof(ClientPort));

				case 1802195673:
					return typeof(NetworkSettings).GetProperty(nameof(ServerPort));

				case 2256733237:
					return typeof(NetworkSettings).GetProperty(nameof(MaxGhostCount));

				case 59362443:
					return typeof(NetworkSettings).GetProperty(nameof(MaxClientCount));

				case 1801242448:
					return typeof(NetworkSettings).GetProperty(nameof(MaxClientFrameSize));

				case 3192625292:
					return typeof(NetworkSettings).GetProperty(nameof(MaxServerFrameSize));

				case 536568484:
					return typeof(NetworkSettings).GetProperty(nameof(XlspAddress));

				case 2537212758:
					return typeof(NetworkSettings).GetProperty(nameof(ServerAddress));

				case 46256173:
					return typeof(NetworkSettings).GetProperty(nameof(ClientConnectionDebugFilePrefix));

				case 1658812785:
					return typeof(NetworkSettings).GetProperty(nameof(ServerConnectionDebugFilePrefix));

				case 3739247939:
					return typeof(NetworkSettings).GetProperty(nameof(TimeNudgeGhostFrequencyFactor));

				case 1899495764:
					return typeof(NetworkSettings).GetProperty(nameof(TimeNudgeBias));

				case 1924381792:
					return typeof(NetworkSettings).GetProperty(nameof(ConnectTimeout));

				case 1232877352:
					return typeof(NetworkSettings).GetProperty(nameof(UseFrameManager));

				case 1025585810:
					return typeof(NetworkSettings).GetProperty(nameof(TimeSyncEnabled));

				case 1185335067:
					return typeof(NetworkSettings).GetProperty(nameof(IncrementServerPortOnFail));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
