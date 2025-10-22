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
public enum UIWorldZoneType : int
{
	UIWorldZoneType_Interaction = 0,
	UIWorldZoneType_Critical = 1,
	UIWorldZoneType_Close = 2,
	UIWorldZoneType_Far = 3,
	UIWorldZoneType_Count = 4,
}

