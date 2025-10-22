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
public enum RadiosityTypeOverride : int
{
	RadiosityTypeOverride_None = 0,
	RadiosityTypeOverride_Dynamic = 1,
	RadiosityTypeOverride_LightProbe = 2,
	RadiosityTypeOverride_TerrainProjected = 3,
}

