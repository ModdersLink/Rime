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


namespace fb.DiceCommonsShared;

[ContainerType(1, 4)]
public enum DiceUIAnalogPadType : int
{
	DiceUIAnalogPadType_LeftStick = 0,
	DiceUIAnalogPadType_RightStick = 1,
	DiceUIAnalogPadType_LeftTrigger = 2,
	DiceUIAnalogPadType_RightTrigger = 3,
	DiceUIAnalogPadType_Count = 4,
}

