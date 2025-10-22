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
public enum CommanderCameraType : int
{
	CommanderCameraType_NoCamera = 0,
	CommanderCameraType_TopDownCamera = 1,
	CommanderCameraType_FirstPersonCamera = 2,
	CommanderCameraType_BaseCamera = 3,
	CommanderCameraType_TargetCamera = 4,
	CommanderCameraType_Count = 5,
}

