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
public enum TabletCommanderConnectionDeniedReason : int
{
	TabletCommanderConnectionDeniedReason_None = 0,
	TabletCommanderConnectionDeniedReason_ProtocolMismatch = 1,
	TabletCommanderConnectionDeniedReason_CommanderSlotTaken = 2,
	TabletCommanderConnectionDeniedReason_ServerFull = 3,
	TabletCommanderConnectionDeniedReason_RankRequirement = 4,
	TabletCommanderConnectionDeniedReason_UnknownError = 5,
}

