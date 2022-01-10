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
	[ContainerType(1, 12)]
	public class MatchmakingGameSettings
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public bool OpenToBrowsing { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable]
		public bool OpenToInvites { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable]
		public bool OpenToMatchmaking { get; set; }
		
		[ContainerField(3), LayoutImmutable, Blittable]
		public bool OpenToJoinByPlayer { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public bool HostMigratable { get; set; }
		
		[ContainerField(5), LayoutImmutable, Blittable]
		public bool Ranked { get; set; }
		
		[ContainerField(6), LayoutImmutable, Blittable]
		public bool AdminOnlyInvites { get; set; }
		
		[ContainerField(7), LayoutImmutable, Blittable]
		public bool EnforceSingleGroupJoin { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool JoinInProgressSupported { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public bool AdminInvitesOnlyIgnoreEntryChecks { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable]
		public bool EnablePersistedGameId { get; set; }
		
		[ContainerField(11), LayoutImmutable, Blittable]
		public bool AllowSameTeamId { get; set; }
		
		public static void Deserialize(MatchmakingGameSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.OpenToBrowsing = p_Reader.ReadBool();
			p_Instance.OpenToInvites = p_Reader.ReadBool();
			p_Instance.OpenToMatchmaking = p_Reader.ReadBool();
			p_Instance.OpenToJoinByPlayer = p_Reader.ReadBool();
			p_Instance.HostMigratable = p_Reader.ReadBool();
			p_Instance.Ranked = p_Reader.ReadBool();
			p_Instance.AdminOnlyInvites = p_Reader.ReadBool();
			p_Instance.EnforceSingleGroupJoin = p_Reader.ReadBool();
			p_Instance.JoinInProgressSupported = p_Reader.ReadBool();
			p_Instance.AdminInvitesOnlyIgnoreEntryChecks = p_Reader.ReadBool();
			p_Instance.EnablePersistedGameId = p_Reader.ReadBool();
			p_Instance.AllowSameTeamId = p_Reader.ReadBool();
		}
	}
}
