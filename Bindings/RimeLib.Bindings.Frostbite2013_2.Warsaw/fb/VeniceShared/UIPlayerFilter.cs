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


namespace fb.VeniceShared;

[ContainerType(1, 4)]
public enum UIPlayerFilter : int
{
	UIPlayerFilter_All = 0,
	UIPlayerFilter_LocalTeam = 1,
	UIPlayerFilter_EnemyTeam = 2,
	UIPlayerFilter_LocalPlayer = 3,
	UIPlayerFilter_Count = 4,
}

