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
public enum SpartaPartyResponseEvent : int
{
	SpartaPartyResponseEvent_GameSessionAvailable = 0,
	SpartaPartyResponseEvent_PartyUpdated = 1,
	SpartaPartyResponseEvent_PartyMembersRetrieved = 2,
	SpartaPartyResponseEvent_CreatePartyResponse = 3,
	SpartaPartyResponseEvent_LeavePartyResponse = 4,
	SpartaPartyResponseEvent_JoinPartyResponse = 5,
	SpartaPartyResponseEvent_SendInvitesResponse = 6,
	SpartaPartyResponseEvent_SwitchUser = 7,
	SpartaPartyResponseEvent_GetPartyGameIdResponse = 8,
	SpartaPartyResponseEvent_GetLocalUserResponse = 9,
	SpartaPartyResponseEvent_GetUserProfilesResponse = 10,
	SpartaPartyResponseEvent_GetServerDetailsResponse = 11,
}

