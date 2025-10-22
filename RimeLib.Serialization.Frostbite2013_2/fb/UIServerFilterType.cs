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
public enum UIServerFilterType : int
{
	UIServerFilterType_Slots = 0,
	UIServerFilterType_Mode = 1,
	UIServerFilterType_Level = 2,
	UIServerFilterType_GameType = 3,
	UIServerFilterType_ServerType = 4,
	UIServerFilterType_Region = 5,
	UIServerFilterType_Extra = 6,
	UIServerFilterType_Count = 7,
}

