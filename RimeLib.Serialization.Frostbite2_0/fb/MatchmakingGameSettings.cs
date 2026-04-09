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
	[ContainerType(1, 12)]
	public partial class MatchmakingGameSettings :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private bool _OpenToBrowsing;
		
		[ObservableProperty]
		[property: ContainerField(1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
		private bool _OpenToInvites;
		
		[ObservableProperty]
		[property: ContainerField(2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
		private bool _OpenToMatchmaking;
		
		[ObservableProperty]
		[property: ContainerField(3), LayoutImmutable, Blittable, JsonProperty(Order = 3)]
		private bool _OpenToJoinByPlayer;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private bool _HostMigratable;
		
		[ObservableProperty]
		[property: ContainerField(5), LayoutImmutable, Blittable, JsonProperty(Order = 5)]
		private bool _Ranked;
		
		[ObservableProperty]
		[property: ContainerField(6), LayoutImmutable, Blittable, JsonProperty(Order = 6)]
		private bool _AdminOnlyInvites;
		
		[ObservableProperty]
		[property: ContainerField(7), LayoutImmutable, Blittable, JsonProperty(Order = 7)]
		private bool _EnforceSingleGroupJoin;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private bool _JoinInProgressSupported;
		
		[ObservableProperty]
		[property: ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		private bool _AdminInvitesOnlyIgnoreEntryChecks;
		
		[ObservableProperty]
		[property: ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		private bool _EnablePersistedGameId;
		
		[ObservableProperty]
		[property: ContainerField(11), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
		private bool _AllowSameTeamId;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(OpenToBrowsing);
			p_Writer.Write(OpenToInvites);
			p_Writer.Write(OpenToMatchmaking);
			p_Writer.Write(OpenToJoinByPlayer);
			p_Writer.Write(HostMigratable);
			p_Writer.Write(Ranked);
			p_Writer.Write(AdminOnlyInvites);
			p_Writer.Write(EnforceSingleGroupJoin);
			p_Writer.Write(JoinInProgressSupported);
			p_Writer.Write(AdminInvitesOnlyIgnoreEntryChecks);
			p_Writer.Write(EnablePersistedGameId);
			p_Writer.Write(AllowSameTeamId);
		}
	}
}
