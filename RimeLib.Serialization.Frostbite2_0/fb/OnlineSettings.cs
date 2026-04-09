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
	[ContainerType(4, 64)]
	public partial class OnlineSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private BackendType _Backend = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private BackendType _PeerBackend = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private OnlineEnvironment _Environment = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _MatchmakingToken = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<OnlineProviderAsset> _Provider = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<RichPresenceData> _RichPresence = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private CtrRef<ChatSettings> _ChatSettings = new();

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		private string _MatchmakingOptions = string.Empty;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		private string _Region = string.Empty;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private uint _NegativeUserCacheRefreshPeriod;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		private string _MatchmakingMode = string.Empty;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		private string _Country = string.Empty;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _IsSecure;

		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private bool _SupportHostMigration;

		[ObservableProperty]
		[property: ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		private bool _MatchmakeImmediately;

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
