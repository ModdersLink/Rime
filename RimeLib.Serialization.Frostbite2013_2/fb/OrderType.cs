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
public enum OrderType : int
{
	OrderType_None = 0,
	OrderType_RequestHeal = 1,
	OrderType_LetMeHeal = 2,
	OrderType_RequestAmmo = 3,
	OrderType_LetMeGiveAmmo = 4,
	OrderType_LetMeRepair = 5,
	OrderType_RequestRepair = 6,
	OrderType_RequestRide = 7,
	OrderType_GoGoGo = 8,
	OrderType_FollowMe = 9,
	OrderType_Negative = 10,
	OrderType_Sorry = 11,
	OrderType_ThankYou = 12,
	OrderType_RogerThat = 13,
	OrderType_NeedBackup = 14,
	OrderType_GetIn = 15,
	OrderType_GetOut = 16,
	OrderType_Attack = 17,
	OrderType_RequestSquadOrder = 18,
	OrderType_RequestCommanderOrder = 19,
	OrderType_RequestSupply = 20,
	OrderType_RequestVehicle = 21,
	OrderType_RequestScan = 22,
	OrderType_AcceptOrder = 23,
	OrderType_DenyOrder = 24,
	OrderType_RequestComm = 25,
	OrderType_Count = 26,
}

