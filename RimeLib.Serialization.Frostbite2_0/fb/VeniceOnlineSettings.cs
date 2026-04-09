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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 124)]
	public partial class VeniceOnlineSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _WebFeedMaxFetchAttempts;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<OnlinePlatformConfiguration> _Platforms = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _ServiceNameOverride = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _ClientGameConfigurationOverride = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private int _BlazeLogLevel;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private int _DirtySockLogLevel;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _BattlelogReportURL = string.Empty;

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private RefArray<EntitlementQuery> _EntitlementQueries = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		private string _WebFeedUrlPrefix = string.Empty;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _SnowrollerOrphanTimeout;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private int _QueueCapacityOverride;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		private string _WebFeedCountUrlPrefix = string.Empty;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private uint _MatchFeedMaxFetchAttempts;

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private DTagUploadPolicy _DogTagUploadPolicy = new();

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private uint _WebFeedUnreadCountFetchPeriod;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, JsonProperty(Order = 72)]
		private string _MatchImagesUrlPrefix = string.Empty;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private uint _WebFeedMaxItems;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private uint _WebFeedMinimumMillisecondsBetweenRequests;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private uint _WebFeedMillisecondsBetweenNewRequestAttempt;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private uint _MatchFeedMinimumMillisecondsBetweenRequests;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private uint _MatchFeedMinimumMillisecondsBetweenMatchRequests;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private uint _PingPeriod;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private uint _MatchFeedMinimumMillisecondsBetweenNewRequestAttempt;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		private string _MatchFeedDetailsUrlPrefix = string.Empty;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, JsonProperty(Order = 108)]
		private string _MatchFeedListUrlPrefix = string.Empty;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private uint _MatchFeedMinimumMillisecondsBetweenMatchReloads;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private bool _EnableSnowroller;

		[ObservableProperty]
		[property: ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		private bool _EnableQoS;

		[ObservableProperty]
		[property: ContainerField(118), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
		private bool _PunkBusterActivateClient;

		[ObservableProperty]
		[property: ContainerField(119), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
		private bool _PunkBusterActivateServer;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private bool _BattlelogReport;

		[ObservableProperty]
		[property: ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		private bool _UseFallback;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(WebFeedMaxFetchAttempts);
			(RimeWriter Writer, uint ArrayIndex) s_Platforms = p_EbxWriter.GetArrayWriter(Platforms.GetType(), Platforms.Count);
			p_Writer.Write(s_Platforms.ArrayIndex);
			foreach (var s_Entry in Platforms)
			{
				s_Entry.Serialize(s_Platforms.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteString(ServiceNameOverride));
			p_Writer.Write(p_EbxWriter.WriteString(ClientGameConfigurationOverride));
			p_Writer.Write(BlazeLogLevel);
			p_Writer.Write(DirtySockLogLevel);
			p_Writer.Write(p_EbxWriter.WriteString(BattlelogReportURL));
			(RimeWriter Writer, uint ArrayIndex) s_EntitlementQueries = p_EbxWriter.GetArrayWriter(EntitlementQueries.GetType(), EntitlementQueries.Count);
			p_Writer.Write(s_EntitlementQueries.ArrayIndex);
			foreach (var s_Entry in EntitlementQueries)
			{
				s_EntitlementQueries.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteString(WebFeedUrlPrefix));
			p_Writer.Write(SnowrollerOrphanTimeout);
			p_Writer.Write(QueueCapacityOverride);
			p_Writer.Write(p_EbxWriter.WriteString(WebFeedCountUrlPrefix));
			p_Writer.Write(MatchFeedMaxFetchAttempts);
			p_Writer.Write((int) DogTagUploadPolicy);
			p_Writer.Write(WebFeedUnreadCountFetchPeriod);
			p_Writer.Write(p_EbxWriter.WriteString(MatchImagesUrlPrefix));
			p_Writer.Write(WebFeedMaxItems);
			p_Writer.Write(WebFeedMinimumMillisecondsBetweenRequests);
			p_Writer.Write(WebFeedMillisecondsBetweenNewRequestAttempt);
			p_Writer.Write(MatchFeedMinimumMillisecondsBetweenRequests);
			p_Writer.Write(MatchFeedMinimumMillisecondsBetweenMatchRequests);
			p_Writer.Write(PingPeriod);
			p_Writer.Write(MatchFeedMinimumMillisecondsBetweenNewRequestAttempt);
			p_Writer.Write(p_EbxWriter.WriteString(MatchFeedDetailsUrlPrefix));
			p_Writer.Write(p_EbxWriter.WriteString(MatchFeedListUrlPrefix));
			p_Writer.Write(MatchFeedMinimumMillisecondsBetweenMatchReloads);
			p_Writer.Write(EnableSnowroller);
			p_Writer.Write(EnableQoS);
			p_Writer.Write(PunkBusterActivateClient);
			p_Writer.Write(PunkBusterActivateServer);
			p_Writer.Write(BattlelogReport);
			p_Writer.Write(UseFallback);
			p_Writer.WriteNullBytes(2);
		}
	}
}
