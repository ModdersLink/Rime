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


namespace fb.SoldierShared;

[ContainerType(1, 4)]
public enum AnimatedFireEnum : int
{
	AnimatedFireAutomatic = 0,
	AnimatedFireSingle = 1,
	AnimatedFireHoldAndRelease = 2,
	AnimatedFireDelayedSingleShot = 3,
	AnimatedFireSimple = 4,
}

