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
public enum InteractionEntityType : int
{
	IET_None = 0,
	IET_RushCrateArm = 1,
	IET_RushCrateDisarm = 2,
	IET_ObliterationDropOffArm = 3,
	IET_CTFFlag = 4,
}

