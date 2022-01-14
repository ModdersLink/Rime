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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
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
		ExitToMenuReason_Banned = 9,
		ExitToMenuReason_InteractivityTimeout = 10,
		ExitToMenuReason_KickedOutServerFull = 11,
		ExitToMenuReason_ESportsMatchStarting = 12,
		ExitToMenuReason_NotInESportsRosters = 13,
		ExitToMenuReason_ESportsMatchEnding = 14,
		ExitToMenuReason_VirtualServerExpired = 15,
		ExitToMenuReason_VirtualServerRecreate = 16,
		ExitToMenuReason_ESportsTeamFull = 17,
		ExitToMenuReason_ESportsMatchAborted = 18,
		ExitToMenuReason_ESportsMatchWalkover = 19,
		ExitToMenuReason_ESportsMatchWarmupTimedOut = 20,
		ExitToMenuReason_PremiumStatusMismatch = 21
	}

}
