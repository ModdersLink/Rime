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


namespace fb.GameShared;

[ContainerType(1, 4)]
public enum ExitToMenuReason : int
{
	ExitToMenuReason_None = 0,
	ExitToMenuReason_UserDisconnected = 1,
	ExitToMenuReason_DisconnectedFromServer = 2,
	ExitToMenuReason_UnableToConnectToServer = 3,
	ExitToMenuReason_ClientDisconnected = 4,
	ExitToMenuReason_FirstPartyConnectionFailed = 5,
	ExitToMenuReason_MissingContent = 6,
	ExitToMenuReason_TeamKills = 7,
	ExitToMenuReason_KickedByAdmin = 8,
	ExitToMenuReason_KickedViaPunkBuster = 9,
	ExitToMenuReason_KickedViaFairFight = 10,
	ExitToMenuReason_Banned = 11,
	ExitToMenuReason_InteractivityTimeout = 12,
	ExitToMenuReason_KickedOutServerFull = 13,
	ExitToMenuReason_ESportsMatchStarting = 14,
	ExitToMenuReason_NotInESportsRosters = 15,
	ExitToMenuReason_ESportsMatchEnding = 16,
	ExitToMenuReason_VirtualServerExpired = 17,
	ExitToMenuReason_VirtualServerRecreate = 18,
	ExitToMenuReason_ESportsTeamFull = 19,
	ExitToMenuReason_ESportsMatchAborted = 20,
	ExitToMenuReason_ESportsMatchWalkover = 21,
	ExitToMenuReason_ESportsMatchWarmupTimedOut = 22,
	ExitToMenuReason_WantToConnectToOnline = 23,
	ExitToMenuReason_KickedOutRankTooHigh = 24,
}

