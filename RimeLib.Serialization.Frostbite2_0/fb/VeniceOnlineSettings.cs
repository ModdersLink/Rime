///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
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
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint WebFeedMaxFetchAttempts { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<OnlinePlatformConfiguration> Platforms { get; set; } = new();

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string ServiceNameOverride { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string ClientGameConfigurationOverride { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int BlazeLogLevel { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public int DirtySockLogLevel { get; set; }

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string BattlelogReportURL { get; set; } = string.Empty;

		[ContainerField(40), JsonProperty(Order = 40)]
		public RefArray<EntitlementQuery> EntitlementQueries { get; set; } = new();

		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string WebFeedUrlPrefix { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float SnowrollerOrphanTimeout { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public int QueueCapacityOverride { get; set; }

		[ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		public string WebFeedCountUrlPrefix { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public uint MatchFeedMaxFetchAttempts { get; set; }

		[ContainerField(64), JsonProperty(Order = 64)]
		public DTagUploadPolicy DogTagUploadPolicy { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public uint WebFeedUnreadCountFetchPeriod { get; set; }

		[ContainerField(72), LayoutImmutable, JsonProperty(Order = 72)]
		public string MatchImagesUrlPrefix { get; set; } = string.Empty;

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public uint WebFeedMaxItems { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public uint WebFeedMinimumMillisecondsBetweenRequests { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public uint WebFeedMillisecondsBetweenNewRequestAttempt { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public uint MatchFeedMinimumMillisecondsBetweenRequests { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public uint MatchFeedMinimumMillisecondsBetweenMatchRequests { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public uint PingPeriod { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public uint MatchFeedMinimumMillisecondsBetweenNewRequestAttempt { get; set; }

		[ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		public string MatchFeedDetailsUrlPrefix { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, JsonProperty(Order = 108)]
		public string MatchFeedListUrlPrefix { get; set; } = string.Empty;

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public uint MatchFeedMinimumMillisecondsBetweenMatchReloads { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public bool EnableSnowroller { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		public bool EnableQoS { get; set; }

		[ContainerField(118), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
		public bool PunkBusterActivateClient { get; set; }

		[ContainerField(119), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
		public bool PunkBusterActivateServer { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public bool BattlelogReport { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		public bool UseFallback { get; set; }

	}
}
