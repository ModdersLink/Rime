///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class OnlineSettings : 
		SystemSettings
	{
		[ContainerField(12)]
		public BackendType Backend { get; set; } = new BackendType(); // 0xC (12)
		
		[ContainerField(16)]
		public BackendType PeerBackend { get; set; } = new BackendType(); // 0x10 (16)
		
		[ContainerField(20)]
		public OnlineEnvironment Environment { get; set; } = new OnlineEnvironment(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string MatchmakingToken { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<OnlineProviderAsset> Provider { get; set; } = new CtrRef<OnlineProviderAsset>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<RichPresenceData> RichPresence { get; set; } = new CtrRef<RichPresenceData>(); // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<ChatSettings> ChatSettings { get; set; } = new CtrRef<ChatSettings>(); // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable]
		public string MatchmakingOptions { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable]
		public string Region { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint NegativeUserCacheRefreshPeriod { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable]
		public string MatchmakingMode { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable]
		public string Country { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool IsSecure { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool SupportHostMigration { get; set; } // 0x3D (61)
		
		[ContainerField(62), LayoutImmutable, Blittable]
		public bool MatchmakeImmediately { get; set; } // 0x3E (62)
		
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
