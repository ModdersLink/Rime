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


namespace fb.Core;

[ContainerType(1, 4)]
public enum GamePlatform : int
{
	GamePlatform_Ps3 = 0,
	GamePlatform_Win32 = 1,
	GamePlatform_Xenon = 2,
	GamePlatform_Gen4a = 3,
	GamePlatform_Gen4b = 4,
	GamePlatform_Any = 5,
	GamePlatform_Invalid = 6,
	GamePlatformCount = 7,
}

