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

		public static void Deserialize(OnlineSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Backend = (BackendType) p_Reader.ReadInt32();
			p_Instance.PeerBackend = (BackendType) p_Reader.ReadInt32();
			p_Instance.Environment = (OnlineEnvironment) p_Reader.ReadInt32();
			p_Instance.MatchmakingToken = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Provider.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.RichPresence.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ChatSettings.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MatchmakingOptions = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Region = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.NegativeUserCacheRefreshPeriod = p_Reader.ReadUInt32();
			p_Instance.MatchmakingMode = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Country = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.IsSecure = p_Reader.ReadBool();
			p_Instance.SupportHostMigration = p_Reader.ReadBool();
			p_Instance.MatchmakeImmediately = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
