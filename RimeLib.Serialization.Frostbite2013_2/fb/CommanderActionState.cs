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
public enum CommanderActionState : int
{
	CommanderActionState_Disabled = 0,
	CommanderActionState_Idle = 1,
	CommanderActionState_WarmUp = 2,
	CommanderActionState_Running = 3,
	CommanderActionState_CoolDown = 4,
	CommanderActionState_Frozen = 5,
	CommanderActionState_Count = 6,
}

