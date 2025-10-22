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


namespace fb.GameShared;

[ContainerType(1, 4)]
public enum ServerFpsState : int
{
	ServerFpsState_Disabled = 0,
	ServerFpsState_AboveThreshold = 1,
	ServerFpsState_BelowThreshold = 2,
	ServerFpsState_BelowCriticalThreshold = 3,
	ServerFpsState_Count = 4,
}

