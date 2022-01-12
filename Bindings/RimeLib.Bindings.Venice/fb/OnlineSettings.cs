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
	[ContainerType(4, 64)]
	public class OnlineSettings : 
		SystemSettings
	{
		[ContainerField(12)]
		public BackendType Backend { get; set; } = new();

		[ContainerField(16)]
		public BackendType PeerBackend { get; set; } = new();

		[ContainerField(20)]
		public OnlineEnvironment Environment { get; set; } = new();

		[ContainerField(24), LayoutImmutable]
		public string MatchmakingToken { get; set; } = string.Empty;

		[ContainerField(28)]
		public CtrRef<OnlineProviderAsset> Provider { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<RichPresenceData> RichPresence { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<ChatSettings> ChatSettings { get; set; } = new();

		[ContainerField(40), LayoutImmutable]
		public string MatchmakingOptions { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable]
		public string Region { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, Blittable]
		public uint NegativeUserCacheRefreshPeriod { get; set; }

		[ContainerField(52), LayoutImmutable]
		public string MatchmakingMode { get; set; } = string.Empty;

		[ContainerField(56), LayoutImmutable]
		public string Country { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool IsSecure { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public bool SupportHostMigration { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable]
		public bool MatchmakeImmediately { get; set; }

	}
}
