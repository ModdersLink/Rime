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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum PresenceRequest : int
	{
		PresenceRequest_Invalid = 0,
		PresenceRequest_DownloadBlob = 1,
		PresenceRequest_UploadBlob = 2,
		PresenceRequest_DownloadUserSettings = 3,
		PresenceRequest_UploadUserSettings = 4,
		PresenceRequest_InitializeCommerceService = 5,
		PresenceRequest_ShutDownCommerceService = 6,
		PresenceRequest_EnumerateCommerceContent = 7,
		PresenceRequest_PurchaseCommerceContent = 8,
		PresenceRequest_PurchaseConsumableCommerceContent = 9,
		PresenceRequest_ConsumeCommerceContent = 10,
		PresenceRequest_GetCommerceContentImage = 11,
		PresenceRequest_CheckOnlinePass = 12,
		PresenceRequest_PurchaseOnlinePass = 13,
		PresenceRequest_RedeemOnlinePassCode = 14,
		PresenceRequest_SetOverlayUrl = 15,
		PresenceRequest_ListEntitlements = 16,
		PresenceRequest_GrantEntitlement = 17,
		PresenceRequest_GetFriends = 18,
		PresenceRequest_InviteFriend = 19,
		PresenceRequest_RemoveFriend = 20,
		PresenceRequest_HttpGet = 21,
		PresenceRequest_JoinGameByOnlineNativeData = 22,
		PresenceRequest_DownloadUpdate = 23,
		PresenceRequest_SendMessage = 24,
		PresenceRequest_CreatePlaygroup = 25,
		PresenceRequest_JoinPlaygroup = 26,
		PresenceRequest_JoinPlaygroupByUsername = 27,
		PresenceRequest_JoinPlaygroupByOnlineNativeData = 28,
		PresenceRequest_JoinPlaygroupByInviteToken = 29,
		PresenceRequest_SetPlaygroupAttribute = 30,
		PresenceRequest_LeavePlaygroup = 31,
		PresenceRequest_DownloadStatistics = 32,
		PresenceRequest_GetLeaderboard = 33,
		PresenceRequest_UploadProgression = 34,
		PresenceRequest_SendInvite = 35,
		PresenceRequest_KickFromPlaygroup = 36,
		PresenceRequest_ViewInvite = 37,
		PresenceRequest_SendInviteToLiveParty = 38,
		PresenceRequest_SetUserInfoAttribute = 39,
		PresenceRequest_GetServerBrowserSnapshot = 40,
		PresenceRequest_GetGamesWithFriends = 41,
		PresenceRequest_GetGamesByServerId = 42,
		PresenceRequest_GetDetailedServerInfo = 43,
		PresenceRequest_UnlockAchievements = 44,
		PresenceRequest_RspGetServers = 45,
		PresenceRequest_RspGetServerDetails = 46,
		PresenceRequest_RspUpdateServerSettings = 47,
		PresenceRequest_RspGetConfig = 48,
		PresenceRequest_RspRestartServer = 49,
		PresenceRequest_RspUpdatePreset = 50,
		PresenceRequest_RspUpdateMapRotation = 51,
		PresenceRequest_RspUpdateAdminUser = 52,
		PresenceRequest_RspUpdateBannedUser = 53,
		PresenceRequest_RspUpdateVipUser = 54,
		PresenceRequest_RspUpdateServerBanner = 55,
		PresenceRequest_ReportServerBanner = 56,
		PresenceRequest_GetUserId = 57,
		PresenceRequest_VerifyGrantEntitlement = 58,
		PresenceRequest_ResetStatistics = 59,
		PresenceRequest_GetXPromoInformation = 60,
		PresenceRequest_GetContentInformation = 61,
		PresenceRequest_DownloadPromoItem = 62,
		PresenceRequest_Count = 63
	}

}
