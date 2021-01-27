///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 1,  Flags: 41, Size: 12)]
	public class MatchmakingGameSettings : FrostbiteContainer
	{
		[ContainerField(Name: "OpenToBrowsing", Offset: 0, NameHash: 4203661745, Flags: 49325), LayoutImmutable, Blittable]
		public bool OpenToBrowsing { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "OpenToInvites", Offset: 1, NameHash: 4079225360, Flags: 49325), LayoutImmutable, Blittable]
		public bool OpenToInvites { get; set; } // 0x1 (1)
		
		[ContainerField(Name: "OpenToMatchmaking", Offset: 2, NameHash: 1779714654, Flags: 49325), LayoutImmutable, Blittable]
		public bool OpenToMatchmaking { get; set; } // 0x2 (2)
		
		[ContainerField(Name: "OpenToJoinByPlayer", Offset: 3, NameHash: 273410944, Flags: 49325), LayoutImmutable, Blittable]
		public bool OpenToJoinByPlayer { get; set; } // 0x3 (3)
		
		[ContainerField(Name: "HostMigratable", Offset: 4, NameHash: 1465774187, Flags: 49325), LayoutImmutable, Blittable]
		public bool HostMigratable { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Ranked", Offset: 5, NameHash: 3298743058, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ranked { get; set; } // 0x5 (5)
		
		[ContainerField(Name: "AdminOnlyInvites", Offset: 6, NameHash: 2276687108, Flags: 49325), LayoutImmutable, Blittable]
		public bool AdminOnlyInvites { get; set; } // 0x6 (6)
		
		[ContainerField(Name: "EnforceSingleGroupJoin", Offset: 7, NameHash: 1761202676, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnforceSingleGroupJoin { get; set; } // 0x7 (7)
		
		[ContainerField(Name: "JoinInProgressSupported", Offset: 8, NameHash: 583156691, Flags: 49325), LayoutImmutable, Blittable]
		public bool JoinInProgressSupported { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "AdminInvitesOnlyIgnoreEntryChecks", Offset: 9, NameHash: 3693756701, Flags: 49325), LayoutImmutable, Blittable]
		public bool AdminInvitesOnlyIgnoreEntryChecks { get; set; } // 0x9 (9)
		
		[ContainerField(Name: "EnablePersistedGameId", Offset: 10, NameHash: 1085160668, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnablePersistedGameId { get; set; } // 0xA (10)
		
		[ContainerField(Name: "AllowSameTeamId", Offset: 11, NameHash: 4182988406, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowSameTeamId { get; set; } // 0xB (11)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4203661745:
					OpenToBrowsing = (bool) p_Value;
					break;

				case 4079225360:
					OpenToInvites = (bool) p_Value;
					break;

				case 1779714654:
					OpenToMatchmaking = (bool) p_Value;
					break;

				case 273410944:
					OpenToJoinByPlayer = (bool) p_Value;
					break;

				case 1465774187:
					HostMigratable = (bool) p_Value;
					break;

				case 3298743058:
					Ranked = (bool) p_Value;
					break;

				case 2276687108:
					AdminOnlyInvites = (bool) p_Value;
					break;

				case 1761202676:
					EnforceSingleGroupJoin = (bool) p_Value;
					break;

				case 583156691:
					JoinInProgressSupported = (bool) p_Value;
					break;

				case 3693756701:
					AdminInvitesOnlyIgnoreEntryChecks = (bool) p_Value;
					break;

				case 1085160668:
					EnablePersistedGameId = (bool) p_Value;
					break;

				case 4182988406:
					AllowSameTeamId = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4203661745:
					return OpenToBrowsing;

				case 4079225360:
					return OpenToInvites;

				case 1779714654:
					return OpenToMatchmaking;

				case 273410944:
					return OpenToJoinByPlayer;

				case 1465774187:
					return HostMigratable;

				case 3298743058:
					return Ranked;

				case 2276687108:
					return AdminOnlyInvites;

				case 1761202676:
					return EnforceSingleGroupJoin;

				case 583156691:
					return JoinInProgressSupported;

				case 3693756701:
					return AdminInvitesOnlyIgnoreEntryChecks;

				case 1085160668:
					return EnablePersistedGameId;

				case 4182988406:
					return AllowSameTeamId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4203661745:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(OpenToBrowsing));

				case 4079225360:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(OpenToInvites));

				case 1779714654:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(OpenToMatchmaking));

				case 273410944:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(OpenToJoinByPlayer));

				case 1465774187:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(HostMigratable));

				case 3298743058:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(Ranked));

				case 2276687108:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(AdminOnlyInvites));

				case 1761202676:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(EnforceSingleGroupJoin));

				case 583156691:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(JoinInProgressSupported));

				case 3693756701:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(AdminInvitesOnlyIgnoreEntryChecks));

				case 1085160668:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(EnablePersistedGameId));

				case 4182988406:
					return typeof(MatchmakingGameSettings).GetProperty(nameof(AllowSameTeamId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
