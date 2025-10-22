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


namespace fb.Venice;

[ContainerType(1, 4)]
public enum UIIOStatus : int
{
	UIIOStatus_LoadStart = 0,
	UIIOStatus_LoadComplete = 1,
	UIIOStatus_SaveStart = 2,
	UIIOStatus_SaveComplete = 3,
}

