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
public enum SpectatorMode : int
{
	SpectatorMode_TableTop = 0,
	SpectatorMode_FirstPerson = 1,
	SpectatorMode_ThirdPerson = 2,
	SpectatorMode_FreeCamera = 3,
	SpectatorMode_NoCameraControl = 4,
}

