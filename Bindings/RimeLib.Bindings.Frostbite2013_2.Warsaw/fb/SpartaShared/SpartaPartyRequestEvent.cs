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


namespace fb.SpartaShared;

[ContainerType(1, 4)]
public enum SpartaPartyRequestEvent : int
{
	SpartaPartyRequestEvent_CreateParty = 0,
	SpartaPartyRequestEvent_LeaveParty = 1,
	SpartaPartyRequestEvent_GetPartyMembers = 2,
	SpartaPartyRequestEvent_GetPartyGameId = 3,
	SpartaPartyRequestEvent_SendInvites = 4,
	SpartaPartyRequestEvent_JoinGameSession = 5,
	SpartaPartyRequestEvent_LeaveGameSession = 6,
	SpartaPartyRequestEvent_StartMatchMaking = 7,
	SpartaPartyRequestEvent_GetLocalUser = 8,
	SpartaPartyRequestEvent_GetUserProfiles = 9,
	SpartaPartyRequestEvent_GetServerDetails = 10,
}

