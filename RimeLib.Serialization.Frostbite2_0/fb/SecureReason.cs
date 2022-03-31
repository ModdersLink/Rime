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
	[ContainerType(4, 4)]
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
		SecureReason_InteractivityTimeout = 19,
		SecureReason_KickedFromQueue = 20,
		SecureReason_TeamKills = 21,
		SecureReason_KickedByAdmin = 22,
		SecureReason_KickedViaPunkBuster = 23,
		SecureReason_KickedOutServerFull = 24,
		SecureReason_ESportsMatchStarting = 25,
		SecureReason_NotInESportsRosters = 26,
		SecureReason_ESportsMatchEnding = 27,
		SecureReason_VirtualServerExpired = 28,
		SecureReason_VirtualServerRecreate = 29,
		SecureReason_ESportsTeamFull = 30,
		SecureReason_ESportsMatchAborted = 31,
		SecureReason_ESportsMatchWalkover = 32,
		SecureReason_ESportsMatchWarmupTimedOut = 33,
		SecureReason_NotAllowedToSpectate = 34,
		SecureReason_NoSpectateSlotAvailable = 35,
		SecureReason_InvalidSpectateJoin = 36,
		SecureReason_PremiumStatusMismatch = 37
	}

}
