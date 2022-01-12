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
	[ContainerType(4, 124)]
	public class VeniceOnlineSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint WebFeedMaxFetchAttempts { get; set; }

		[ContainerField(16)]
		public List<OnlinePlatformConfiguration> Platforms { get; set; } = new();

		[ContainerField(20), LayoutImmutable]
		public string ServiceNameOverride { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string ClientGameConfigurationOverride { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, Blittable]
		public int BlazeLogLevel { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public int DirtySockLogLevel { get; set; }

		[ContainerField(36), LayoutImmutable]
		public string BattlelogReportURL { get; set; } = string.Empty;

		[ContainerField(40)]
		public RefArray<EntitlementQuery> EntitlementQueries { get; set; } = new();

		[ContainerField(44), LayoutImmutable]
		public string WebFeedUrlPrefix { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, Blittable]
		public float SnowrollerOrphanTimeout { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public int QueueCapacityOverride { get; set; }

		[ContainerField(56), LayoutImmutable]
		public string WebFeedCountUrlPrefix { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable, Blittable]
		public uint MatchFeedMaxFetchAttempts { get; set; }

		[ContainerField(64)]
		public DTagUploadPolicy DogTagUploadPolicy { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable]
		public uint WebFeedUnreadCountFetchPeriod { get; set; }

		[ContainerField(72), LayoutImmutable]
		public string MatchImagesUrlPrefix { get; set; } = string.Empty;

		[ContainerField(76), LayoutImmutable, Blittable]
		public uint WebFeedMaxItems { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public uint WebFeedMinimumMillisecondsBetweenRequests { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public uint WebFeedMillisecondsBetweenNewRequestAttempt { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public uint MatchFeedMinimumMillisecondsBetweenRequests { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public uint MatchFeedMinimumMillisecondsBetweenMatchRequests { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public uint PingPeriod { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint MatchFeedMinimumMillisecondsBetweenNewRequestAttempt { get; set; }

		[ContainerField(104), LayoutImmutable]
		public string MatchFeedDetailsUrlPrefix { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable]
		public string MatchFeedListUrlPrefix { get; set; } = string.Empty;

		[ContainerField(112), LayoutImmutable, Blittable]
		public uint MatchFeedMinimumMillisecondsBetweenMatchReloads { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool EnableSnowroller { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable]
		public bool EnableQoS { get; set; }

		[ContainerField(118), LayoutImmutable, Blittable]
		public bool PunkBusterActivateClient { get; set; }

		[ContainerField(119), LayoutImmutable, Blittable]
		public bool PunkBusterActivateServer { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public bool BattlelogReport { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable]
		public bool UseFallback { get; set; }

	}
}
