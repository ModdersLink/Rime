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
public enum ProximityObjectType : int
{
	PotProximityDisabled = 0,
	PotVaultableLow = 1,
	PotVaultableHigh = 2,
	PotSupportedShooting = 3,
	PotInteractWith = 4,
	PotBashable = 5,
}

