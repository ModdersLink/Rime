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


namespace fb.Network;

[ContainerType(1, 4)]
public enum SecureReason : int
{
	SecureReason_Ok = 0,
	SecureReason_WrongProtocolVersion = 1,
	SecureReason_WrongTitleVersion = 2,
	SecureReason_ServerFull = 3,
	SecureReason_KickedOut = 4,
	SecureReason_Banned = 5,
	SecureReason_GenericError = 6,
	SecureReason_WrongPassword = 7,
	SecureReason_KickedOutDemoOver = 8,
	SecureReason_RankRestricted = 9,
	SecureReason_ConfigurationNotAllowed = 10,
	SecureReason_ServerReclaimed = 11,
	SecureReason_MissingContent = 12,
	SecureReason_NotVerified = 13,
	SecureReason_TimedOut = 14,
	SecureReason_ConnectFailed = 15,
	SecureReason_NoReply = 16,
	SecureReason_AcceptFailed = 17,
	SecureReason_MismatchingContent = 18,
	SecureReason_KickedOutRankTooHigh = 19,
	SecureReason_InteractivityTimeout = 20,
	SecureReason_KickedFromQueue = 21,
	SecureReason_TeamKills = 22,
	SecureReason_KickedByAdmin = 23,
	SecureReason_KickedViaPunkBuster = 24,
	SecureReason_KickedOutServerFull = 25,
	SecureReason_ESportsMatchStarting = 26,
	SecureReason_NotInESportsRosters = 27,
	SecureReason_ESportsMatchEnding = 28,
	SecureReason_VirtualServerExpired = 29,
	SecureReason_VirtualServerRecreate = 30,
	SecureReason_ESportsTeamFull = 31,
	SecureReason_ESportsMatchAborted = 32,
	SecureReason_ESportsMatchWalkover = 33,
	SecureReason_ESportsMatchWarmupTimedOut = 34,
	SecureReason_NotAllowedToSpectate = 35,
	SecureReason_NoSpectateSlotAvailable = 36,
	SecureReason_InvalidSpectateJoin = 37,
	SecureReason_KickedViaFairFight = 38,
	SecureReason_KickedCommanderOnLeave = 39,
	SecureReason_KickedCommanderAfterMutiny = 40,
	SecureReason_ServerMaintenance = 41,
	SecureReason_KickedGameTimeAccountOnUnofficial = 42,
}

