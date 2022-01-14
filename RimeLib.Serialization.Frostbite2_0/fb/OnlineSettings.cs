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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class OnlineSettings :
		SystemSettings
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public BackendType Backend { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public BackendType PeerBackend { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public OnlineEnvironment Environment { get; set; } = new();

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string MatchmakingToken { get; set; } = string.Empty;

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<OnlineProviderAsset> Provider { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<RichPresenceData> RichPresence { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<ChatSettings> ChatSettings { get; set; } = new();

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string MatchmakingOptions { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string Region { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public uint NegativeUserCacheRefreshPeriod { get; set; }

		[ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		public string MatchmakingMode { get; set; } = string.Empty;

		[ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		public string Country { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool IsSecure { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public bool SupportHostMigration { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		public bool MatchmakeImmediately { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Backend);
			p_Writer.Write((int) PeerBackend);
			p_Writer.Write((int) Environment);
			p_Writer.Write(p_EbxWriter.WriteString(MatchmakingToken));
			p_Writer.Write(p_EbxWriter.WriteImport(Provider));
			p_Writer.Write(p_EbxWriter.WriteImport(RichPresence));
			p_Writer.Write(p_EbxWriter.WriteImport(ChatSettings));
			p_Writer.Write(p_EbxWriter.WriteString(MatchmakingOptions));
			p_Writer.Write(p_EbxWriter.WriteString(Region));
			p_Writer.Write(NegativeUserCacheRefreshPeriod);
			p_Writer.Write(p_EbxWriter.WriteString(MatchmakingMode));
			p_Writer.Write(p_EbxWriter.WriteString(Country));
			p_Writer.Write(IsSecure);
			p_Writer.Write(SupportHostMigration);
			p_Writer.Write(MatchmakeImmediately);
			p_Writer.WriteNullBytes(1);
		}
	}
}
