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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 64)]
	public class OnlineSettings : 
		SystemSettings
	{
		protected BackendType m_Backend = new BackendType();
		[ContainerField(Name: "Backend", Offset: 12, NameHash: 2290467745, Flags: 137)]
		public BackendType Backend { get { return m_Backend; } set { if (OnPropertyChanging("OnlineSettings." + nameof(Backend), this, m_Backend, value)) m_Backend = value; } } // 0xC (12)
		
		protected BackendType m_PeerBackend = new BackendType();
		[ContainerField(Name: "PeerBackend", Offset: 16, NameHash: 3086640163, Flags: 137)]
		public BackendType PeerBackend { get { return m_PeerBackend; } set { if (OnPropertyChanging("OnlineSettings." + nameof(PeerBackend), this, m_PeerBackend, value)) m_PeerBackend = value; } } // 0x10 (16)
		
		protected OnlineEnvironment m_Environment = new OnlineEnvironment();
		[ContainerField(Name: "Environment", Offset: 20, NameHash: 2480382480, Flags: 137)]
		public OnlineEnvironment Environment { get { return m_Environment; } set { if (OnPropertyChanging("OnlineSettings." + nameof(Environment), this, m_Environment, value)) m_Environment = value; } } // 0x14 (20)
		
		protected string m_MatchmakingToken = string.Empty;
		[ContainerField(Name: "MatchmakingToken", Offset: 24, NameHash: 2041898954, Flags: 16509), LayoutImmutable]
		public string MatchmakingToken { get { return m_MatchmakingToken; } set { if (OnPropertyChanging("OnlineSettings." + nameof(MatchmakingToken), this, m_MatchmakingToken, value)) m_MatchmakingToken = value; } } // 0x18 (24)
		
		protected CtrRef<OnlineProviderAsset> m_Provider = new CtrRef<OnlineProviderAsset>();
		[ContainerField(Name: "Provider", Offset: 28, NameHash: 3021915972, Flags: 53)]
		public CtrRef<OnlineProviderAsset> Provider { get { return m_Provider; } set { if (OnPropertyChanging("OnlineSettings." + nameof(Provider), this, m_Provider, value)) m_Provider = value; } } // 0x1C (28)
		
		protected CtrRef<RichPresenceData> m_RichPresence = new CtrRef<RichPresenceData>();
		[ContainerField(Name: "RichPresence", Offset: 32, NameHash: 789861132, Flags: 53)]
		public CtrRef<RichPresenceData> RichPresence { get { return m_RichPresence; } set { if (OnPropertyChanging("OnlineSettings." + nameof(RichPresence), this, m_RichPresence, value)) m_RichPresence = value; } } // 0x20 (32)
		
		protected CtrRef<ChatSettings> m_ChatSettings = new CtrRef<ChatSettings>();
		[ContainerField(Name: "ChatSettings", Offset: 36, NameHash: 1116129662, Flags: 53)]
		public CtrRef<ChatSettings> ChatSettings { get { return m_ChatSettings; } set { if (OnPropertyChanging("OnlineSettings." + nameof(ChatSettings), this, m_ChatSettings, value)) m_ChatSettings = value; } } // 0x24 (36)
		
		protected string m_MatchmakingOptions = string.Empty;
		[ContainerField(Name: "MatchmakingOptions", Offset: 40, NameHash: 3558992865, Flags: 16509), LayoutImmutable]
		public string MatchmakingOptions { get { return m_MatchmakingOptions; } set { if (OnPropertyChanging("OnlineSettings." + nameof(MatchmakingOptions), this, m_MatchmakingOptions, value)) m_MatchmakingOptions = value; } } // 0x28 (40)
		
		protected string m_Region = string.Empty;
		[ContainerField(Name: "Region", Offset: 44, NameHash: 3293978493, Flags: 16509), LayoutImmutable]
		public string Region { get { return m_Region; } set { if (OnPropertyChanging("OnlineSettings." + nameof(Region), this, m_Region, value)) m_Region = value; } } // 0x2C (44)
		
		protected uint m_NegativeUserCacheRefreshPeriod = new uint();
		[ContainerField(Name: "NegativeUserCacheRefreshPeriod", Offset: 48, NameHash: 1822528579, Flags: 49421), LayoutImmutable, Blittable]
		public uint NegativeUserCacheRefreshPeriod { get { return m_NegativeUserCacheRefreshPeriod; } set { if (OnPropertyChanging("OnlineSettings." + nameof(NegativeUserCacheRefreshPeriod), this, m_NegativeUserCacheRefreshPeriod, value)) m_NegativeUserCacheRefreshPeriod = value; } } // 0x30 (48)
		
		protected string m_MatchmakingMode = string.Empty;
		[ContainerField(Name: "MatchmakingMode", Offset: 52, NameHash: 3576825522, Flags: 16509), LayoutImmutable]
		public string MatchmakingMode { get { return m_MatchmakingMode; } set { if (OnPropertyChanging("OnlineSettings." + nameof(MatchmakingMode), this, m_MatchmakingMode, value)) m_MatchmakingMode = value; } } // 0x34 (52)
		
		protected string m_Country = string.Empty;
		[ContainerField(Name: "Country", Offset: 56, NameHash: 3685467405, Flags: 16509), LayoutImmutable]
		public string Country { get { return m_Country; } set { if (OnPropertyChanging("OnlineSettings." + nameof(Country), this, m_Country, value)) m_Country = value; } } // 0x38 (56)
		
		protected bool m_IsSecure = new bool();
		[ContainerField(Name: "IsSecure", Offset: 60, NameHash: 451767400, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsSecure { get { return m_IsSecure; } set { if (OnPropertyChanging("OnlineSettings." + nameof(IsSecure), this, m_IsSecure, value)) m_IsSecure = value; } } // 0x3C (60)
		
		protected bool m_SupportHostMigration = new bool();
		[ContainerField(Name: "SupportHostMigration", Offset: 61, NameHash: 1663175238, Flags: 49325), LayoutImmutable, Blittable]
		public bool SupportHostMigration { get { return m_SupportHostMigration; } set { if (OnPropertyChanging("OnlineSettings." + nameof(SupportHostMigration), this, m_SupportHostMigration, value)) m_SupportHostMigration = value; } } // 0x3D (61)
		
		protected bool m_MatchmakeImmediately = new bool();
		[ContainerField(Name: "MatchmakeImmediately", Offset: 62, NameHash: 4001997328, Flags: 49325), LayoutImmutable, Blittable]
		public bool MatchmakeImmediately { get { return m_MatchmakeImmediately; } set { if (OnPropertyChanging("OnlineSettings." + nameof(MatchmakeImmediately), this, m_MatchmakeImmediately, value)) m_MatchmakeImmediately = value; } } // 0x3E (62)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2290467745:
					Backend = (BackendType) Enum.ToObject(typeof(BackendType), p_Value);
					break;

				case 3086640163:
					PeerBackend = (BackendType) Enum.ToObject(typeof(BackendType), p_Value);
					break;

				case 2480382480:
					Environment = (OnlineEnvironment) Enum.ToObject(typeof(OnlineEnvironment), p_Value);
					break;

				case 2041898954:
					MatchmakingToken = (string) p_Value;
					break;

				case 3021915972:
					Provider = (CtrRef<OnlineProviderAsset>) p_Value;
					break;

				case 789861132:
					RichPresence = (CtrRef<RichPresenceData>) p_Value;
					break;

				case 1116129662:
					ChatSettings = (CtrRef<ChatSettings>) p_Value;
					break;

				case 3558992865:
					MatchmakingOptions = (string) p_Value;
					break;

				case 3293978493:
					Region = (string) p_Value;
					break;

				case 1822528579:
					NegativeUserCacheRefreshPeriod = (uint) p_Value;
					break;

				case 3576825522:
					MatchmakingMode = (string) p_Value;
					break;

				case 3685467405:
					Country = (string) p_Value;
					break;

				case 451767400:
					IsSecure = (bool) p_Value;
					break;

				case 1663175238:
					SupportHostMigration = (bool) p_Value;
					break;

				case 4001997328:
					MatchmakeImmediately = (bool) p_Value;
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
				case 2290467745:
					return Backend;

				case 3086640163:
					return PeerBackend;

				case 2480382480:
					return Environment;

				case 2041898954:
					return MatchmakingToken;

				case 3021915972:
					return Provider;

				case 789861132:
					return RichPresence;

				case 1116129662:
					return ChatSettings;

				case 3558992865:
					return MatchmakingOptions;

				case 3293978493:
					return Region;

				case 1822528579:
					return NegativeUserCacheRefreshPeriod;

				case 3576825522:
					return MatchmakingMode;

				case 3685467405:
					return Country;

				case 451767400:
					return IsSecure;

				case 1663175238:
					return SupportHostMigration;

				case 4001997328:
					return MatchmakeImmediately;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2290467745:
					return typeof(OnlineSettings).GetProperty(nameof(Backend));

				case 3086640163:
					return typeof(OnlineSettings).GetProperty(nameof(PeerBackend));

				case 2480382480:
					return typeof(OnlineSettings).GetProperty(nameof(Environment));

				case 2041898954:
					return typeof(OnlineSettings).GetProperty(nameof(MatchmakingToken));

				case 3021915972:
					return typeof(OnlineSettings).GetProperty(nameof(Provider));

				case 789861132:
					return typeof(OnlineSettings).GetProperty(nameof(RichPresence));

				case 1116129662:
					return typeof(OnlineSettings).GetProperty(nameof(ChatSettings));

				case 3558992865:
					return typeof(OnlineSettings).GetProperty(nameof(MatchmakingOptions));

				case 3293978493:
					return typeof(OnlineSettings).GetProperty(nameof(Region));

				case 1822528579:
					return typeof(OnlineSettings).GetProperty(nameof(NegativeUserCacheRefreshPeriod));

				case 3576825522:
					return typeof(OnlineSettings).GetProperty(nameof(MatchmakingMode));

				case 3685467405:
					return typeof(OnlineSettings).GetProperty(nameof(Country));

				case 451767400:
					return typeof(OnlineSettings).GetProperty(nameof(IsSecure));

				case 1663175238:
					return typeof(OnlineSettings).GetProperty(nameof(SupportHostMigration));

				case 4001997328:
					return typeof(OnlineSettings).GetProperty(nameof(MatchmakeImmediately));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
