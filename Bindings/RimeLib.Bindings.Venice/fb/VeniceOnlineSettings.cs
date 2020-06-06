///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VeniceOnlineSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint WebFeedMaxFetchAttempts { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<OnlinePlatformConfiguration> Platforms { get; set; } = new List<OnlinePlatformConfiguration>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string ServiceNameOverride { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string ClientGameConfigurationOverride { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int BlazeLogLevel { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int DirtySockLogLevel { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string BattlelogReportURL { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public RefArray<EntitlementQuery> EntitlementQueries { get; set; } = new RefArray<EntitlementQuery>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable]
		public string WebFeedUrlPrefix { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float SnowrollerOrphanTimeout { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public int QueueCapacityOverride { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable]
		public string WebFeedCountUrlPrefix { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public uint MatchFeedMaxFetchAttempts { get; set; } // 0x3C (60)
		
		[ContainerField(64)]
		public DTagUploadPolicy DogTagUploadPolicy { get; set; } = new DTagUploadPolicy(); // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public uint WebFeedUnreadCountFetchPeriod { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable]
		public string MatchImagesUrlPrefix { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public uint WebFeedMaxItems { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public uint WebFeedMinimumMillisecondsBetweenRequests { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public uint WebFeedMillisecondsBetweenNewRequestAttempt { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public uint MatchFeedMinimumMillisecondsBetweenRequests { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public uint MatchFeedMinimumMillisecondsBetweenMatchRequests { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint PingPeriod { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint MatchFeedMinimumMillisecondsBetweenNewRequestAttempt { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable]
		public string MatchFeedDetailsUrlPrefix { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable]
		public string MatchFeedListUrlPrefix { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public uint MatchFeedMinimumMillisecondsBetweenMatchReloads { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool EnableSnowroller { get; set; } // 0x74 (116)
		
		[ContainerField(117), LayoutImmutable, Blittable]
		public bool EnableQoS { get; set; } // 0x75 (117)
		
		[ContainerField(118), LayoutImmutable, Blittable]
		public bool PunkBusterActivateClient { get; set; } // 0x76 (118)
		
		[ContainerField(119), LayoutImmutable, Blittable]
		public bool PunkBusterActivateServer { get; set; } // 0x77 (119)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public bool BattlelogReport { get; set; } // 0x78 (120)
		
		[ContainerField(121), LayoutImmutable, Blittable]
		public bool UseFallback { get; set; } // 0x79 (121)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1571589249:
					WebFeedMaxFetchAttempts = (uint) p_Value;
					break;

				case 1046011945:
					Platforms = (List<OnlinePlatformConfiguration>) p_Value;
					break;

				case 2327369995:
					ServiceNameOverride = (string) p_Value;
					break;

				case 733163350:
					ClientGameConfigurationOverride = (string) p_Value;
					break;

				case 2299541703:
					BlazeLogLevel = (int) p_Value;
					break;

				case 4290716369:
					DirtySockLogLevel = (int) p_Value;
					break;

				case 2679714382:
					BattlelogReportURL = (string) p_Value;
					break;

				case 2121789744:
					EntitlementQueries = (RefArray<EntitlementQuery>) p_Value;
					break;

				case 2227976588:
					WebFeedUrlPrefix = (string) p_Value;
					break;

				case 82601883:
					SnowrollerOrphanTimeout = (float) p_Value;
					break;

				case 4173302708:
					QueueCapacityOverride = (int) p_Value;
					break;

				case 1351173167:
					WebFeedCountUrlPrefix = (string) p_Value;
					break;

				case 3507950114:
					MatchFeedMaxFetchAttempts = (uint) p_Value;
					break;

				case 4161550072:
					DogTagUploadPolicy = (DTagUploadPolicy) Enum.ToObject(typeof(DTagUploadPolicy), p_Value);
					break;

				case 3644485796:
					WebFeedUnreadCountFetchPeriod = (uint) p_Value;
					break;

				case 1247734425:
					MatchImagesUrlPrefix = (string) p_Value;
					break;

				case 925083525:
					WebFeedMaxItems = (uint) p_Value;
					break;

				case 3704979463:
					WebFeedMinimumMillisecondsBetweenRequests = (uint) p_Value;
					break;

				case 539738643:
					WebFeedMillisecondsBetweenNewRequestAttempt = (uint) p_Value;
					break;

				case 488254884:
					MatchFeedMinimumMillisecondsBetweenRequests = (uint) p_Value;
					break;

				case 2292545591:
					MatchFeedMinimumMillisecondsBetweenMatchRequests = (uint) p_Value;
					break;

				case 313811184:
					PingPeriod = (uint) p_Value;
					break;

				case 2736357702:
					MatchFeedMinimumMillisecondsBetweenNewRequestAttempt = (uint) p_Value;
					break;

				case 51926925:
					MatchFeedDetailsUrlPrefix = (string) p_Value;
					break;

				case 89835149:
					MatchFeedListUrlPrefix = (string) p_Value;
					break;

				case 1237196023:
					MatchFeedMinimumMillisecondsBetweenMatchReloads = (uint) p_Value;
					break;

				case 612631659:
					EnableSnowroller = (bool) p_Value;
					break;

				case 2899410345:
					EnableQoS = (bool) p_Value;
					break;

				case 3322055778:
					PunkBusterActivateClient = (bool) p_Value;
					break;

				case 2704498110:
					PunkBusterActivateServer = (bool) p_Value;
					break;

				case 1287955237:
					BattlelogReport = (bool) p_Value;
					break;

				case 2260806602:
					UseFallback = (bool) p_Value;
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
				case 1571589249:
					return WebFeedMaxFetchAttempts;

				case 1046011945:
					return Platforms;

				case 2327369995:
					return ServiceNameOverride;

				case 733163350:
					return ClientGameConfigurationOverride;

				case 2299541703:
					return BlazeLogLevel;

				case 4290716369:
					return DirtySockLogLevel;

				case 2679714382:
					return BattlelogReportURL;

				case 2121789744:
					return EntitlementQueries;

				case 2227976588:
					return WebFeedUrlPrefix;

				case 82601883:
					return SnowrollerOrphanTimeout;

				case 4173302708:
					return QueueCapacityOverride;

				case 1351173167:
					return WebFeedCountUrlPrefix;

				case 3507950114:
					return MatchFeedMaxFetchAttempts;

				case 4161550072:
					return DogTagUploadPolicy;

				case 3644485796:
					return WebFeedUnreadCountFetchPeriod;

				case 1247734425:
					return MatchImagesUrlPrefix;

				case 925083525:
					return WebFeedMaxItems;

				case 3704979463:
					return WebFeedMinimumMillisecondsBetweenRequests;

				case 539738643:
					return WebFeedMillisecondsBetweenNewRequestAttempt;

				case 488254884:
					return MatchFeedMinimumMillisecondsBetweenRequests;

				case 2292545591:
					return MatchFeedMinimumMillisecondsBetweenMatchRequests;

				case 313811184:
					return PingPeriod;

				case 2736357702:
					return MatchFeedMinimumMillisecondsBetweenNewRequestAttempt;

				case 51926925:
					return MatchFeedDetailsUrlPrefix;

				case 89835149:
					return MatchFeedListUrlPrefix;

				case 1237196023:
					return MatchFeedMinimumMillisecondsBetweenMatchReloads;

				case 612631659:
					return EnableSnowroller;

				case 2899410345:
					return EnableQoS;

				case 3322055778:
					return PunkBusterActivateClient;

				case 2704498110:
					return PunkBusterActivateServer;

				case 1287955237:
					return BattlelogReport;

				case 2260806602:
					return UseFallback;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1571589249:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(WebFeedMaxFetchAttempts));

				case 1046011945:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(Platforms));

				case 2327369995:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(ServiceNameOverride));

				case 733163350:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(ClientGameConfigurationOverride));

				case 2299541703:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(BlazeLogLevel));

				case 4290716369:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(DirtySockLogLevel));

				case 2679714382:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(BattlelogReportURL));

				case 2121789744:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(EntitlementQueries));

				case 2227976588:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(WebFeedUrlPrefix));

				case 82601883:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(SnowrollerOrphanTimeout));

				case 4173302708:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(QueueCapacityOverride));

				case 1351173167:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(WebFeedCountUrlPrefix));

				case 3507950114:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(MatchFeedMaxFetchAttempts));

				case 4161550072:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(DogTagUploadPolicy));

				case 3644485796:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(WebFeedUnreadCountFetchPeriod));

				case 1247734425:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(MatchImagesUrlPrefix));

				case 925083525:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(WebFeedMaxItems));

				case 3704979463:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(WebFeedMinimumMillisecondsBetweenRequests));

				case 539738643:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(WebFeedMillisecondsBetweenNewRequestAttempt));

				case 488254884:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(MatchFeedMinimumMillisecondsBetweenRequests));

				case 2292545591:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(MatchFeedMinimumMillisecondsBetweenMatchRequests));

				case 313811184:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(PingPeriod));

				case 2736357702:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(MatchFeedMinimumMillisecondsBetweenNewRequestAttempt));

				case 51926925:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(MatchFeedDetailsUrlPrefix));

				case 89835149:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(MatchFeedListUrlPrefix));

				case 1237196023:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(MatchFeedMinimumMillisecondsBetweenMatchReloads));

				case 612631659:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(EnableSnowroller));

				case 2899410345:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(EnableQoS));

				case 3322055778:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(PunkBusterActivateClient));

				case 2704498110:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(PunkBusterActivateServer));

				case 1287955237:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(BattlelogReport));

				case 2260806602:
					return typeof(VeniceOnlineSettings).GetProperty(nameof(UseFallback));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
