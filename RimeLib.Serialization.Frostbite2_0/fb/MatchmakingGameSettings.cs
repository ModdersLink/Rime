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

namespace fb
{
	[ContainerType(1, 12)]
	public class MatchmakingGameSettings :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public bool OpenToBrowsing { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
		public bool OpenToInvites { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
		public bool OpenToMatchmaking { get; set; }
		
		[ContainerField(3), LayoutImmutable, Blittable, JsonProperty(Order = 3)]
		public bool OpenToJoinByPlayer { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public bool HostMigratable { get; set; }
		
		[ContainerField(5), LayoutImmutable, Blittable, JsonProperty(Order = 5)]
		public bool Ranked { get; set; }
		
		[ContainerField(6), LayoutImmutable, Blittable, JsonProperty(Order = 6)]
		public bool AdminOnlyInvites { get; set; }
		
		[ContainerField(7), LayoutImmutable, Blittable, JsonProperty(Order = 7)]
		public bool EnforceSingleGroupJoin { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public bool JoinInProgressSupported { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		public bool AdminInvitesOnlyIgnoreEntryChecks { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		public bool EnablePersistedGameId { get; set; }
		
		[ContainerField(11), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
		public bool AllowSameTeamId { get; set; }
		
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
