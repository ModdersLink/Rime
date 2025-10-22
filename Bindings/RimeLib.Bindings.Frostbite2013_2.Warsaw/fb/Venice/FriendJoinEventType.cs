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


namespace fb.Venice;

[ContainerType(1, 4)]
public enum FriendJoinEventType : int
{
	FriendJoinEventType_None = 0,
	FriendJoinEventType_TargetLeft = 1,
	FriendJoinEventType_TargetIsJoiningFriend = 2,
	FriendJoinEventType_TargetWithFriend = 3,
	FriendJoinEventType_TargetTeam = 4,
	FriendJoinEventType_TeamFull = 5,
	FriendJoinEventType_JoinedSquad = 6,
	FriendJoinEventType_CreatedSquad = 7,
	FriendJoinEventType_MaxSquads = 8,
	FriendJoinEventType_SquadFull = 9,
	FriendJoinEventType_NoSquad = 10,
	FriendJoinEventType_Aborted = 11,
	FriendJoinEventType_LeftGame = 12,
}

