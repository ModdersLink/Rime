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


namespace fb.SpartaShared;

[ContainerType(1, 4)]
public enum DisconnectionType : int
{
	DisconnectionType_Ok = 0,
	DisconnectionType_Server = 1,
	DisconnectionType_Presence = 2,
}

