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


namespace fb.Online;

[ContainerType(1, 4)]
public enum InviteType : int
{
	InviteType_Invalid = 0,
	InviteType_Invite = 1,
	InviteType_JoinSession = 2,
	InviteType_JoinFriendSession = 3,
	InviteType_JoinFriendSessionIncomplete = 4,
	InviteType_JoinGameId = 5,
	InviteType_Count = 6,
}

