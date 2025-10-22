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
public enum GrenadeType : int
{
	GrenadeType_NotSet = 0,
	GrenadeType_Frag = 1,
	GrenadeType_Smoke = 2,
	GrenadeType_Flash = 3,
}

