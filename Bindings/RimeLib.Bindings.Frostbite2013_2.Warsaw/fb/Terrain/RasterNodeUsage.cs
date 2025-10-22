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


namespace fb.Terrain;

[ContainerType(1, 4)]
public enum RasterNodeUsage : int
{
	RasterNodeUsage_Default = 0,
	RasterNodeUsage_Disabled = 1,
	RasterNodeUsage_Persistent = 2,
	RasterNodeUsage_PersistentDedicatedServer = 3,
	RasterNodeUsage_Skipped = 4,
}

