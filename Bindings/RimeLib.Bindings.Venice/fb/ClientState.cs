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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
	public enum ClientState : int
	{
		ClientState_WaitingForStaticBundleLoad = 0,
		ClientState_LoadProfileOptions = 1,
		ClientState_LostConnection = 2,
		ClientState_Startup = 3,
		ClientState_StartServer = 4,
		ClientState_WaitingForLevel = 5,
		ClientState_StartLoadingLevel = 6,
		ClientState_WaitingForLevelLoaded = 7,
		ClientState_WaitingForLevelLink = 8,
		ClientState_LevelLinked = 9,
		ClientState_WaitingUIIngame = 10,
		ClientState_Ingame = 11,
		ClientState_ConnectToServer = 12,
		ClientState_WaitingUILoading = 13,
		ClientState_WaitingUIUnload = 14,
		ClientState_None = 15
	}

}
