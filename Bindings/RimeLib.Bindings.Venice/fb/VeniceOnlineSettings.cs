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
	public class VeniceOnlineSettings : 
		SystemSettings
	{
		protected uint m_WebFeedMaxFetchAttempts = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1571589249)]
		public uint WebFeedMaxFetchAttempts { get { return m_WebFeedMaxFetchAttempts; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(WebFeedMaxFetchAttempts), this, m_WebFeedMaxFetchAttempts, value)) m_WebFeedMaxFetchAttempts = value; } } // 0xC (12)
		
		protected List<OnlinePlatformConfiguration> m_Platforms = new List<OnlinePlatformConfiguration>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(1046011945), ContainerArray]
		public List<OnlinePlatformConfiguration> Platforms { get { return m_Platforms; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(Platforms), this, m_Platforms, value)) m_Platforms = value; } } // 0x10 (16)
		
		protected string m_ServiceNameOverride = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2327369995)]
		public string ServiceNameOverride { get { return m_ServiceNameOverride; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(ServiceNameOverride), this, m_ServiceNameOverride, value)) m_ServiceNameOverride = value; } } // 0x14 (20)
		
		protected string m_ClientGameConfigurationOverride = string.Empty;
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(733163350)]
		public string ClientGameConfigurationOverride { get { return m_ClientGameConfigurationOverride; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(ClientGameConfigurationOverride), this, m_ClientGameConfigurationOverride, value)) m_ClientGameConfigurationOverride = value; } } // 0x18 (24)
		
		protected int m_BlazeLogLevel = new int();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2299541703)]
		public int BlazeLogLevel { get { return m_BlazeLogLevel; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(BlazeLogLevel), this, m_BlazeLogLevel, value)) m_BlazeLogLevel = value; } } // 0x1C (28)
		
		protected int m_DirtySockLogLevel = new int();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4290716369)]
		public int DirtySockLogLevel { get { return m_DirtySockLogLevel; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(DirtySockLogLevel), this, m_DirtySockLogLevel, value)) m_DirtySockLogLevel = value; } } // 0x20 (32)
		
		protected string m_BattlelogReportURL = string.Empty;
		[ContainerField(36), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2679714382)]
		public string BattlelogReportURL { get { return m_BattlelogReportURL; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(BattlelogReportURL), this, m_BattlelogReportURL, value)) m_BattlelogReportURL = value; } } // 0x24 (36)
		
		protected RefArray<EntitlementQuery> m_EntitlementQueries = new RefArray<EntitlementQuery>();
		[ContainerField(40), MemberInfoFlag(65), ContainerFieldNameHash(2121789744), ContainerRefArray]
		public RefArray<EntitlementQuery> EntitlementQueries { get { return m_EntitlementQueries; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(EntitlementQueries), this, m_EntitlementQueries, value)) m_EntitlementQueries = value; } } // 0x28 (40)
		
		protected string m_WebFeedUrlPrefix = string.Empty;
		[ContainerField(44), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2227976588)]
		public string WebFeedUrlPrefix { get { return m_WebFeedUrlPrefix; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(WebFeedUrlPrefix), this, m_WebFeedUrlPrefix, value)) m_WebFeedUrlPrefix = value; } } // 0x2C (44)
		
		protected float m_SnowrollerOrphanTimeout = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(82601883)]
		public float SnowrollerOrphanTimeout { get { return m_SnowrollerOrphanTimeout; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(SnowrollerOrphanTimeout), this, m_SnowrollerOrphanTimeout, value)) m_SnowrollerOrphanTimeout = value; } } // 0x30 (48)
		
		protected int m_QueueCapacityOverride = new int();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4173302708)]
		public int QueueCapacityOverride { get { return m_QueueCapacityOverride; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(QueueCapacityOverride), this, m_QueueCapacityOverride, value)) m_QueueCapacityOverride = value; } } // 0x34 (52)
		
		protected string m_WebFeedCountUrlPrefix = string.Empty;
		[ContainerField(56), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1351173167)]
		public string WebFeedCountUrlPrefix { get { return m_WebFeedCountUrlPrefix; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(WebFeedCountUrlPrefix), this, m_WebFeedCountUrlPrefix, value)) m_WebFeedCountUrlPrefix = value; } } // 0x38 (56)
		
		protected uint m_MatchFeedMaxFetchAttempts = new uint();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3507950114)]
		public uint MatchFeedMaxFetchAttempts { get { return m_MatchFeedMaxFetchAttempts; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(MatchFeedMaxFetchAttempts), this, m_MatchFeedMaxFetchAttempts, value)) m_MatchFeedMaxFetchAttempts = value; } } // 0x3C (60)
		
		protected DTagUploadPolicy m_DogTagUploadPolicy = new DTagUploadPolicy();
		[ContainerField(64), MemberInfoFlag(137), ContainerFieldNameHash(4161550072)]
		public DTagUploadPolicy DogTagUploadPolicy { get { return m_DogTagUploadPolicy; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(DogTagUploadPolicy), this, m_DogTagUploadPolicy, value)) m_DogTagUploadPolicy = value; } } // 0x40 (64)
		
		protected uint m_WebFeedUnreadCountFetchPeriod = new uint();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3644485796)]
		public uint WebFeedUnreadCountFetchPeriod { get { return m_WebFeedUnreadCountFetchPeriod; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(WebFeedUnreadCountFetchPeriod), this, m_WebFeedUnreadCountFetchPeriod, value)) m_WebFeedUnreadCountFetchPeriod = value; } } // 0x44 (68)
		
		protected string m_MatchImagesUrlPrefix = string.Empty;
		[ContainerField(72), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1247734425)]
		public string MatchImagesUrlPrefix { get { return m_MatchImagesUrlPrefix; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(MatchImagesUrlPrefix), this, m_MatchImagesUrlPrefix, value)) m_MatchImagesUrlPrefix = value; } } // 0x48 (72)
		
		protected uint m_WebFeedMaxItems = new uint();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(925083525)]
		public uint WebFeedMaxItems { get { return m_WebFeedMaxItems; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(WebFeedMaxItems), this, m_WebFeedMaxItems, value)) m_WebFeedMaxItems = value; } } // 0x4C (76)
		
		protected uint m_WebFeedMinimumMillisecondsBetweenRequests = new uint();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3704979463)]
		public uint WebFeedMinimumMillisecondsBetweenRequests { get { return m_WebFeedMinimumMillisecondsBetweenRequests; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(WebFeedMinimumMillisecondsBetweenRequests), this, m_WebFeedMinimumMillisecondsBetweenRequests, value)) m_WebFeedMinimumMillisecondsBetweenRequests = value; } } // 0x50 (80)
		
		protected uint m_WebFeedMillisecondsBetweenNewRequestAttempt = new uint();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(539738643)]
		public uint WebFeedMillisecondsBetweenNewRequestAttempt { get { return m_WebFeedMillisecondsBetweenNewRequestAttempt; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(WebFeedMillisecondsBetweenNewRequestAttempt), this, m_WebFeedMillisecondsBetweenNewRequestAttempt, value)) m_WebFeedMillisecondsBetweenNewRequestAttempt = value; } } // 0x54 (84)
		
		protected uint m_MatchFeedMinimumMillisecondsBetweenRequests = new uint();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(488254884)]
		public uint MatchFeedMinimumMillisecondsBetweenRequests { get { return m_MatchFeedMinimumMillisecondsBetweenRequests; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(MatchFeedMinimumMillisecondsBetweenRequests), this, m_MatchFeedMinimumMillisecondsBetweenRequests, value)) m_MatchFeedMinimumMillisecondsBetweenRequests = value; } } // 0x58 (88)
		
		protected uint m_MatchFeedMinimumMillisecondsBetweenMatchRequests = new uint();
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2292545591)]
		public uint MatchFeedMinimumMillisecondsBetweenMatchRequests { get { return m_MatchFeedMinimumMillisecondsBetweenMatchRequests; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(MatchFeedMinimumMillisecondsBetweenMatchRequests), this, m_MatchFeedMinimumMillisecondsBetweenMatchRequests, value)) m_MatchFeedMinimumMillisecondsBetweenMatchRequests = value; } } // 0x5C (92)
		
		protected uint m_PingPeriod = new uint();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(313811184)]
		public uint PingPeriod { get { return m_PingPeriod; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(PingPeriod), this, m_PingPeriod, value)) m_PingPeriod = value; } } // 0x60 (96)
		
		protected uint m_MatchFeedMinimumMillisecondsBetweenNewRequestAttempt = new uint();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2736357702)]
		public uint MatchFeedMinimumMillisecondsBetweenNewRequestAttempt { get { return m_MatchFeedMinimumMillisecondsBetweenNewRequestAttempt; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(MatchFeedMinimumMillisecondsBetweenNewRequestAttempt), this, m_MatchFeedMinimumMillisecondsBetweenNewRequestAttempt, value)) m_MatchFeedMinimumMillisecondsBetweenNewRequestAttempt = value; } } // 0x64 (100)
		
		protected string m_MatchFeedDetailsUrlPrefix = string.Empty;
		[ContainerField(104), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(51926925)]
		public string MatchFeedDetailsUrlPrefix { get { return m_MatchFeedDetailsUrlPrefix; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(MatchFeedDetailsUrlPrefix), this, m_MatchFeedDetailsUrlPrefix, value)) m_MatchFeedDetailsUrlPrefix = value; } } // 0x68 (104)
		
		protected string m_MatchFeedListUrlPrefix = string.Empty;
		[ContainerField(108), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(89835149)]
		public string MatchFeedListUrlPrefix { get { return m_MatchFeedListUrlPrefix; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(MatchFeedListUrlPrefix), this, m_MatchFeedListUrlPrefix, value)) m_MatchFeedListUrlPrefix = value; } } // 0x6C (108)
		
		protected uint m_MatchFeedMinimumMillisecondsBetweenMatchReloads = new uint();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1237196023)]
		public uint MatchFeedMinimumMillisecondsBetweenMatchReloads { get { return m_MatchFeedMinimumMillisecondsBetweenMatchReloads; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(MatchFeedMinimumMillisecondsBetweenMatchReloads), this, m_MatchFeedMinimumMillisecondsBetweenMatchReloads, value)) m_MatchFeedMinimumMillisecondsBetweenMatchReloads = value; } } // 0x70 (112)
		
		protected bool m_EnableSnowroller = new bool();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(612631659)]
		public bool EnableSnowroller { get { return m_EnableSnowroller; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(EnableSnowroller), this, m_EnableSnowroller, value)) m_EnableSnowroller = value; } } // 0x74 (116)
		
		protected bool m_EnableQoS = new bool();
		[ContainerField(117), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2899410345)]
		public bool EnableQoS { get { return m_EnableQoS; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(EnableQoS), this, m_EnableQoS, value)) m_EnableQoS = value; } } // 0x75 (117)
		
		protected bool m_PunkBusterActivateClient = new bool();
		[ContainerField(118), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3322055778)]
		public bool PunkBusterActivateClient { get { return m_PunkBusterActivateClient; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(PunkBusterActivateClient), this, m_PunkBusterActivateClient, value)) m_PunkBusterActivateClient = value; } } // 0x76 (118)
		
		protected bool m_PunkBusterActivateServer = new bool();
		[ContainerField(119), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2704498110)]
		public bool PunkBusterActivateServer { get { return m_PunkBusterActivateServer; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(PunkBusterActivateServer), this, m_PunkBusterActivateServer, value)) m_PunkBusterActivateServer = value; } } // 0x77 (119)
		
		protected bool m_BattlelogReport = new bool();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1287955237)]
		public bool BattlelogReport { get { return m_BattlelogReport; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(BattlelogReport), this, m_BattlelogReport, value)) m_BattlelogReport = value; } } // 0x78 (120)
		
		protected bool m_UseFallback = new bool();
		[ContainerField(121), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2260806602)]
		public bool UseFallback { get { return m_UseFallback; } set { if (OnPropertyChanging("VeniceOnlineSettings." + nameof(UseFallback), this, m_UseFallback, value)) m_UseFallback = value; } } // 0x79 (121)
		
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
