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
	PopupType_Origin = 12,
	PopupType_UpdateAvailable = 13,
	PopupType_Dynamic = 14,
	PopupType_GameQueue = 15,
	PopupType_COOPMatchmaking = 16,
	PopupType_PromoInfo = 17,
	PopupType_Store = 18,
	PopupType_ItemRedeemed = 19,
	PopupType_BattlelogNotification = 20,
	PopupType_LicenseAdded = 21,
	PopupType_StatsMigrationPrompt = 22,
	PopupType_StatsMigrationConfirmAccept = 23,
	PopupType_StatsMigrationConfirmDecline = 24,
	PopupType_StatsMigrationEndFlow = 25,
	PopupType_PlayStationPlus = 26,
	PopupType_TwinkleRollback = 27,
	PopupType_TwinkleSignatureFailure = 28,
}

