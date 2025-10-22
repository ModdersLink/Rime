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


namespace fb.Entity;

[ContainerType(1, 4)]
public enum EventConnectionTargetType : int
{
	EventConnectionTargetType_Invalid = 0,
	EventConnectionTargetType_ClientAndServer = 1,
	EventConnectionTargetType_Client = 2,
	EventConnectionTargetType_Server = 3,
	EventConnectionTargetType_NetworkedClient = 4,
	EventConnectionTargetType_NetworkedClientAndServer = 5,
}

