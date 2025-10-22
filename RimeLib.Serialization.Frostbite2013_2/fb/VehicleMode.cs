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


namespace fb.Physics;

[ContainerType(1, 4)]
public enum VehicleMode : int
{
	VmIdle = 0,
	VmEntering = 1,
	VmEntered = 2,
	VmStarting = 3,
	VmStarted = 4,
	VmStopping = 5,
	VmLeaving = 6,
}

