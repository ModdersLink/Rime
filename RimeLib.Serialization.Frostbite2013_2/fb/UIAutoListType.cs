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


namespace fb.VeniceShared;

[ContainerType(1, 4)]
public enum UIAutoListType : int
{
	FriendsAll = 0,
	FriendsPlayingSameTitle = 1,
	FriendsOnline = 2,
	FriendsParty = 3,
	FriendsOffline = 4,
	FriendsListSelf = 5,
	FriendsListEmpty = 6,
	FakeListData = 7,
	ChallengesPending = 8,
	ChallengesActive = 9,
	ChallengesCompleted = 10,
	Standings = 11,
	FriendsHavePlayedSameTitle = 12,
}

