///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
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
		OrderType_Count = 18
	}

}
