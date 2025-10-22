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


namespace fb.GameServer;

[ContainerType(1, 4)]
public enum PickupAction : int
{
	PickupAction_Pickup = 0,
	PickupAction_Drop = 1,
	PickupAction_Created = 2,
	PickupAction_Destroyed = 3,
	PickupAction_DestroyedByPickup = 4,
}

