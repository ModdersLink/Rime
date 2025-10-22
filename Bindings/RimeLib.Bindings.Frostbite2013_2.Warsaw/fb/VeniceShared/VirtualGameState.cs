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
public enum VirtualGameState : int
{
	VirtualGameState_Inactive = 0,
	VirtualGameState_Active = 1,
	VirtualGameState_Expired = 2,
	VirtualGameState_Recreate = 3,
	VirtualGameState_Updated = 4,
}

