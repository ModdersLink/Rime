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


namespace fb.GameClient;

[ContainerType(1, 4)]
public enum ClientState : int
{
	ClientState_WaitingForStaticBundleLoad = 0,
	ClientState_LoadProfileOptions = 1,
	ClientState_LostConnection = 2,
	ClientState_WaitingForUnload = 3,
	ClientState_Startup = 4,
	ClientState_StartServer = 5,
	ClientState_WaitingForLevel = 6,
	ClientState_StartLoadingLevel = 7,
	ClientState_WaitingForLevelLoaded = 8,
	ClientState_WaitingForLevelLink = 9,
	ClientState_LevelLinked = 10,
	ClientState_WaitingForGhosts = 11,
	ClientState_Ingame = 12,
	ClientState_LeaveIngame = 13,
	ClientState_ConnectToServer = 14,
	ClientState_ShuttingDown = 15,
	ClientState_Shutdown = 16,
	ClientState_None = 17,
}

