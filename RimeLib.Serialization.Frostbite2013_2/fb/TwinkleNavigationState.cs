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


namespace fb.TwinkleShared;

[ContainerType(1, 4)]
public enum TwinkleNavigationState : int
{
	NavigationState_None = 0,
	NavigationState_FrontEnd = 1,
	NavigationState_LoadingScreen = 2,
	NavigationState_InGameMenu = 3,
	NavigationState_EndOfRound = 4,
}

