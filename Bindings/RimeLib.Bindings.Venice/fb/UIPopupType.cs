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
	[MemberInfoFlag(137), ContainerEnum]
	public enum UIPopupType : int
	{
		PopupType_MemCard = 0,
		PopupType_ControllerDisconnected = 1,
		PopupType_Login = 2,
		PopupType_TermsOfService = 3,
		PopupType_PrivacyPolicy = 4,
		PopupType_RevivePrompt = 5,
		PopupType_Generic = 6,
		PopupType_ServerReminder = 7,
		PopupType_Error = 8,
		PopupType_ManagePlayer = 9,
		PopupType_Invalid = 10,
		PopupType_IngamePlayer = 11,
		PopupType_OnlinePass = 12,
		PopupType_Origin = 13,
		PopupType_UpdateAvailable = 14,
		PopupType_Dynamic = 15,
		PopupType_GameQueue = 16,
		PopupType_COOPMatchmaking = 17,
		PopupType_PromoInfo = 18
	}

}
