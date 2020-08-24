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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class NetworkSettings : 
		DataContainer
	{
		protected uint m_ProtocolVersion = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3170322697)]
		public uint ProtocolVersion { get { return m_ProtocolVersion; } set { if (OnPropertyChanging("NetworkSettings." + nameof(ProtocolVersion), this, m_ProtocolVersion, value)) m_ProtocolVersion = value; } } // 0x8 (8)
		
		protected string m_TitleId = string.Empty;
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3335995016)]
		public string TitleId { get { return m_TitleId; } set { if (OnPropertyChanging("NetworkSettings." + nameof(TitleId), this, m_TitleId, value)) m_TitleId = value; } } // 0xC (12)
		
		protected uint m_ClientPort = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(891909509)]
		public uint ClientPort { get { return m_ClientPort; } set { if (OnPropertyChanging("NetworkSettings." + nameof(ClientPort), this, m_ClientPort, value)) m_ClientPort = value; } } // 0x10 (16)
		
		protected uint m_ServerPort = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1802195673)]
		public uint ServerPort { get { return m_ServerPort; } set { if (OnPropertyChanging("NetworkSettings." + nameof(ServerPort), this, m_ServerPort, value)) m_ServerPort = value; } } // 0x14 (20)
		
		protected uint m_MaxGhostCount = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2256733237)]
		public uint MaxGhostCount { get { return m_MaxGhostCount; } set { if (OnPropertyChanging("NetworkSettings." + nameof(MaxGhostCount), this, m_MaxGhostCount, value)) m_MaxGhostCount = value; } } // 0x18 (24)
		
		protected uint m_MaxClientCount = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(59362443)]
		public uint MaxClientCount { get { return m_MaxClientCount; } set { if (OnPropertyChanging("NetworkSettings." + nameof(MaxClientCount), this, m_MaxClientCount, value)) m_MaxClientCount = value; } } // 0x1C (28)
		
		protected uint m_MaxClientFrameSize = new uint();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1801242448)]
		public uint MaxClientFrameSize { get { return m_MaxClientFrameSize; } set { if (OnPropertyChanging("NetworkSettings." + nameof(MaxClientFrameSize), this, m_MaxClientFrameSize, value)) m_MaxClientFrameSize = value; } } // 0x20 (32)
		
		protected uint m_MaxServerFrameSize = new uint();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3192625292)]
		public uint MaxServerFrameSize { get { return m_MaxServerFrameSize; } set { if (OnPropertyChanging("NetworkSettings." + nameof(MaxServerFrameSize), this, m_MaxServerFrameSize, value)) m_MaxServerFrameSize = value; } } // 0x24 (36)
		
		protected string m_XlspAddress = string.Empty;
		[ContainerField(40), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(536568484)]
		public string XlspAddress { get { return m_XlspAddress; } set { if (OnPropertyChanging("NetworkSettings." + nameof(XlspAddress), this, m_XlspAddress, value)) m_XlspAddress = value; } } // 0x28 (40)
		
		protected string m_ServerAddress = string.Empty;
		[ContainerField(44), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2537212758)]
		public string ServerAddress { get { return m_ServerAddress; } set { if (OnPropertyChanging("NetworkSettings." + nameof(ServerAddress), this, m_ServerAddress, value)) m_ServerAddress = value; } } // 0x2C (44)
		
		protected string m_ClientConnectionDebugFilePrefix = string.Empty;
		[ContainerField(48), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(46256173)]
		public string ClientConnectionDebugFilePrefix { get { return m_ClientConnectionDebugFilePrefix; } set { if (OnPropertyChanging("NetworkSettings." + nameof(ClientConnectionDebugFilePrefix), this, m_ClientConnectionDebugFilePrefix, value)) m_ClientConnectionDebugFilePrefix = value; } } // 0x30 (48)
		
		protected string m_ServerConnectionDebugFilePrefix = string.Empty;
		[ContainerField(52), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1658812785)]
		public string ServerConnectionDebugFilePrefix { get { return m_ServerConnectionDebugFilePrefix; } set { if (OnPropertyChanging("NetworkSettings." + nameof(ServerConnectionDebugFilePrefix), this, m_ServerConnectionDebugFilePrefix, value)) m_ServerConnectionDebugFilePrefix = value; } } // 0x34 (52)
		
		protected float m_TimeNudgeGhostFrequencyFactor = new float();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3739247939)]
		public float TimeNudgeGhostFrequencyFactor { get { return m_TimeNudgeGhostFrequencyFactor; } set { if (OnPropertyChanging("NetworkSettings." + nameof(TimeNudgeGhostFrequencyFactor), this, m_TimeNudgeGhostFrequencyFactor, value)) m_TimeNudgeGhostFrequencyFactor = value; } } // 0x38 (56)
		
		protected float m_TimeNudgeBias = new float();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1899495764)]
		public float TimeNudgeBias { get { return m_TimeNudgeBias; } set { if (OnPropertyChanging("NetworkSettings." + nameof(TimeNudgeBias), this, m_TimeNudgeBias, value)) m_TimeNudgeBias = value; } } // 0x3C (60)
		
		protected float m_ConnectTimeout = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1924381792)]
		public float ConnectTimeout { get { return m_ConnectTimeout; } set { if (OnPropertyChanging("NetworkSettings." + nameof(ConnectTimeout), this, m_ConnectTimeout, value)) m_ConnectTimeout = value; } } // 0x40 (64)
		
		protected bool m_UseFrameManager = new bool();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1232877352)]
		public bool UseFrameManager { get { return m_UseFrameManager; } set { if (OnPropertyChanging("NetworkSettings." + nameof(UseFrameManager), this, m_UseFrameManager, value)) m_UseFrameManager = value; } } // 0x44 (68)
		
		protected bool m_TimeSyncEnabled = new bool();
		[ContainerField(69), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1025585810)]
		public bool TimeSyncEnabled { get { return m_TimeSyncEnabled; } set { if (OnPropertyChanging("NetworkSettings." + nameof(TimeSyncEnabled), this, m_TimeSyncEnabled, value)) m_TimeSyncEnabled = value; } } // 0x45 (69)
		
		protected bool m_IncrementServerPortOnFail = new bool();
		[ContainerField(70), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1185335067)]
		public bool IncrementServerPortOnFail { get { return m_IncrementServerPortOnFail; } set { if (OnPropertyChanging("NetworkSettings." + nameof(IncrementServerPortOnFail), this, m_IncrementServerPortOnFail, value)) m_IncrementServerPortOnFail = value; } } // 0x46 (70)
		
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
